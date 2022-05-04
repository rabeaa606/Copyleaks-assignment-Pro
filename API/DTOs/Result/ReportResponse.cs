using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs.Types;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class ReportResponse
    {
        [JsonProperty("report")]
        public Uri DownloadEndPoint { get; set; }

        [JsonProperty("status")]
        public eReportStatus Status { get; set; }
    }
}