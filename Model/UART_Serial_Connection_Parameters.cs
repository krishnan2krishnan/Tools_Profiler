using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class UARTSerialConnectionParam
    {
        public string portName;
        public int baudRate;
        public Parity parity;
        public int dataBits;
        public StopBits stopBits;

        public UARTSerialConnectionParam(string _PortName, int _BaudRate, Parity _Parity, int _DataBits, StopBits _StopBits)
        {
            portName = _PortName;
            baudRate = _BaudRate;
            parity = _Parity;
            dataBits = _DataBits;
            stopBits = _StopBits;
        }

    }
}
