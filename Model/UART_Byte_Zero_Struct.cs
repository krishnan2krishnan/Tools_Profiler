using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class UART_Byte_Zero_Struct
    {
        public UInt16 Signature
        {
            get;
            set;
        }
        public byte ActionPoint
        {
            get;
            set;
        }
        public byte Action
        {
            get;
            set;
        }

        public UART_Byte_Zero_Struct()
        {
            Signature = Constants.UART_PACKET_SIGNATURE;
        }

    }
}
