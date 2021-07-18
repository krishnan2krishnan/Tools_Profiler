using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_Profiler.Model;

namespace UART_Profiler.Dialogs
{

    public partial class BreakPointForm : Form
    {
        FwSettings _fwSettings;
        DynamicBreakPoint _parentForm;
        public BreakPointForm(FwSettings fwSettings , DynamicBreakPoint parentForm)
        {
            _fwSettings = fwSettings;
            _parentForm = parentForm;
            InitializeComponent();
            ParseDumpFile();
            ParseMapFile();
        }
        private void ParseMapFile()
        {
            var fileStream = new FileStream(_fwSettings.MapFilePath, FileMode.Open, FileAccess.Read);
            Dictionary<String, List<MapFileData>> data = new Dictionary<String,List<MapFileData>>();
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line = "";
                int lineNumber = 0;
                bool startParse = false;
                string SymbolName = String.Empty;
                string section = String.Empty, address = String.Empty , symbol = String.Empty , module = String.Empty;
                bool skipFirstLine = true;

                while ((line = streamReader.ReadLine()) != null)
                {
                    //check for line empty
                    if(String.IsNullOrEmpty(line.Trim()))
                        continue;

                    if (line.Contains("GLOBAL SYMBOLS SUMMARY"))
                    {
                        startParse = true;
                        continue;
                    }
                    else if (line.Contains("SYMBOL         BINDING SECTION   VALUE     MODULE"))
                    {
                        continue;
                    }

                    if (line.Contains("START ADDRESS"))
                    {
                        //end parse map file
                        startParse = false;
                        return;
                    }
                    if (startParse)
                    {
                        if (skipFirstLine)
                            skipFirstLine = false;
                        else
                        {
                            // process the line
                            string[] splitData = line.Trim().Split(' ');

                            IEnumerable<string> query = splitData.Where(item => String.Empty != item.Trim());

                            var filedata = query.ToArray();
                            if (filedata.Length == 5)
                            {
                                symbol = filedata[0];
                                section = filedata[2];
                                address = filedata[3];
                                module = filedata[4];
                            }
                            else if (filedata.Length == 1)
                            {
                                //cache the symbol and read next line for other data
                                symbol = filedata[0];
                                continue;
                            }
                            else if (filedata.Length == 4)
                            {
                                //pick rest of the information
                                section = filedata[1];
                                address = filedata[2];
                                module = filedata[3];
                            }
                            else
                            {
                                continue;
                            }

                            var mapFileData = new MapFileData { LineNumber = lineNumber, Content = line, Address = address, Symbol = symbol, Module = module, Section = section };
                            
                            if(!data.ContainsKey(section))
                            {
                                data.Add(section, new List<MapFileData>());
                            }
                            mapFileDataBindingSource.Add(mapFileData);

                            data[section].Add(mapFileData);
                            
                            lineNumber++;
                        }
                    }       
                }

            }
        }
        void UpdateSize(List<MapFileData> data)
        {
            MapFileData lastMapFileData = null;
            //iterate through collection
            for (int i = 0; i < data.Count; i++)
            {
                if (i == 0)
                    lastMapFileData = data[0];
                else
                {
                    MapFileData current = data[i];
                    data[i].Size = (int)(Convert.ToUInt64(current.Address) - Convert.ToUInt64(lastMapFileData.Address));
                }
            }
            //split content
        }
        private void ParseDumpFile()
        {
            var fileStream = new FileStream(_fwSettings.DumpFilePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line = "";
                int lineNumber = 0;
                bool startParse = false;
                bool stopParse = false;
                string funcName = String.Empty;
                string address = String.Empty;
                bool skipFirstLine = true;
                while ((line = streamReader.ReadLine()) != null)
                {
                    
                    if (line.Contains("Content of section codenp"))
                        startParse = true;
                    
                    if (line.Contains("Content of section bssm"))
                    {
                        stopParse = true;
                        return;
                    }
                    if (startParse)
                    {
                        if (skipFirstLine)
                            skipFirstLine = false;
                        else
                        {
                            // process the line
                            string[] splitData = line.Trim().Split(':');
                            if (splitData.Length == 2 && splitData[1] == "")
                                funcName = splitData[0];
                            else
                                address = splitData[0];

                            dumpFileDataBindingSource.Add(new DumpFileData { LineNumber = lineNumber, Content = line, Address = address, FuncName = funcName });
                            lineNumber++;
                        }
                    }       
                }
            }
        }

        private void dumpFilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDumpFileAddress_TextChanged(object sender, EventArgs e)
        {

        }
        DumpFileData currentObject;
        private void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            if (this.dumpFileGrid.Selected.Rows.Count > 0)
            {
                foreach (UltraGridRow rowSelected in this.dumpFileGrid.Selected.Rows)
                {
                    currentObject = (DumpFileData)this.dumpFileGrid.ActiveRow.ListObject;
                    txtDumpFileAddress.Text = currentObject.Address;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operation = 0;
            if (rbMapHalt.Checked)
            {
                operation = 0;
            }
            else if (rbMapPrint.Checked)
            {
                operation = 1;
            }
            else
            {
                operation = 2;
            }
            //Add it to Dynamic BreakPoint Form
            _parentForm.AddBreakPoint(currentObject , operation);
            this.Close();
        }

        private void mapFileGrid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            if (this.mapFileGrid.Selected.Rows.Count > 0)
            {
                foreach (UltraGridRow rowSelected in this.mapFileGrid.Selected.Rows)
                {
                    txtMapFileAddress.Text = ((MapFileData)this.mapFileGrid.ActiveRow.ListObject).Address;
                }
            }

        }
    }
}
