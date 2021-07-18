using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_Profiler.Model;
using SLABHIDTOUART_DLL;
using Virtual.CommDriver;
using Infragistics.Win.UltraWinTree;
using Amazon.S3.Transfer;
using System.IO;
namespace UART_Profiler.Dialogs
{
    public partial class DynamicBreakPoint : Form
    {
        Form _parentForm = null;
        UARTSerialConnectionParam uartSerialConnectionParam = null;
        public SerialPort uartSerialPortHandle;
        FwSettings fwSettings;
        string filePath = @"C:\Users\17915\Documents\Hackathon_2019_IDF\BreakPointHistoryData.xlsx";

        public DynamicBreakPoint()
        {
            InitializeComponent();
        }
        public DynamicBreakPoint(Form parentForm)
        {
            _parentForm = parentForm;
            
            InitializeComponent();

            LoadUltraTree();
        }
        public void EstablishUARTConnection()
        {
            uartSerialPortHandle = new SerialPort(uartSerialConnectionParam.portName,
          uartSerialConnectionParam.baudRate, uartSerialConnectionParam.parity, uartSerialConnectionParam.dataBits, uartSerialConnectionParam.stopBits);

            //subscribe to data receive
            uartSerialPortHandle.Handshake = Handshake.None;
            uartSerialPortHandle.DtrEnable = true;    // Data-terminal-ready
            uartSerialPortHandle.RtsEnable = true;    // Request-to-send

            uartSerialPortHandle.DataReceived += new SerialDataReceivedEventHandler(uartSerialPortHandle_DataReceived);
            uartSerialPortHandle.Open();

        }
        void LoadUltraTree()
        {
            // Declare nodes
            UltraTreeNode nodeA;
            UltraTreeNode nodeB;

            // Add two nodes to the WinTree
            nodeA = this.ultraTree1.Nodes.Add("nodeA", "MBMPartMaxPec");
            nodeB = this.ultraTree1.Nodes.Add("nodeB", "MBMPartMinPec");

            // Expand the newly added node
            nodeA.Expanded = true;

            // Add a child node to Node A
            nodeA.Nodes.Add("childNodeofA", "MBMPartAvgPec");

            // Add Node C to WinTree
            this.ultraTree1.Nodes.Add("nodeC", "JBMInternalListSize");

            // Get a reference to Node C using its key
            UltraTreeNode nodeC = this.ultraTree1.GetNodeByKey("nodeC");

            // Add a child node to NodeC
            nodeC.Nodes.Add("childNodeofC", "JBMGenericListSize");
        }
        void BuildDumpView()
        {
            //create a datatable with RowIndex , Data
            DataTable newDt = new DataTable();
            newDt.Columns.Add("RowIndex", typeof(long));
            newDt.Columns.Add("Data", typeof(string));

            //read dump file from fw settings

            
            //set as data source to listview
            //ultraListView1.DataBindings = 
        }

        void uartSerialPortHandle_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            MessageBox.Show("Data Received:" + indata);
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
           
        }

        private void ultraGrid1_DoubleClick(object sender, EventArgs e)
        {
            //show Break Pont Form
            BreakPointForm breakPointForm = new BreakPointForm(fwSettings,this);
            breakPointForm.ShowDialog();
        }
        public void AddBreakPoint(DumpFileData newBreakPoint , int _Operation)
        {
            uARTBreakPointBindingSource.Add(new UART_BreakPoint { BreakPointAddress = newBreakPoint.Address, FunctionName = newBreakPoint.FuncName, Operation = _Operation });
        }

        private void DynamicBreakPoint_Load(object sender, EventArgs e)
        {

            uartSerialConnectionParam = ((UART_PROFILER)_parentForm).uartSerialConnectionParam;
            
            fwSettings = ((UART_PROFILER)_parentForm)._fwSettings;
            ////EstablishUARTConnection();
        }

        private void btnSubmitBreakPoint_Click(object sender, EventArgs e)
        {
            byte [] temp = { 0xac,0xac,0xac,0xac,
                               0xac,0xac,0xac,0xac ,
                               0xac,0xac,0xac,0xac ,
                               0xac,0xac,0xac,0xac  };

            try
            {
                HidPort instance = new HidPort();
                instance.Open();
                
                instance.Write("0xaa");
                
                byte[] readbyte = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                instance.Read(readbyte, 0, 1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUploadToS3_Click(object sender, EventArgs e)
        {
            UploadToS3.Upload(filePath);
        }

        private void picChartView_Click(object sender, EventArgs e)
        {
            BreakPointHistoryChart breakPointForm = new BreakPointHistoryChart(this);
            breakPointForm.ShowDialog();
        }
    }
}
