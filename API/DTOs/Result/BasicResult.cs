using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class BasicResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("introduction")]
        public string Introduction { get; set; }
        [JsonProperty("matchedWords")]
        public uint MatchedWords { get; set; }
        [JsonProperty("metadata")]
        public ResultMetaData MetaData { get; set; }
    }
}