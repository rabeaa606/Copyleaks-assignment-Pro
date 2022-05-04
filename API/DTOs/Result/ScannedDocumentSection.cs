using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class ScannedDocumentSection
    {

        [JsonProperty("scanId")]
        public string ScanId { get; set; }
        [JsonProperty("totalWords")]
        public uint TotalWords { get; set; }
        [JsonProperty("totalExcluded")]
        public uint TotalExcluded { get; set; }
        [JsonProperty("credits")]
        public uint Credits { get; set; }
        [JsonProperty("expectedCredits")]
        public uint ExpectedCredits { get; set; }
        [JsonProperty("creationTime")]
        public DateTime CreationTime { get; set; }
        [JsonProperty("metadata")]
        public ResultMetaData MetaData { get; set; }
    }
}