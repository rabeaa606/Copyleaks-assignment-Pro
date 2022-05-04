using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public abstract class BasicInternalResult : BasicResult
    {
        [JsonProperty("scanId")]
        public string ScanId { get; set; }
    }
}