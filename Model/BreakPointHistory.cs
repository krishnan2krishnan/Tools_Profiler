using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class BreakPointHistory : UART_BreakPoint
    {
        public DateTime BreakPointHitTime { get; set; }
        public long Value { get; set; }
    }
}
