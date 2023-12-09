using CloudComputing.Services;

namespace CloudComputing
{
    public partial class Form1 : Form
    {
        private List<Models.Point> points;

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                foreach (var point in points)
                {
                    Brush fillBrush = new SolidBrush(Color.FromArgb(128, Color.Yellow)); // Pó³przezroczysty ¿ó³ty
                    Pen borderPen = new Pen(Color.Black, 1);

                    if (point.IsActive)
                    {
                        g.FillEllipse(fillBrush, (int)(point.X * 7.5) - (int)(point.Radius * 7.5),
                            (int)(point.Y * 7.5) - (int)(point.Radius * 7.5), 2 * (int)(point.Radius * 7.5),
                            2 * (int)(point.Radius * 7.5));
                    }

                    g.DrawEllipse(borderPen, (int)(point.X * 7.5) - (int)(point.Radius * 7.5), (int)(point.Y * 7.5) - (int)(point.Radius * 7.5), 2 * (int)(point.Radius * 7.5), 2 * (int)(point.Radius * 7.5));
                }
            }
        }
    }
}