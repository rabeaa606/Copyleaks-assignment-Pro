using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class InternetResult : BasicResult
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}