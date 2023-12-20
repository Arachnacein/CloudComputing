using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudComputing.Models;
using CloudComputing.Services;
using OxyPlot;
using OxyPlot.Series;

namespace CloudComputing
{
    public partial class Gui2 : Form
    {
        private List<Models.Point> points;
        private List<Models.Poi> pois;
        private List<List<int>> neighborhood;
        private GAService GAService;

        public Gui2(List<Models.Point> points, List<Models.Poi> pois, List<List<int>> neighborhood)
        {
            InitializeComponent();

            // example charts
            var myModel = new PlotModel { Title = "Example 1" };
            var myModel2 = new PlotModel { Title = "Example 2" };
            myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            myModel2.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            plotView1.Model = myModel;
            plotView2.Model = myModel2;
            //

            this.points = points;
            this.pois = pois;
            this.neighborhood = neighborhood;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GAService = new GAService(
                points, 
                pois, 
                neighborhood, 
                Convert.ToDouble(textBox5.Text.Replace(".", ",")),
                checkBox1.Checked,
                checkBox2.Checked,
                checkBox3.Checked
            );
            GAService.calculateFunction1();
            MessageBox.Show("All calculations have been completed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
