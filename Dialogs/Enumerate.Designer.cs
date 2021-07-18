namespace UART_Profiler
{
    partial class Enumerate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCOMPort = new System.Windows.Forms.TextBox();
            this.txtDumpFile = new System.Windows.Forms.TextBox();
            this.txtMapFile = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnBrowseDumpFile = new System.Windows.Forms.Button();
            this.btnBrowseMapFile = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblTestConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseStructFile = new System.Windows.Forms.Button();
            this.txtStructFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rButtonHealthMonitor = new System.Windows.Forms.RadioButton();
            this.rbuttonDynamicBreakpoint = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DUMP File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAP File";
            // 
            // txtCOMPort
            // 
            this.txtCOMPort.Location = new System.Drawing.Point(97, 24);
            this.txtCOMPort.Name = "txtCOMPort";
            this.txtCOMPort.Size = new System.Drawing.Size(67, 22);
            this.txtCOMPort.TabIndex = 3;
            this.txtCOMPort.Text = "COM3";
            this.txtCOMPort.TextChanged += new System.EventHandler(this.txtCOMPort_TextChanged);
            // 
            // txtDumpFile
            // 
            this.txtDumpFile.Location = new System.Drawing.Point(103, 28);
            this.txtDumpFile.Name = "txtDumpFile";
            this.txtDumpFile.ReadOnly = true;
            this.txtDumpFile.Size = new System.Drawing.Size(630, 22);
            this.txtDumpFile.TabIndex = 4;
            this.txtDumpFile.Text = "C:\\Users\\17915\\Documents\\Visual Studio 2012\\Projects\\UART_Profiler\\Docs\\RAM\\RAM.d" +
    "mp";
            this.txtDumpFile.TextChanged += new System.EventHandler(this.txtDumpFile_TextChanged);
            // 
            // txtMapFile
            // 
            this.txtMapFile.Location = new System.Drawing.Point(107, 164);
            this.txtMapFile.Name = "txtMapFile";
            this.txtMapFile.ReadOnly = true;
            this.txtMapFile.Size = new System.Drawing.Size(630, 22);
            this.txtMapFile.TabIndex = 5;
            this.txtMapFile.Text = "C:\\Users\\17915\\Documents\\Visual Studio 2012\\Projects\\UART_Profiler\\Docs\\RAM\\RAM.m" +
    "ap";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(496, 274);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(135, 37);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnBrowseDumpFile
            // 
            this.btnBrowseDumpFile.Location = new System.Drawing.Point(759, 24);
            this.btnBrowseDumpFile.Name = "btnBrowseDumpFile";
            this.btnBrowseDumpFile.Size = new System.Drawing.Size(159, 23);
            this.btnBrowseDumpFile.TabIndex = 7;
            this.btnBrowseDumpFile.Text = "Browse..";
            this.btnBrowseDumpFile.UseVisualStyleBackColor = true;
            this.btnBrowseDumpFile.Click += new System.EventHandler(this.btnBrowseDumpFile_Click);
            // 
            // btnBrowseMapFile
            // 
            this.btnBrowseMapFile.Location = new System.Drawing.Point(759, 68);
            this.btnBrowseMapFile.Name = "btnBrowseMapFile";
            this.btnBrowseMapFile.Size = new System.Drawing.Size(159, 23);
            this.btnBrowseMapFile.TabIndex = 8;
            this.btnBrowseMapFile.Text = "Browse..";
            this.btnBrowseMapFile.UseVisualStyleBackColor = true;
            this.btnBrowseMapFile.Click += new System.EventHandler(this.btnBrowseMapFile_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(764, 274);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(165, 35);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblTestConnectionStatus
            // 
            this.lblTestConnectionStatus.AutoSize = true;
            this.lblTestConnectionStatus.Location = new System.Drawing.Point(650, 287);
            this.lblTestConnectionStatus.Name = "lblTestConnectionStatus";
            this.lblTestConnectionStatus.Size = new System.Drawing.Size(48, 17);
            this.lblTestConnectionStatus.TabIndex = 11;
            this.lblTestConnectionStatus.Text = "Status";
            this.lblTestConnectionStatus.Click += new System.EventHandler(this.lblTestConnectionStatus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDataBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 72);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UART";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "460800"});
            this.cbxBaudRate.Location = new System.Drawing.Point(273, 24);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbxBaudRate.TabIndex = 21;
            this.cbxBaudRate.Text = "9600";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbxStopBits.Location = new System.Drawing.Point(840, 24);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(78, 24);
            this.cbxStopBits.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "STOP BITS:";
            // 
            // cbxParity
            // 
            this.cbxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbxParity.Location = new System.Drawing.Point(480, 23);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(78, 24);
            this.cbxParity.TabIndex = 18;
            this.cbxParity.SelectedIndexChanged += new System.EventHandler(this.cbxParity_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "DATA BITS:";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(666, 23);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(67, 22);
            this.txtDataBits.TabIndex = 17;
            this.txtDataBits.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "PARITY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "BAUD RATE:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnBrowseStructFile);
            this.groupBox2.Controls.Add(this.txtStructFile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDumpFile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnBrowseMapFile);
            this.groupBox2.Controls.Add(this.btnBrowseDumpFile);
            this.groupBox2.Location = new System.Drawing.Point(4, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 166);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FW Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBrowseStructFile
            // 
            this.btnBrowseStructFile.Location = new System.Drawing.Point(760, 115);
            this.btnBrowseStructFile.Name = "btnBrowseStructFile";
            this.btnBrowseStructFile.Size = new System.Drawing.Size(159, 23);
            this.btnBrowseStructFile.TabIndex = 16;
            this.btnBrowseStructFile.Text = "Browse..";
            this.btnBrowseStructFile.UseVisualStyleBackColor = true;
            this.btnBrowseStructFile.Click += new System.EventHandler(this.btnBrowseStructFile_Click);
            // 
            // txtStructFile
            // 
            this.txtStructFile.Location = new System.Drawing.Point(103, 120);
            this.txtStructFile.Name = "txtStructFile";
            this.txtStructFile.ReadOnly = true;
            this.txtStructFile.Size = new System.Drawing.Size(630, 22);
            this.txtStructFile.TabIndex = 15;
            this.txtStructFile.Text = "C:\\Users\\17915\\Documents\\Visual Studio 2012\\Projects\\UART_Profiler\\Docs\\RAM\\XML_E" +
    "xport_RAM.raw";
            this.txtStructFile.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "STRUCT File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\17915\\Documents\\Visual Studio 2012\\Projects\\UART_Profiler\\UART_Profiler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rButtonHealthMonitor);
            this.groupBox3.Controls.Add(this.rbuttonDynamicBreakpoint);
            this.groupBox3.Location = new System.Drawing.Point(13, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 43);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Load View";
            this.groupBox3.Visible = false;
            // 
            // rButtonHealthMonitor
            // 
            this.rButtonHealthMonitor.AutoSize = true;
            this.rButtonHealthMonitor.Location = new System.Drawing.Point(258, 16);
            this.rButtonHealthMonitor.Name = "rButtonHealthMonitor";
            this.rButtonHealthMonitor.Size = new System.Drawing.Size(121, 21);
            this.rButtonHealthMonitor.TabIndex = 1;
            this.rButtonHealthMonitor.TabStop = true;
            this.rButtonHealthMonitor.Text = "Health Monitor";
            this.rButtonHealthMonitor.UseVisualStyleBackColor = true;
            // 
            // rbuttonDynamicBreakpoint
            // 
            this.rbuttonDynamicBreakpoint.AutoSize = true;
            this.rbuttonDynamicBreakpoint.Checked = true;
            this.rbuttonDynamicBreakpoint.Location = new System.Drawing.Point(88, 17);
            this.rbuttonDynamicBreakpoint.Name = "rbuttonDynamicBreakpoint";
            this.rbuttonDynamicBreakpoint.Size = new System.Drawing.Size(155, 21);
            this.rbuttonDynamicBreakpoint.TabIndex = 0;
            this.rbuttonDynamicBreakpoint.TabStop = true;
            this.rbuttonDynamicBreakpoint.Text = "Dynamic Breakpoint";
            this.rbuttonDynamicBreakpoint.UseVisualStyleBackColor = true;
            // 
            // Enumerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 336);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtMapFile);
            this.Controls.Add(this.lblTestConnectionStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enumerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enumerate";
            this.Load += new System.EventHandler(this.Enumerate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCOMPort;
        private System.Windows.Forms.TextBox txtDumpFile;
        private System.Windows.Forms.TextBox txtMapFile;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnBrowseDumpFile;
        private System.Windows.Forms.Button btnBrowseMapFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblTestConnectionStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseStructFile;
        private System.Windows.Forms.TextBox txtStructFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rButtonHealthMonitor;
        private System.Windows.Forms.RadioButton rbuttonDynamicBreakpoint;
        private System.Windows.Forms.ComboBox cbxBaudRate;
    }
}