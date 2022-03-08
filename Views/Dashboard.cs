namespace FinalProject_MobileMowersCRM
{
    public partial class Dashboard : Form
    {
        AppController _appController;
        public Dashboard(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnLoadCustomerScreen_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadCustomerScreen();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadInvoiceScreen();
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadServiceScreen();
        }

        private void BtnReportScreen_Click(object sender, EventArgs e)
        {
            var customerCount = _appController.GetAllCustomers().Count;
            var invoiceCount = _appController.GetAllInvoices().Count;

            if (customerCount == 0 || invoiceCount == 0)
            {
                MessageBox.Show("At least 1 customer and 1 invoice needs to be greated before reports be generated.");
            } 
            else
            {
                Hide();
                _appController.LoadReportScreen();
            }

           
        }


    }
}