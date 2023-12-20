using CloudComputing.Models;
using CloudComputing.Resources;
using CloudComputing.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CloudComputing
{
    public partial class Form1 : Form
    {
        private List<Models.Point> points;
        private List<Models.Poi> pois;
        private List<List<int>> neighborhood;
        private readonly IFilesReaderService _readerService;

        public Form1(IFilesReaderService filesReader)
        {
            InitializeComponent();
            _readerService = filesReader;

            Start();
        }

        private void Start()
        {
            //List<Models.Point> points = _readerService.ReadData("dane1.txt");
            //dataGridView1.DataSource = points;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
                textBox2.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                textBox2.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int gridSizeX = 0;
            int gridSizeY = 0;
            int poiID = 0;
            pois = new List<Models.Poi>();

            if (radioButton1.Checked)
            {
                gridSizeX = 6;
                gridSizeY = 6;
            }
            else if (radioButton2.Checked)
            {
                gridSizeX = 11;
                gridSizeY = 11;
            }
            else
            {
                gridSizeX = 21;
                gridSizeY = 21;
            }

            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            int cellSizeX = pictureBoxWidth / gridSizeX;
            int cellSizeY = pictureBoxHeight / gridSizeY;

            Brush pointBrush = Brushes.Gray;

            for (int x = 0; x < gridSizeX; x++)
            {
                for (int y = 0; y < gridSizeY; y++)
                {
                    int centerX = x * cellSizeX + cellSizeX / 2;
                    int centerY = y * cellSizeY + cellSizeY / 2;

                    e.Graphics.FillEllipse(pointBrush, centerX - 2, centerY - 2, 6, 6);
                    pois.Add(new Poi(poiID, (centerX - 2)/7.5, (centerY - 2)/7.5));
                    poiID++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points = _readerService.ReadData("DATA/WSN-5d.txt");


            using (Graphics g = pictureBox1.CreateGraphics())
            {
                Brush pointBrush = Brushes.Red;

                foreach (var point in points)
                {
                    // mno¿ymy przez 7.5 poniewa¿ punkty s¹ dostosowane do siatki 100x100m, a my mamy pole do rysowania 750x750
                    // wartoœci z pliku trzeba przeskalowaæ
                    g.FillEllipse(pointBrush, (int)(point.X * 7.5) - 4, (int)(point.Y * 7.5) - 4, 2 * 4, 2 * 4);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points = _readerService.ReadSensorStates(textBox1.Text, "INIT-RESULTS/state WSN-5.txt");
            MessageBox.Show("Data was successfully read from the file.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                if (points != null)
                {
                    foreach (var point in points)
                    {
                        Brush fillBrush = new SolidBrush(Color.FromArgb(128, Color.Yellow)); // Pó³przezroczysty ¿ó³ty
                        Pen borderPen = new Pen(Color.Black, 1);

                        if (checkBox5.Checked)
                        {
                            Random random = new Random();

                            double probability = Double.Parse(textBox2.Text.Replace('.', ','));
                            double randomValue = random.NextDouble();
                            point.Radius = Int32.Parse(textBox1.Text);

                            if (randomValue < probability)
                            {
                                point.IsActive = true;
                            }
                            else
                            {
                                point.IsActive = false;
                            }
                        }

                        if (point.IsActive)
                        {
                            g.FillEllipse(fillBrush, (int)(point.X * 7.5) - (int)(point.Radius * 7.5),
                                (int)(point.Y * 7.5) - (int)(point.Radius * 7.5), 2 * (int)(point.Radius * 7.5),
                                2 * (int)(point.Radius * 7.5));
                        }

                        g.DrawEllipse(borderPen, (int)(point.X * 7.5) - (int)(point.Radius * 7.5),
                            (int)(point.Y * 7.5) - (int)(point.Radius * 7.5), 2 * (int)(point.Radius * 7.5),
                            2 * (int)(point.Radius * 7.5));
                    }
                }
                else
                {
                    MessageBox.Show("The coordinates of the points were not read.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var sortedPoints = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
                using (StreamWriter writer = new StreamWriter(Consts.FilePath + "INIT-RESULTS/sensorsID WSN-" + points.Count + ".txt"))
                {
                    writer.WriteLine($"#id X Y");
                    int i = 1;
                    foreach (var point in sortedPoints)
                    {
                        point.Id = i;
                        writer.WriteLine($"{i} {point.X.ToString("F2").Replace(",",".")} {point.Y.ToString("F2").Replace(",", ".")}");
                        i++;
                    }
                }
                MessageBox.Show("ID numbers have been assigned to sensors", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("The coordinates of the points were not read.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sortedPoints = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
            var numPoi = "";
            var activeSensors = 0;
            neighborhood = new List<List<int>>();

            if (radioButton1.Checked)
            {
                numPoi = "36";
            }
            else if (radioButton2.Checked)
            {
                numPoi = "121";
            }
            else
            {
                numPoi = "441";
            }

            foreach (var point in points)
            {
                if (point.IsActive)
                {
                    activeSensors++;
                }
            }

            using (StreamWriter writer = new StreamWriter(Consts.FilePath + "INIT-RESULTS/neighborhood WSN-" + points.Count + ".txt"))
            {
                writer.WriteLine($"#Number of sensor: {points.Count}");
                writer.WriteLine($"#POI: {numPoi}");
                writer.WriteLine($"#Sensor form file DATA/WSN-5d.txt");
                writer.WriteLine($"#Active Sensor: {activeSensors}");
                writer.WriteLine($"#Range: {textBox1.Text}");
                writer.WriteLine($"#id num_of_neighb id-of_neighbnours");
                foreach (Models.Point PointCheck in sortedPoints)
                {
                    string neighbor = "";
                    int count = 0;
                    neighborhood.Add(new List<int>());

                    foreach (Models.Point PointToCalculate in sortedPoints)
                    {
                        if (PointCheck.Id != PointToCalculate.Id)
                        {
                            if (Math.Sqrt(Math.Pow(PointCheck.X - PointToCalculate.X, 2) + Math.Pow(PointCheck.Y - PointToCalculate.Y, 2)) < 2 * Convert.ToInt32(textBox1.Text))
                            {
                                neighbor += " " + PointToCalculate.Id;
                                neighborhood[neighborhood.Count - 1].Add(PointToCalculate.Id);
                                count++;
                            }
                        }
                    }
                    writer.WriteLine($"{PointCheck.Id}" + " " + count + " " + neighbor);
                }
            }
            MessageBox.Show("The neighborhood was found and saved to a file in the INIT-RESULTS directory", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gui2 gui2 = new Gui2(points, pois, neighborhood);
            gui2.Show();
        }
    }
}