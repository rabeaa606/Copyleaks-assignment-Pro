using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class Result : BaseResponse
    {
        [JsonProperty("scannedDocument")]
        public ScannedDocumentSection ScannedDocument { get; set; }

        [JsonProperty("results")]
        public ResultsSection Results { get; set; }

        [JsonProperty("notifications")]
        public NotificationSection Notifications { get; set; }
    }
}