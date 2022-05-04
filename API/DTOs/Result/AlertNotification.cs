using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs.Types;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class AlertNotification
    {
        [JsonProperty("additionalData")]
        public string AdditionalData { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("helpLink")]
        public string HelpLink { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("severity")]
        public eAlertSeverity Severity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}