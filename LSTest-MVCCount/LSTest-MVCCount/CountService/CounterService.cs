using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSTest_MVCCount.CountService
{
    public interface ICounterService
    {
        int IncreaseCount();
        int GetCurrentCount();
        int ResetCount();
    }
}