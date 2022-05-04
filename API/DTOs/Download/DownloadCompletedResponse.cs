using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class DownloadCompletedResponse
    {
        [JsonProperty("completed")]
        public Boolean Completed { get; set; }

        [JsonProperty("tasks")]
        public TasksResponse[] Tasks { get; set; }

        [JsonProperty("developerPayload")]
        public string DeveloperPayload { get; set; }
    }
}