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

        public new void Show()
        {
            DataGridViewCustomers.DataSource = _appController.GetAllCustomers();
            base.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadDashboard();
            TextBoxSearchCustomer.Clear();
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadAddUpdateCustomerScreen(false);
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            var customerId = DataGridViewCustomers.SelectedCells[0].EditedFormattedValue.ToString();
            _appController.LoadAddUpdateCustomerScreenWithCustomerId(customerId);
            Hide();
            
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var customerId = DataGridViewCustomers.SelectedCells[0].EditedFormattedValue.ToString();
            var customer = _appController.GetCustomerByCustomerId(Convert.ToInt32(customerId) );
            var dialog = MessageBox.Show($"Are you sure you want to delete this Customer?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _appController.DeleteCustomer(customer);
                DataGridViewCustomers.DataSource = _appController.GetAllCustomers();
            }

        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewCustomers.DataSource = _appController.GetCustomersBySearch(TextBoxSearchCustomer.Text);
        }

        private void BtnResetSearch_Click(object sender, EventArgs e)
        {
            TextBoxSearchCustomer.Clear();
            DataGridViewCustomers.DataSource = _appController.GetAllCustomers();
        }
    }
}
