using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{

    public class FullTextSourceExcludeSection
    {
        [JsonProperty("starts")]
        public int[] Starts { get; set; }

        [JsonProperty("lengths")]
        public int[] Lengths { get; set; }

        [JsonProperty("reasons")]
        public int[] Reasons { get; set; }
    }
    public class FullHtmlSourceExcludeSection : FullTextSourceExcludeSection
    {
        [JsonProperty("groupIds")]
        public int[] GroupIds { get; set; }
    }
}