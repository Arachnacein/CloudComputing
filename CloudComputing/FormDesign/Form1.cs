using CloudComputing.Services;

namespace CloudComputing
{
    public partial class Form1 : Form
    {
        private readonly IFilesReaderService _readerService;

        public Form1(IFilesReaderService filesReader)
        {
            InitializeComponent();
            _readerService = filesReader;

            Start();
        }

        private void Start()
        {
            List<Models.Point> points = _readerService.ReadData("dane1.txt");
            dataGridView1.DataSource = points;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}