using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KTmetoda
{
    public partial class Form1 : Form
    {
        public Form1(List<int> a,List<int> utezi)
        {
            InitializeComponent();
            List<double> doubles = a.Select<int, double>(i => i).ToList();
            var m = doubles.ToArray();
            chart1.DataSource = a;
            // Create a series, and add it to the chart.
            Series series1 = new Series("Graf1");
            foreach(double aa in m)
            {
                series1.Points.Add(aa);
            }
            
            chart1.Series.Add(series1);

            //// Adjust the series data members.
            //series1.ArgumentDataMember = "name";
            //series1.ValueDataMembers.AddRange(new string[] { "age" });


            chart2.Series.Clear();
            string seriesname = "Graf2";
            Series series2 = new Series(seriesname);
            //chart2.Series.Add(seriesname);

            List<double> duplo = utezi.Select<int, double>(i => i).ToList();
            var kk = doubles.ToArray();

            series2.ChartType = SeriesChartType.Pie;

            foreach (double aa in kk)
            {
                series2.Points.Add(aa);
            }

            chart2.Series.Add(series2);
            //chart2.Series["Graf2"].ChartType = SeriesChartType.Pie;
        }
    }
}
