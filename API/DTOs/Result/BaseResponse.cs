using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs.Types;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class BaseResponse
    {
        [JsonProperty("status")]
        public eScanStatus Status { get; set; }

        [JsonProperty("error")]
        public ErrorSection Error { get; set; }

        [JsonProperty("developerPayload")]
        public string Payload { get; set; }
    }
}