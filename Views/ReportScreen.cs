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
    public partial class ReportScreen : Form
    {
        private readonly AppController _appController;
        private Customer firstCustomer;
        public ReportScreen(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            DataGridViewReports.DataSource = null;
            
            //DropDownCustomerFirstNames.DataSource = _appController.GetAllCustomers() ;

            DropDownCustomerFirstNames.Hide();

            base.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadDashboard();
        }

        private void BtnAllUnpaidInvoices_Click(object sender, EventArgs e)
        {
            DropDownCustomerFirstNames.Hide();
            DataGridViewReports.DataSource = _appController.GetAllUnpaidInvoices();
        }

        private void BtnAllPaidInvoices_Click(object sender, EventArgs e)
        {
            DropDownCustomerFirstNames.Hide();
            DataGridViewReports.DataSource = _appController.GetAllPaidInvoices();
        }

        private void BtnAllInvoicesByCustomer_Click(object sender, EventArgs e)
        {
            var listOfCustomers = _appController.GetAllCustomers().ToList();
            if (listOfCustomers.Count > 0)
            {
                firstCustomer = listOfCustomers[0];
            }
            var listOfComboBoxes = new List<ComboItem>();
            foreach (var customer in listOfCustomers)
            {
                var comboItem = new ComboItem()
                {
                    Id = customer.CustomerID,
                    FirstName = customer.FirstName
                };
                listOfComboBoxes.Add(comboItem);
            }
            DropDownCustomerFirstNames.DataSource = listOfComboBoxes;
            DropDownCustomerFirstNames.DisplayMember = "FirstName";
            DropDownCustomerFirstNames.ValueMember = "Id";

            DataGridViewReports.DataSource = _appController.GetAllInvoicesByCustomerId(firstCustomer.CustomerID);
            DropDownCustomerFirstNames.SelectedIndex = 0;
            DropDownCustomerFirstNames.Show();
        }

        private void DropDownCustomerFirstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = DropDownCustomerFirstNames.SelectedItem as ComboItem;
            if (selectedCustomer != null)
            {
                DataGridViewReports.DataSource = _appController.GetAllInvoicesByCustomerId(selectedCustomer.Id);
            }
        }
    }
}
