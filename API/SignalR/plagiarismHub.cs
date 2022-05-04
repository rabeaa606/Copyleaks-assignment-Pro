using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using API.DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API.SignalR
{
    public class plagiarismHub : Hub
    {
        String access_token;
        public override async Task OnConnectedAsync()
        {

        }

        // public async Task CheckContent(ContentModel contentModel)
        // {
        //     var requestUrl0 = "https://id.copyleaks.com/v3/account/login/api";

        //     using (var httpClient = new HttpClient())
        //     {
        //         using (var request = new HttpRequestMessage(new HttpMethod("POST"), requestUrl0))
        //         {

        //             var data = "{\"email\":\"john.atlas2022@gmail.com\",\"key\":\"9a86b2d1-f665-4368-9dfd-dda278e47d44\"}";
        //             request.Content = new StringContent(data, Encoding.UTF8, "application/json");

        //             var response = await httpClient.SendAsync(request);

        //             dynamic resp = JObject.Parse(response.Content.ReadAsStringAsync().Result);
        //             access_token = resp.access_token;

        //             Console.WriteLine("access_token :" + access_token);

        //         }
        //     }
        //     string[] lines = { contentModel.Content };
        //     string filename = "content.txt";
        //     await File.WriteAllLinesAsync(filename, lines);

        //     if (access_token != null)
        //     {
        //         var requestUrl = "https://api.copyleaks.com/v3/education/submit/file/" + contentModel.Content;

        //         using (var httpClient = new HttpClient())
        //         {
        //             using (var request = new HttpRequestMessage(new HttpMethod("PUT"), requestUrl))
        //             {
        //                 request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + access_token);

        //                 var data = "{\"base64\":\"" + contentModel.Content + "\",\"filename\":\"" + filename + "\",\"properties\":{\"sandbox\":true,\"webhooks\":{\"status\":\"https://800b-2001-4df4-209d-2600-a077-4d74-8a0f-73f9.ngrok.io/webhook/{STATUS}/" + contentModel.Content + "\"}}}";
        //                 request.Content = new StringContent(data, Encoding.UTF8, "application/json");

        //                 Console.WriteLine(JObject.Parse(request.Content.ReadAsStringAsync().Result));
        //                 var response = await httpClient.SendAsync(request);
        //             }
        //         }
        //     }

        // }
    }







}



