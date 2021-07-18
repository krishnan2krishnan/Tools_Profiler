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

namespace UART_Profiler
{
    public partial class Enumerate : Form
    {
        // Create the serial port with basic settings 
        public UARTSerialConnectionParam uartConnectionParam;
        public FwSettings fwSettings;
        public Form _parentForm;
        public Enumerate()
        {
            InitializeComponent();
        }
        public Enumerate(Form parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }

        private void btnBrowseDumpFile_Click(object sender, EventArgs e)
        {
            //open file browser..   
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //populate dump file text box
                txtDumpFile.Text = openFileDialog1.FileName;
            }

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            lblTestConnectionStatus.Text = "STATUS";
            try
            {
                uartConnectionParam = new UARTSerialConnectionParam(txtCOMPort.Text,
           int.Parse(cbxBaudRate.Text), GetParity(), int.Parse(txtDataBits.Text), GetStopBits());
                
                var uartPort = new SerialPort(uartConnectionParam.portName,
          uartConnectionParam.baudRate, uartConnectionParam.parity, uartConnectionParam.dataBits, uartConnectionParam.stopBits);
 
                uartPort.Open();
                lblTestConnectionStatus.Text = "SUCCESS";
                lblTestConnectionStatus.ForeColor = Color.Green;
                btnConnect.Enabled = true;
                uartPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblTestConnectionStatus.Text = "FAIL";
                lblTestConnectionStatus.ForeColor = Color.Red;
                btnConnect.Enabled = true;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Enumerate_Load(object sender, EventArgs e)
        {

        }

        private void lblTestConnectionStatus_Click(object sender, EventArgs e)
        {

        }
        /*None
        Odd
        Even
        Mark
        Space
         * */
        private Parity GetParity()
        {
            Parity ret = Parity.None;
            switch (cbxParity.Text)
            {
                case "Odd":
                    ret = Parity.Odd;
                    break;
                case "Even":
                    ret = Parity.Even;
                    break;
                case "Mark":
                    ret = Parity.Mark;
                    break;
                case "Space":
                    ret = Parity.Space;
                    break;
            }
            return ret;
        }

        private StopBits GetStopBits()
        {
            StopBits ret = StopBits.None;
            switch (cbxStopBits.Text)
            {
                case "One":
                    ret = StopBits.One;
                    break;
                case "Two":
                    ret = StopBits.Two;
                    break;
                case "OnePointFive":
                    ret = StopBits.OnePointFive;
                    break;
            }
            return ret;
        }
        void ParseFwSettings()
        {
            fwSettings = new FwSettings();
            fwSettings.DumpFilePath = txtDumpFile.Text;
            fwSettings.MapFilePath = txtMapFile.Text;
            fwSettings.XmlStructPath = txtStructFile.Text;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //pack parameters for UART
            uartConnectionParam = new UARTSerialConnectionParam(txtCOMPort.Text,
           int.Parse(cbxBaudRate.Text), GetParity(), int.Parse(txtDataBits.Text), GetStopBits());
                
            //Create a serial port connection
            Constants.SCREEN landingscreen = Constants.SCREEN.DYNAMIC_BREAKPOINT;
            //navigate to respective tab
            if (rbuttonDynamicBreakpoint.Checked)
            {
                landingscreen = Constants.SCREEN.DYNAMIC_BREAKPOINT;
            }
            else if(rButtonHealthMonitor.Checked)
            {
                landingscreen = Constants.SCREEN.HEALTH_STATUS;
            }

            ParseFwSettings();
            UART_PROFILER parent = (UART_PROFILER)this._parentForm;
            this.Visible = false;
            parent.loadForm(landingscreen, uartConnectionParam, fwSettings);
            this.Close();
        }

        private void txtDumpFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseMapFile_Click(object sender, EventArgs e)
        {
            //open file browser..   
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //populate dump file text box
                txtMapFile.Text = openFileDialog1.FileName;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseStructFile_Click(object sender, EventArgs e)
        {
            //open file browser..   
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //populate dump file text box
                txtStructFile.Text = openFileDialog1.FileName;
            }
        }

        private void txtCOMPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxParity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
