using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs.Types
{
    public enum eScanStatus
    {
        Error = 1,
        CompletedSuccessfully = 0,

        CreditsChecked = 2,
        Indexed = 3,
        InProgress = 4
    }
}