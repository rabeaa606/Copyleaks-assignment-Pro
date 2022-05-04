using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class TasksResponse
    {
        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("httpStatusCode")]
        public int HttpStatusCode { get; set; }

        [JsonProperty("isHealthy")]
        public bool IsHealthy { get; set; }
    }
}