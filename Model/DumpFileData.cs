using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UART_Profiler.Model
{
    public class DumpFileData
    {
        public long LineNumber { get; set; }
        public String Content { get; set; }
        public String FuncName { get; set; }
        public String Address { get; set; }
        public int Size { get; set; }

        public DumpFileData()
        {
            LineNumber = 0;
            Content = FuncName = Address = "";
            Size = 0;
        }
    }
}
