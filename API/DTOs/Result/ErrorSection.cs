using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class ErrorSection
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public sbyte Code { get; set; }
    }
}