using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class DownloadResultResponse
    {
        [JsonProperty("statistics")]
        public FullSuspectedStatisticsSection Statistics { get; set; }

        [JsonProperty("text")]
        public FullTextSuspectedVersionSection Text { get; set; }

        [JsonProperty("html")]
        public FullHtmlSuspectedVersionSection Html { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}