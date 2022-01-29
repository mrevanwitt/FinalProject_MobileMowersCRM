using FinalProject_MobileMowersCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_MobileMowersCRM.Views
{
    public partial class CustomerScreen : Form
    {
        AppController _appController;
        public CustomerScreen(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            DataGridViewCustomers.DataSource = _appController.GetAllCustomers();

            base.OnShown(e);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadDashboard();
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                Username = "UserName",
                Password = "Password",
                FirstName = "First Name",
                LastName = "Last Name",
                PhoneNumber = 1234567890,
                Email = "Email",
                Address1 = "Address1",
                Address2 = "Address2",
                City = "City",
                State = "State",
                AreaCode = 12345
            };
            _appController.AddNewCustomer(customer);
            DataGridViewCustomers.DataSource = _appController.GetAllCustomers();
        }
    }
}
