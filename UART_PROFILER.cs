using Infragistics.UltraChart.Resources.Appearance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_Profiler.Dialogs;
using UART_Profiler.Model;


namespace UART_Profiler
{

    public partial class UART_PROFILER : Form
    {
        public delegate void Navigate(Constants.SCREEN landingscreen, UARTSerialConnectionParam connection, FwSettings settings);
        public Navigate loadForm = new Navigate(LoadProfiler);
        Enumerate _enumerate = null;
        public FwSettings _fwSettings = null;
        public DynamicBreakPoint _dynamicBreakPoint = null;
        public HealthStatus _healthStatus = null;
        
        public UARTSerialConnectionParam uartSerialConnectionParam;
        public SerialPort uartSerialPortHandle;

        static UART_PROFILER singleInstance;


        private UART_PROFILER()
        {
            InitializeComponent();
            _healthStatus = new HealthStatus(this);
            _dynamicBreakPoint = new DynamicBreakPoint(this);
            _enumerate = new Enumerate(this);
            
            //this.WindowState = FormWindowState.Maximized;
            this._dynamicBreakPoint.MdiParent = this;
            this._dynamicBreakPoint.Dock = DockStyle.Fill;
            _healthStatus.MdiParent = this;
            _enumerate.MdiParent = this;
        }

        public static UART_PROFILER CreateInstance()
        {
            if (singleInstance == null)
                singleInstance = new UART_PROFILER();
            
            return singleInstance;
        }

        private void enumerateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //show enumerate window as a pop up
            if (_enumerate != null)
                _enumerate.Dispose();

            //enumerate.MdiParent = this;
            _enumerate = new Enumerate(this);

            _enumerate.ShowDialog();

        }
        public static void LoadProfiler(Constants.SCREEN landingscreen, UARTSerialConnectionParam connection, FwSettings settings)
        {
            singleInstance._fwSettings = settings;
            singleInstance.uartSerialConnectionParam = connection;

            if (landingscreen == Constants.SCREEN.HEALTH_STATUS)
            {
                singleInstance._healthStatus.Show();
            }
            else
            {
                singleInstance._dynamicBreakPoint.Show();

            }
            
            //singleInstance.EstablishUARTConnection();

        }
        //public void EstablishUARTConnection()
        //{
        //    uartSerialPortHandle = new SerialPort(uartSerialConnectionParam.portName,
        //  uartSerialConnectionParam.baudRate, uartSerialConnectionParam.parity, uartSerialConnectionParam.dataBits, uartSerialConnectionParam.stopBits);

        //    //subscribe to data receive
        //    uartSerialPortHandle.Handshake = Handshake.None;
        //    uartSerialPortHandle.DtrEnable = true;    // Data-terminal-ready
        //    uartSerialPortHandle.RtsEnable = true;    // Request-to-send

        //    uartSerialPortHandle.DataReceived += new SerialDataReceivedEventHandler(uartSerialPortHandle_DataReceived);
        //    uartSerialPortHandle.Open();

        //}

        //void uartSerialPortHandle_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    SerialPort sp = (SerialPort)sender;
        //    string indata = sp.ReadExisting();

        //    MessageBox.Show("Data Received:" + indata);
        //}

        private void UART_PROFILER_Load(object sender, EventArgs e)
        {
            _enumerate.Show();
        }
    }
}
