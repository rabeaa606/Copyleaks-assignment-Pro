using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class NotificationSection
    {
        [JsonProperty("alerts")]
        public AlertNotification[] Alerts { get; set; }
    }
}