using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class DownloadSourceResponse
    {
        [JsonProperty("metadata")]
        public MetadataSection Metadata { get; set; }

        [JsonProperty("html")]
        public FullHtmlSourceSubVersionSection Html { get; set; }

        [JsonProperty("text")]
        public FullTextSourceSubVersionSection Text { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}