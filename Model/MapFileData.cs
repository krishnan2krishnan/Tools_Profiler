using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class MapFileData
    {
        public long LineNumber { get; set; }
        public String Content { get; set; }
        public String Section { get; set; }
        public String Symbol { get; set; }
        public String Address { get; set; }
        public String Module { get; set; }
        public int Size { get; set; }

        public MapFileData()
        {
            LineNumber = 0;
            Section = Content = Symbol = Address = Module = "";
            Size = 0;
        }
    }
}
