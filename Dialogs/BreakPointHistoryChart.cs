using Infragistics.Win.DataVisualization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_Profiler.Common;
using UART_Profiler.Model;

namespace UART_Profiler.Dialogs
{
    public partial class BreakPointHistoryChart : Form
    {
        //var data = new CategorySampleData();
        Dictionary<BreakPoint, List<BreakPointHistory>> brkPointHitCollection = new Dictionary<BreakPoint, List<BreakPointHistory>>();

        DynamicBreakPoint _parentForm;
        public BreakPointHistoryChart(DynamicBreakPoint parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            PrepareData();
        }
        private void PrepareData()
        {
            List<BreakPointHistory> brPoint1Collection1 = new List<BreakPointHistory>{ new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-55) ,  Value = 1000 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-40) ,  Value = 1150 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x1040" , BreakPointHitTime = DateTime.Today.AddMinutes(-35) ,  Value = 1500 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x1120" , BreakPointHitTime = DateTime.Today.AddMinutes(-25) ,  Value = 1240 , Variable = "MBMPartMaxPec" }
            };

            brkPointHitCollection.Add(BreakPoint.BreakPoint1, brPoint1Collection1);

            List<BreakPointHistory> brPoint1Collection2 = new List<BreakPointHistory>{ new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-55) ,  Value = 1000 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2101" , BreakPointHitTime = DateTime.Today.AddMinutes(-40) ,  Value = 2150 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2020" , BreakPointHitTime = DateTime.Today.AddMinutes(-35) ,  Value = 2500 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x3110" , BreakPointHitTime = DateTime.Today.AddMinutes(-25) ,  Value = 2240 , Variable = "MBMPartMaxPec" }
            };

            List<BreakPointHistory> brPoint1Collection3 = new List<BreakPointHistory>{ new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-55) ,  Value = 1000 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x1201" , BreakPointHitTime = DateTime.Today.AddMinutes(-40) ,  Value = 150 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x0020" , BreakPointHitTime = DateTime.Today.AddMinutes(-35) ,  Value = 500 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x0110" , BreakPointHitTime = DateTime.Today.AddMinutes(-25) ,  Value = 240 , Variable = "MBMPartMaxPec" }
            };

            List<BreakPointHistory> brPoint1Collection4 = new List<BreakPointHistory>{ new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-55) ,  Value = 1000 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x1101" , BreakPointHitTime = DateTime.Today.AddMinutes(-40) ,  Value = 2250 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2020" , BreakPointHitTime = DateTime.Today.AddMinutes(-35) ,  Value = 1500 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x3110" , BreakPointHitTime = DateTime.Today.AddMinutes(-25) ,  Value = 1440 , Variable = "MBMPartMaxPec" }
            };

            List<BreakPointHistory> brPoint1Collection5 = new List<BreakPointHistory>{ new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-55) ,  Value = 1000 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2101" , BreakPointHitTime = DateTime.Today.AddMinutes(-40) ,  Value = 2670 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2020" , BreakPointHitTime = DateTime.Today.AddMinutes(-35) ,  Value = 1600 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x3110" , BreakPointHitTime = DateTime.Today.AddMinutes(-25) ,  Value = 1340 , Variable = "MBMPartMaxPec" }
            };

            List<BreakPointHistory> brPoint1Collection6 = new List<BreakPointHistory>{ new BreakPointHistory{BreakPointAddress = "0x1020" , BreakPointHitTime = DateTime.Today.AddMinutes(-55) ,  Value = 1000 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2101" , BreakPointHitTime = DateTime.Today.AddMinutes(-40) ,  Value = 1250 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x2020" , BreakPointHitTime = DateTime.Today.AddMinutes(-35) ,  Value = 4300 , Variable = "MBMPartMaxPec" },
                new BreakPointHistory{BreakPointAddress = "0x3110" , BreakPointHitTime = DateTime.Today.AddMinutes(-25) ,  Value = 2341 , Variable = "MBMPartMaxPec" }
            };


            brkPointHitCollection.Add(BreakPoint.BreakPoint2, brPoint1Collection2);

            //CategorySampleData data = new EnergyProductionDataSample();

            var xAxis = new NumericXAxis
            {
                Label = "Break Point Hit Time",
                LabelLocation = AxisLabelsLocation.OutsideBottom,
                LabelsVisible = true,
                        
                //DateTimeMemberPath ="BreakPointHitTime",
                //DataSource = brPoint1Collection1
            };

            var yAxis = new NumericYAxis
            {
                Label = "Break Point Value",
                LabelLocation = AxisLabelsLocation.OutsideLeft,
                TickLength = 1,
                Stroke = new SolidColorBrush { Color = Color.Black },
                LabelsVisible = true
            };

            ScatterLineSeries series1 = new ScatterLineSeries();
            
            series1.XAxis = xAxis;
            series1.YAxis = yAxis;
            series1.MarkerType = MarkerType.Pyramid;
            series1.XMemberPath = "BreakPointHitTime";
            series1.YMemberPath = "Value";
            series1.DataSource = brPoint1Collection1;
            series1.Title = "BreakPoint_1_History";
            series1.Legend = ultraLegend1;

            var chart = ultraDataChart1;

            

            ScatterLineSeries series2 = new ScatterLineSeries();

            series2.XAxis = xAxis;
            series2.YAxis = yAxis;
            series2.MarkerType = MarkerType.Circle;
            series2.XMemberPath = "BreakPointHitTime";
            series2.YMemberPath = "Value";
            series2.DataSource = brPoint1Collection2;
            series2.Title = "BreakPoint_2_History";
            series2.Legend = ultraLegend1;
            
            ScatterLineSeries series3 = new ScatterLineSeries();

            series3.XAxis = xAxis;
            series3.YAxis = yAxis;
            series3.MarkerType = MarkerType.Diamond;
            series3.XMemberPath = "BreakPointHitTime";
            series3.YMemberPath = "Value";
            series3.DataSource = brPoint1Collection3;
            series3.Title = "BreakPoint_3_History";
            series3.Legend = ultraLegend1;
            
            ScatterLineSeries series4 = new ScatterLineSeries();

            series4.XAxis = xAxis;
            series4.YAxis = yAxis;
            series4.MarkerType = MarkerType.Hexagram;
            series4.XMemberPath = "BreakPointHitTime";
            series4.YMemberPath = "Value";
            series4.DataSource = brPoint1Collection4;
            series4.Title = "BreakPoint_4_History";
            series4.Legend = ultraLegend1;

            ScatterLineSeries series5 = new ScatterLineSeries();

            series5.XAxis = xAxis;
            series5.YAxis = yAxis;
            series5.MarkerType = MarkerType.Pentagon;
            series5.XMemberPath = "BreakPointHitTime";
            series5.YMemberPath = "Value";
            series5.DataSource = brPoint1Collection5;
            series5.Title = "BreakPoint_5_History";
            series5.Legend = ultraLegend1;
            
            
            ScatterLineSeries series6 = new ScatterLineSeries();

            series6.XAxis = xAxis;
            series6.YAxis = yAxis;
            series6.MarkerType = MarkerType.Tetragram;
            series6.XMemberPath = "BreakPointHitTime";
            series6.YMemberPath = "Value";
            series6.DataSource = brPoint1Collection6;
            series6.Title = "BreakPoint_6_History";
            series6.Legend = ultraLegend1;

            //LineSeries series2 = new LineSeries();
            //series2.XAxis = xAxis;
            //series2.YAxis = yAxis;
            //series2.ValueMemberPath = "Value";
            //series2.Title = "BreakPoint_2_History";
            //series2.DataSource = brPoint1Collection2;
            //series2.Legend = ultraLegend1;

            //LineSeries series3 = new LineSeries();
            //series3.XAxis = xAxis;
            //series3.YAxis = yAxis;
            //series3.ValueMemberPath = "Value";
            //series3.Title = "BreakPoint_3_History";
            //series3.DataSource = brPoint1Collection3;
            //series3.Legend = ultraLegend1;

            //LineSeries series4 = new LineSeries();
            //series4.XAxis = xAxis;
            //series4.YAxis = yAxis;
            //series4.ValueMemberPath = "Value";
            //series4.Title = "BreakPoint_4_History";
            //series4.DataSource = brPoint1Collection4;
            //series4.Legend = ultraLegend1;

            //LineSeries series5 = new LineSeries();
            //series5.XAxis = xAxis;
            //series5.YAxis = yAxis;
            //series5.ValueMemberPath = "Value";
            //series5.Title = "BreakPoint_5_History";
            //series5.DataSource = brPoint1Collection5;
            //series5.Legend = ultraLegend1;

            //LineSeries series6 = new LineSeries();
            //series6.XAxis = xAxis;
            //series6.YAxis = yAxis;
            //series6.ValueMemberPath = "Value";
            //series6.Title = "BreakPoint6_History";
            //series6.DataSource = brPoint1Collection6;
            //series6.Legend = ultraLegend1;


            chart.Axes.Add(xAxis);
            chart.Axes.Add(yAxis);
            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Series.Add(series3);
            chart.Series.Add(series4);
            chart.Series.Add(series5);
            chart.Series.Add(series6);
            
            
            xAxis.FormatLabel += Form1_FormatLabel;
            yAxis.FormatLabel += Form1_FormatLabel2;

        }

        private string Form1_FormatLabel(AxisLabelInfo info)
        {
            var val = info.Value;
            var f = new DateTime(Convert.ToInt64(val)).ToString("MM/dd/yyyy H:mm");
            return string.Format("{0:dd/h:mm tt }", f);

        }
        private string Form1_FormatLabel2(AxisLabelInfo info)
        {
            var decValue = info.Value;
            var hexValue = "0x" + int.Parse(decValue.ToString()).ToString("X");
            return hexValue;


        }

    }
}
