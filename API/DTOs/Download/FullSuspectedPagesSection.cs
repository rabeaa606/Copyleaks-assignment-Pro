using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class FullSuspectedPagesSection
    {

        [JsonProperty("startPosition")]
        public int[] StartPosition { get; set; }
    }
}