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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnLoadCustomerScreen_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadCustomerScreen();
        }
    }
}