namespace Computing_sac_task_3
{
    public partial class Form1 : Form
    {
        List<Sale> sales = new List<Sale>();
        string filter;
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            LoadCSV();
            bs.DataSource = sales;
            dgvSales.DataSource = bs;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadCSV()
        {
            //Opening the csv file
            string filePath = @"c:\users\Angus Madden\Downloads\Task3_Shop_Data.csv";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                List<string> items = line.Split(',').ToList();
                //reading the lines from the csv
                Sale s = new Sale();
                s.Textbook = items[0];
                s.Subject = items[1];
                s.PurchasePrice = float.Parse(items[4]);
                s.SalePrice = items[5];
                s.Rating = items[6];
                sales.Add(s);

            }
        }
    }
}