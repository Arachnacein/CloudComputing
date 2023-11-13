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
    }
}