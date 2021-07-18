using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class UART_BreakPoint
    {
        public String BreakPointAddress
        {
            get;
            set;
        }
        public String FunctionName { get; set; }
        public String Variable { get; set; }
        public int Operation { get; set; }

    }
}
