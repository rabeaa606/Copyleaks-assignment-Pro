using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs.Types
{
    public enum eAlertSeverity
    {
        [Description("DEBUG")]
        Debug = 0,

        [Description("INFO")]
        Info = 1,

        [Description("WARNING")]
        Warning = 2,

        [Description("ERROR")]
        Error = 3,

        [Description("CRITICAL")]
        Critical = 4
    }
}