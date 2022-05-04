using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class FullSourcePagesSection
    {
        [JsonProperty("startPosition")]
        public uint[] StartPosition { get; set; }
    }
}