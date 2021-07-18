using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler
{
    public class Constants
    {
        public const UInt16 UART_PACKET_SIGNATURE = 0xACAC;
        public enum SCREEN{
            DYNAMIC_BREAKPOINT,
            HEALTH_STATUS
        }
        public const int PerHealthDataReceviedByteLength = 4;
    }
}
