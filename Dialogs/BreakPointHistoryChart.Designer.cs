namespace UART_Profiler.Dialogs
{
    partial class BreakPointHistoryChart
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
            Infragistics.Win.DataVisualization.NumericXAxis numericXAxis1 = new Infragistics.Win.DataVisualization.NumericXAxis();
            this.ultraDataChart1 = new Infragistics.Win.DataVisualization.UltraDataChart();
            this.ultraLegend1 = new Infragistics.Win.DataVisualization.UltraLegend();
            this.breakPointHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakPointHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraDataChart1
            // 
            this.ultraDataChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            numericXAxis1.Id = new System.Guid("1139299a-3020-4b3b-ba72-456add602c3b");
            numericXAxis1.Label = "Break Point Hit Time";
            numericXAxis1.LabelMargin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            numericXAxis1.Name = "Break Point Hit Time";
            numericXAxis1.TitleHorizontalAlignment = Infragistics.Portable.Components.UI.HorizontalAlignment.Center;
            this.ultraDataChart1.Axes.Add(numericXAxis1);
            this.ultraDataChart1.BackColor = System.Drawing.Color.White;
            this.ultraDataChart1.CrosshairPoint = new Infragistics.Win.DataVisualization.Point(double.NaN, double.NaN);
            this.ultraDataChart1.CrosshairVisibility = Infragistics.Portable.Components.UI.Visibility.Visible;
            this.ultraDataChart1.Location = new System.Drawing.Point(54, 28);
            this.ultraDataChart1.MarkerBrushes.Add(new Infragistics.Win.DataVisualization.SolidColorBrush(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))));
            this.ultraDataChart1.Name = "ultraDataChart1";
            this.ultraDataChart1.Size = new System.Drawing.Size(400, 300);
            this.ultraDataChart1.Subtitle = "";
            this.ultraDataChart1.TabIndex = 0;
            this.ultraDataChart1.Text = "ultraDataChart1";
            this.ultraDataChart1.Title = "Break Point History";
            // 
            // ultraLegend1
            // 
            this.ultraLegend1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLegend1.Location = new System.Drawing.Point(455, 28);
            this.ultraLegend1.Name = "ultraLegend1";
            this.ultraLegend1.Size = new System.Drawing.Size(91, 80);
            this.ultraLegend1.TabIndex = 1;
            // 
            // breakPointHistoryBindingSource
            // 
            this.breakPointHistoryBindingSource.DataSource = typeof(UART_Profiler.Model.BreakPointHistory);
            // 
            // BreakPointHistoryChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 357);
            this.Controls.Add(this.ultraLegend1);
            this.Controls.Add(this.ultraDataChart1);
            this.Name = "BreakPointHistoryChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BreakPointHistoryChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakPointHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.DataVisualization.UltraDataChart ultraDataChart1;
        private System.Windows.Forms.BindingSource breakPointHistoryBindingSource;
        private Infragistics.Win.DataVisualization.UltraLegend ultraLegend1;
    }
}