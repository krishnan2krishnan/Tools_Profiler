using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UART_Profiler.Model;

namespace UART_Profiler.Model
{
    public class UART_BreakPoint_Structure
    {
        public UART_Byte_Zero_Struct signature
        {
            get;
            set;
        }
        public UInt32 monitorAddress
        {
            get;
            set;
        }
        public UInt32 addressToPrint
        {
            get;
            set;
        }
        public UInt32 Length
        {
            get;
            set;
        }
    }
}
