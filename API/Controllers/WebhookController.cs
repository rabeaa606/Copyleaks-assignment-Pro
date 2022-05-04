using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using API.DTOs;
using API.SignalR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using API.DTOs.Download;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
        static String _access_token = "";
        String public_Ip = "https://4495-2001-4df4-26c-a500-d84f-46f4-4c10-bd94.ngrok.io";

        //private readonly IHubContext _HubContext;
        private IHubContext<plagiarismHub> HubContext
        { get; set; }
        public WebhookController(IHubContext<plagiarismHub> hubcontext)
        {
            HubContext = hubcontext;
        }

        [HttpPost("login-token")]
        public async Task<ActionResult> getAccesToken()
        {
            var requestUrl0 = "https://id.copyleaks.com/v3/account/login/api";
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), requestUrl0))
                {
                    var data = "{\"email\":\"john.atlas2022@gmail.com\",\"key\":\"cfb845fb-ae95-4462-9194-869be0d8a525\"}";
                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = await httpClient.SendAsync(request);
                    dynamic resp = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                    WebhookController._access_token = resp.access_token;

                }
            }
            return Ok();
        }
        [HttpPost("/scan/{content64}/{custom_id}")]
        public async Task Scan(string content64, string custom_id)
        {
            var requestUrl = "https://api.copyleaks.com/v3/education/submit/file/" + custom_id;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), requestUrl))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + WebhookController._access_token);
                    var data = "{\"base64\":\"" + content64 + "\",\"filename\":\"file.txt\",\"properties\":{\"sandbox\":false,\"webhooks\":{\"status\":\"" + public_Ip + "/webhook/{STATUS}/" + custom_id + "\"}}}";
                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        [HttpPost("/webhook/{status}/{id}")]
        public async Task CopyleaksResponse([FromBody] Result result)
        {
            string filename = $"Scans/{result.ScannedDocument.ScanId}/compelte-result.json";
            System.IO.Directory.CreateDirectory($"Scans/{result.ScannedDocument.ScanId}");
            await System.IO.File.WriteAllTextAsync(filename, JsonConvert.SerializeObject(result));

            await this.HubContext.Clients.All.SendAsync("response",
                       new { response = result });
        }

        [HttpPost("/downloads/{scan_id}")]
        public async Task downloads(string scan_id)
        {
            string filename = $"Scans/{scan_id}/compelte-result.json";
            string export_id = Guid.NewGuid().ToString();
            var completeResultString = await System.IO.File.ReadAllTextAsync(filename);
            var compelteResults = JsonConvert.DeserializeObject<Result>(completeResultString);
            var requestUrl = "https://api.copyleaks.com/v3/downloads/" + scan_id + "/export/" + export_id + "";

            var resultsIds =
            compelteResults.Results.Batch.Select(results => results.Id)
            .Concat(
                compelteResults.Results.Internet.Select(results => results.Id).Concat(
                    compelteResults.Results.Database.Select(results => results.Id).Concat(
                        compelteResults.Results.Repositories.Select(results => results.Id)
                    )
                )
            ).ToArray();

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), requestUrl))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + WebhookController._access_token);
                    var exportData = new
                    {
                        results = resultsIds.Select(id => new
                        {
                            id = id,
                            verb = "POST",
                            endpoint = "" + public_Ip + "/export/" + scan_id + "/results/" + id
                        }),
                        crawledVersion = new
                        {
                            verb = "POST",
                            endpoint = "" + public_Ip + "/export/" + scan_id + "/crawled-version"
                        },
                        completionWebhook = $"" + public_Ip + "/export/" + export_id + "/completed",
                        maxRetries = 3
                    };

                    request.Content = new StringContent(JsonConvert.SerializeObject(exportData), Encoding.UTF8, "application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }

        }
        [HttpPost("/export/{export_id}/completed")]
        public async Task CopyleaksDownloadCompleted(DownloadCompletedResponse result)
        {
            await this.HubContext.Clients.All.SendAsync("downloadCompleted",
                       new { downloadCompleted = result });
        }
        [HttpPost("/export/{scanId}/crawled-version")]
        public async Task CopyleaksCrawledVersion([FromBody] DownloadSourceResponse result, [FromRoute] string scanId)
        {
            string filename = $"Scans/{scanId}/crawled-version.json";
            await System.IO.File.WriteAllTextAsync(filename, JsonConvert.SerializeObject(result));
            await this.HubContext.Clients.All.SendAsync("downloadCrawledVersion",
                       new { downloadCrawledVersion = result });
        }
        [HttpPost("/export/{scanId}/results/{resultId}")]
        public async Task CopyleaksResult([FromBody] DownloadResultResponse result, [FromRoute] string scanId, [FromRoute] string resultId)
        {
            string filename = $"Scans/{scanId}/results/{resultId}.json";
            System.IO.Directory.CreateDirectory($"Scans/{scanId}/results");
            await System.IO.File.WriteAllTextAsync(filename, JsonConvert.SerializeObject(result));
            await this.HubContext.Clients.All.SendAsync("downloadResults",
                       new { downloadResults = result });
        }
        [HttpPost("/getCrawledVersionAsync/{scan_id}")]
        public async Task<object> getCrawledVersionAsync(string scan_id)
        {
            string filename = $"Scans/{scan_id}/crawled-version.json";
            using (StreamReader r = new StreamReader(filename))
            {
                string jsonString = r.ReadToEnd();
                return Ok(jsonString);
            }
        }
        [HttpPost("/getCompleteResultAsync/{scan_id}")]
        public async Task<object> getCompleteResultAsync(string scan_id)
        {
            string filename = $"Scans/{scan_id}/compelte-result.json";
            using (StreamReader r = new StreamReader(filename))
            {
                string jsonString = r.ReadToEnd();
                return Ok(jsonString);
            }
        }
        [HttpPost("/getResultByIdAsync/{scanId}/{resultId}")]
        public async Task<ActionResult<object>> getResultByIdAsync([FromRoute] string scanId, [FromRoute] string resultId)
        {
            string filename = $"Scans/{scanId}/results/{resultId}.json";
            using (StreamReader r = new StreamReader(filename))
            {
                string jsonString = r.ReadToEnd();
                return Ok(jsonString);
            }
        }
    }

}