using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class UARTHealthStatus
    {
        public DateTime ReceivedTime { get; set; }
        public UInt32 DeviceHealthData { get; set; }
        public static long GlobalRowIndex { get; set; }
        public long RowIndex { get; set; }
        

        public UARTHealthStatus()
        {
            GlobalRowIndex++;
            RowIndex = GlobalRowIndex;
            ReceivedTime = DateTime.Now;
        }
        public UARTHealthStatus(byte[] datareceived)
        {
            GlobalRowIndex++;
            RowIndex = GlobalRowIndex;
            ReceivedTime = DateTime.Now;
            
        }
        public UARTHealthStatus(long _rowIndex, DateTime _receiveTime, UInt32 _deviceHealth)
        {

            RowIndex = _rowIndex;
            ReceivedTime = _receiveTime;
            DeviceHealthData = _deviceHealth;
        }
    }
}
