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
using UART_Profiler.Model;

namespace UART_Profiler.Dialogs
{
    public partial class HealthStatus : Form
    {
        Form _parentForm = null;
        UARTSerialConnectionParam uartSerialConnectionParam = null;
        public SerialPort uartSerialPortHandle;
        DataTable dt = new DataTable();
        DataTable chartDt = new DataTable();
        DataTable newDt;

        public delegate void InvokeDelegate(UARTHealthStatus _healthSatus);

        List<UARTHealthStatus> _historyHealthStatus = new List<UARTHealthStatus>();

        public HealthStatus()
        {
            InitializeComponent();
        }
        public HealthStatus(Form parentForm)
        {
            _parentForm = parentForm;
            uartSerialConnectionParam = ((UART_PROFILER)_parentForm).uartSerialConnectionParam;

            InitializeComponent();
            InitUltraChart();
            PrepareHealthStatus();
        }

        private void InitUltraChart()
        {
            dt.Columns.Add("RowIndex", typeof(long));
            dt.Columns.Add("DateTime", typeof(DateTime));
            dt.Columns.Add("Health", typeof(UInt32));

            
            ultraChart1.Axis.X.ScrollScale.Visible = true;
            ultraChart1.Axis.Y.ScrollScale.Visible = true;

            
            ultraGrid1.DataSource = dt;
            chartDt = dt.Copy();
            chartDt.Columns.Remove("RowIndex");
            ultraChart1.DataSource = chartDt;
            //uARTHealthStatusBindingSource.DataSource = dt;
            ultraChart1.Data.SwapRowsAndColumns = true;
        }

        public void PrepareHealthStatus()
        {
            UARTHealthStatus instance1 = new UARTHealthStatus { DeviceHealthData = 0xBACD };
            UARTHealthStatus instance2 = new UARTHealthStatus { DeviceHealthData = 0x00FF };
            dt.Rows.Add(instance1.RowIndex,instance1.ReceivedTime.ToString(), instance1.DeviceHealthData);
            dt.Rows.Add(instance2.RowIndex,instance2.ReceivedTime.ToString(), instance2.DeviceHealthData);

            chartDt.Rows.Add(instance1.ReceivedTime.ToString(), instance1.DeviceHealthData);
            chartDt.Rows.Add(instance2.ReceivedTime.ToString(), instance2.DeviceHealthData);
            //uARTHealthStatusBindingSource.Add(instance1);
            //uARTHealthStatusBindingSource.Add(instance2);
        }
        void CloneTable()
        {
            newDt = new DataTable();
            newDt.Columns.Add("RowIndex", typeof(long));
            newDt.Columns.Add("DateTime", typeof(DateTime));
            newDt.Columns.Add("Health", typeof(UInt32));

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            UARTHealthStatus instance1 = new UARTHealthStatus { DeviceHealthData = 0x7564 };

            if (dt.Rows.Count == 20)
            {
                //clone the table
                CloneTable();
                int skipfirstitem = 0;
                for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                {
                    DataRow dr = dt.Rows[rowIndex];
                    if (rowIndex != skipfirstitem)
                    {
                        
                        newDt.Rows.Add( dr.ItemArray);
                    }
                    else
                    {
                        _historyHealthStatus.Add(new UARTHealthStatus((long)dr.ItemArray[0], (DateTime)dr.ItemArray[1], (UInt32)dr.ItemArray[2]));
                    }
                }
                //remove last element
                //assign datatable as datasource to grid
                
                ultraGrid1.DataSource = newDt;                var chartDt =  newDt.Copy();
                chartDt.Columns.Remove("RowIndex");
                ultraChart1.DataSource = chartDt;

            }
            else
            {
                dt.Rows.Add(instance1.RowIndex,instance1.ReceivedTime.ToString(), instance1.DeviceHealthData);
                chartDt.Rows.Add(instance1.ReceivedTime.ToString(), instance1.DeviceHealthData);
            }
        }

        private void AddHealthData(UARTHealthStatus deviceHealthReceivedData)
        {
            if (dt.Rows.Count == 20)
            {
                //remove the first item in the list
                DataRow dr = dt.Rows[0];
                _historyHealthStatus.Add(new UARTHealthStatus((long)dr.ItemArray[0] , (DateTime)dr.ItemArray[1], (UInt32)dr.ItemArray[2]));
                dr.Delete();
            }
            dt.Rows.Add(deviceHealthReceivedData.RowIndex, deviceHealthReceivedData.ReceivedTime.ToString(), deviceHealthReceivedData.DeviceHealthData);
            chartDt.Rows.Add(deviceHealthReceivedData.ReceivedTime.ToString(), deviceHealthReceivedData.DeviceHealthData);
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

        void uartSerialPortHandle_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            byte[] dataRecevied = new byte[Constants.PerHealthDataReceviedByteLength];
            for (int i = 0; i < Constants.PerHealthDataReceviedByteLength; i++)
            {
                //read bytes and con
                dataRecevied[i] = (byte)sp.ReadByte();

            }
            UARTHealthStatus newInstance = new UARTHealthStatus(dataRecevied);

            ultraChart1.BeginInvoke(new InvokeDelegate(AddHealthData), new object[] { newInstance });

            MessageBox.Show("Data Received:" + "0x" + newInstance.DeviceHealthData.ToString("X2") );
        }
    }
}
