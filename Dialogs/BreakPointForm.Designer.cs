namespace UART_Profiler.Dialogs
{
    partial class BreakPointForm
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DumpFileData", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LineNumber", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Content");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FuncName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Address");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Size");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MapFileData", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LineNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Content");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Section");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Symbol");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Address");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Module");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Size");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMapAndPrint = new System.Windows.Forms.RadioButton();
            this.rbMapPrint = new System.Windows.Forms.RadioButton();
            this.rbMapHalt = new System.Windows.Forms.RadioButton();
            this.txtDumpFileAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mapFilePanel = new System.Windows.Forms.Panel();
            this.dumpFileGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDumpAndHalt = new System.Windows.Forms.RadioButton();
            this.rbDumpPrint = new System.Windows.Forms.RadioButton();
            this.rbDumpHalt = new System.Windows.Forms.RadioButton();
            this.txtMapFileAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dumpFilePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mapFileGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.rtextboxDumpFile = new System.Windows.Forms.RichTextBox();
            this.dumpFileDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapFileDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mapFilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dumpFileGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.dumpFilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapFileGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumpFileDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapFileDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "DUMP FILE DATA";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtDumpFileAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.mapFilePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.txtMapFileAddress);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.dumpFilePanel);
            this.splitContainer1.Size = new System.Drawing.Size(1238, 972);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 910);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMapAndPrint);
            this.groupBox1.Controls.Add(this.rbMapPrint);
            this.groupBox1.Controls.Add(this.rbMapHalt);
            this.groupBox1.Location = new System.Drawing.Point(31, 774);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action:";
            // 
            // rbMapAndPrint
            // 
            this.rbMapAndPrint.AutoSize = true;
            this.rbMapAndPrint.Location = new System.Drawing.Point(36, 90);
            this.rbMapAndPrint.Name = "rbMapAndPrint";
            this.rbMapAndPrint.Size = new System.Drawing.Size(114, 21);
            this.rbMapAndPrint.TabIndex = 2;
            this.rbMapAndPrint.Text = "PRINT & HALT";
            this.rbMapAndPrint.UseVisualStyleBackColor = true;
            // 
            // rbMapPrint
            // 
            this.rbMapPrint.AutoSize = true;
            this.rbMapPrint.Location = new System.Drawing.Point(36, 54);
            this.rbMapPrint.Name = "rbMapPrint";
            this.rbMapPrint.Size = new System.Drawing.Size(284, 21);
            this.rbMapPrint.TabIndex = 1;
            this.rbMapPrint.Text = "PRINT VALUE AT SPECIFIED ADDRESS";
            this.rbMapPrint.UseVisualStyleBackColor = true;
            // 
            // rbMapHalt
            // 
            this.rbMapHalt.AutoSize = true;
            this.rbMapHalt.Checked = true;
            this.rbMapHalt.Location = new System.Drawing.Point(36, 22);
            this.rbMapHalt.Name = "rbMapHalt";
            this.rbMapHalt.Size = new System.Drawing.Size(156, 21);
            this.rbMapHalt.TabIndex = 0;
            this.rbMapHalt.TabStop = true;
            this.rbMapHalt.Text = "HALT PROCESSOR";
            this.rbMapHalt.UseVisualStyleBackColor = true;
            // 
            // txtDumpFileAddress
            // 
            this.txtDumpFileAddress.Location = new System.Drawing.Point(140, 714);
            this.txtDumpFileAddress.Name = "txtDumpFileAddress";
            this.txtDumpFileAddress.ReadOnly = true;
            this.txtDumpFileAddress.Size = new System.Drawing.Size(213, 22);
            this.txtDumpFileAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dump Address:";
            // 
            // mapFilePanel
            // 
            this.mapFilePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mapFilePanel.Controls.Add(this.dumpFileGrid);
            this.mapFilePanel.Controls.Add(this.label1);
            this.mapFilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapFilePanel.Location = new System.Drawing.Point(0, 0);
            this.mapFilePanel.Name = "mapFilePanel";
            this.mapFilePanel.Size = new System.Drawing.Size(411, 686);
            this.mapFilePanel.TabIndex = 0;
            // 
            // dumpFileGrid
            // 
            this.dumpFileGrid.DataSource = this.dumpFileDataBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.dumpFileGrid.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.Editor = null;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.Editor = null;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.Header.Editor = null;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.Editor = null;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn5.Header.Editor = null;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            this.dumpFileGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.dumpFileGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.dumpFileGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.dumpFileGrid.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dumpFileGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.dumpFileGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dumpFileGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.dumpFileGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.dumpFileGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dumpFileGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dumpFileGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.dumpFileGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.dumpFileGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.dumpFileGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.dumpFileGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.dumpFileGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.dumpFileGrid.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.dumpFileGrid.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.dumpFileGrid.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.dumpFileGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.dumpFileGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.dumpFileGrid.DisplayLayout.Override.RowAppearance = appearance11;
            this.dumpFileGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dumpFileGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.dumpFileGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.dumpFileGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.dumpFileGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.dumpFileGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dumpFileGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dumpFileGrid.Location = new System.Drawing.Point(0, 41);
            this.dumpFileGrid.Name = "dumpFileGrid";
            this.dumpFileGrid.Size = new System.Drawing.Size(411, 645);
            this.dumpFileGrid.TabIndex = 2;
            this.dumpFileGrid.Text = "ultraGrid1";
            this.dumpFileGrid.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.ultraGrid1_DoubleClickRow);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 901);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDumpAndHalt);
            this.groupBox2.Controls.Add(this.rbDumpPrint);
            this.groupBox2.Controls.Add(this.rbDumpHalt);
            this.groupBox2.Location = new System.Drawing.Point(18, 774);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action:";
            // 
            // rbDumpAndHalt
            // 
            this.rbDumpAndHalt.AutoSize = true;
            this.rbDumpAndHalt.Location = new System.Drawing.Point(36, 90);
            this.rbDumpAndHalt.Name = "rbDumpAndHalt";
            this.rbDumpAndHalt.Size = new System.Drawing.Size(114, 21);
            this.rbDumpAndHalt.TabIndex = 2;
            this.rbDumpAndHalt.Text = "PRINT & HALT";
            this.rbDumpAndHalt.UseVisualStyleBackColor = true;
            // 
            // rbDumpPrint
            // 
            this.rbDumpPrint.AutoSize = true;
            this.rbDumpPrint.Location = new System.Drawing.Point(36, 54);
            this.rbDumpPrint.Name = "rbDumpPrint";
            this.rbDumpPrint.Size = new System.Drawing.Size(284, 21);
            this.rbDumpPrint.TabIndex = 1;
            this.rbDumpPrint.Text = "PRINT VALUE AT SPECIFIED ADDRESS";
            this.rbDumpPrint.UseVisualStyleBackColor = true;
            // 
            // rbDumpHalt
            // 
            this.rbDumpHalt.AutoSize = true;
            this.rbDumpHalt.Checked = true;
            this.rbDumpHalt.Location = new System.Drawing.Point(36, 22);
            this.rbDumpHalt.Name = "rbDumpHalt";
            this.rbDumpHalt.Size = new System.Drawing.Size(156, 21);
            this.rbDumpHalt.TabIndex = 0;
            this.rbDumpHalt.TabStop = true;
            this.rbDumpHalt.Text = "HALT PROCESSOR";
            this.rbDumpHalt.UseVisualStyleBackColor = true;
            // 
            // txtMapFileAddress
            // 
            this.txtMapFileAddress.Location = new System.Drawing.Point(149, 716);
            this.txtMapFileAddress.Name = "txtMapFileAddress";
            this.txtMapFileAddress.ReadOnly = true;
            this.txtMapFileAddress.Size = new System.Drawing.Size(213, 22);
            this.txtMapFileAddress.TabIndex = 3;
            this.txtMapFileAddress.TextChanged += new System.EventHandler(this.txtDumpFileAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 719);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Map Address:";
            // 
            // dumpFilePanel
            // 
            this.dumpFilePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.dumpFilePanel.Controls.Add(this.label2);
            this.dumpFilePanel.Controls.Add(this.mapFileGrid);
            this.dumpFilePanel.Controls.Add(this.rtextboxDumpFile);
            this.dumpFilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dumpFilePanel.Location = new System.Drawing.Point(0, 0);
            this.dumpFilePanel.Name = "dumpFilePanel";
            this.dumpFilePanel.Size = new System.Drawing.Size(823, 686);
            this.dumpFilePanel.TabIndex = 0;
            this.dumpFilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dumpFilePanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "MAP FILE DATA";
            // 
            // mapFileGrid
            // 
            this.mapFileGrid.DataSource = this.mapFileDataBindingSource;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.mapFileGrid.DisplayLayout.Appearance = appearance13;
            ultraGridColumn6.Header.Editor = null;
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn7.Header.Editor = null;
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridColumn8.Header.Editor = null;
            ultraGridColumn8.Header.VisiblePosition = 2;
            ultraGridColumn9.Header.Editor = null;
            ultraGridColumn9.Header.VisiblePosition = 3;
            ultraGridColumn10.Header.Editor = null;
            ultraGridColumn10.Header.VisiblePosition = 4;
            ultraGridColumn11.Header.Editor = null;
            ultraGridColumn11.Header.VisiblePosition = 5;
            ultraGridColumn12.Header.Editor = null;
            ultraGridColumn12.Header.VisiblePosition = 6;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            this.mapFileGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.mapFileGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.mapFileGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.mapFileGrid.DisplayLayout.GroupByBox.Appearance = appearance14;
            appearance15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mapFileGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance15;
            this.mapFileGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.Control;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mapFileGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance16;
            this.mapFileGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.mapFileGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance17.BackColor = System.Drawing.SystemColors.Window;
            appearance17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mapFileGrid.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Highlight;
            appearance18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mapFileGrid.DisplayLayout.Override.ActiveRowAppearance = appearance18;
            this.mapFileGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.mapFileGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance19.BackColor = System.Drawing.SystemColors.Window;
            this.mapFileGrid.DisplayLayout.Override.CardAreaAppearance = appearance19;
            appearance20.BorderColor = System.Drawing.Color.Silver;
            appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.mapFileGrid.DisplayLayout.Override.CellAppearance = appearance20;
            this.mapFileGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mapFileGrid.DisplayLayout.Override.CellPadding = 0;
            appearance21.BackColor = System.Drawing.SystemColors.Control;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance21.BorderColor = System.Drawing.SystemColors.Window;
            this.mapFileGrid.DisplayLayout.Override.GroupByRowAppearance = appearance21;
            appearance22.TextHAlignAsString = "Left";
            this.mapFileGrid.DisplayLayout.Override.HeaderAppearance = appearance22;
            this.mapFileGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.mapFileGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            appearance23.BorderColor = System.Drawing.Color.Silver;
            this.mapFileGrid.DisplayLayout.Override.RowAppearance = appearance23;
            this.mapFileGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mapFileGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance24;
            this.mapFileGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.mapFileGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.mapFileGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.mapFileGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mapFileGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapFileGrid.Location = new System.Drawing.Point(0, 41);
            this.mapFileGrid.Name = "mapFileGrid";
            this.mapFileGrid.Size = new System.Drawing.Size(823, 645);
            this.mapFileGrid.TabIndex = 4;
            this.mapFileGrid.Text = "ultraGrid2";
            this.mapFileGrid.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.mapFileGrid_DoubleClickRow);
            // 
            // rtextboxDumpFile
            // 
            this.rtextboxDumpFile.BackColor = System.Drawing.Color.Linen;
            this.rtextboxDumpFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtextboxDumpFile.Location = new System.Drawing.Point(0, 0);
            this.rtextboxDumpFile.Name = "rtextboxDumpFile";
            this.rtextboxDumpFile.Size = new System.Drawing.Size(823, 686);
            this.rtextboxDumpFile.TabIndex = 3;
            this.rtextboxDumpFile.Text = "";
            // 
            // dumpFileDataBindingSource
            // 
            this.dumpFileDataBindingSource.DataSource = typeof(UART_Profiler.Model.DumpFileData);
            // 
            // mapFileDataBindingSource
            // 
            this.mapFileDataBindingSource.DataSource = typeof(UART_Profiler.Model.MapFileData);
            // 
            // BreakPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 972);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BreakPointForm";
            this.Text = "BreakPointForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mapFilePanel.ResumeLayout(false);
            this.mapFilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dumpFileGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dumpFilePanel.ResumeLayout(false);
            this.dumpFilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapFileGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumpFileDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapFileDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel mapFilePanel;
        private System.Windows.Forms.Panel dumpFilePanel;
        private System.Windows.Forms.RichTextBox rtextboxDumpFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDumpFileAddress;
        private System.Windows.Forms.TextBox txtMapFileAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMapAndPrint;
        private System.Windows.Forms.RadioButton rbMapPrint;
        private System.Windows.Forms.RadioButton rbMapHalt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDumpAndHalt;
        private System.Windows.Forms.RadioButton rbDumpPrint;
        private System.Windows.Forms.RadioButton rbDumpHalt;
        private Infragistics.Win.UltraWinGrid.UltraGrid dumpFileGrid;
        private System.Windows.Forms.BindingSource dumpFileDataBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Infragistics.Win.UltraWinGrid.UltraGrid mapFileGrid;
        private System.Windows.Forms.BindingSource mapFileDataBindingSource;
        private System.Windows.Forms.Label label2;
    }
}