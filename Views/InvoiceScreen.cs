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
    public partial class InvoiceScreen : Form
    {
        private AppController _appController;
        public InvoiceScreen(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }

        public new void Show()
        {
            DataGridViewInvoices.DataSource = _appController.GetAllInvoices();
            if (DataGridViewInvoices.RowCount == 0)
            {
                BtnUpdateInvoice.Enabled = false;
                BtnDeleteInvoice.Enabled = false;
            }
            else
            {
                BtnUpdateInvoice.Enabled = true;
                BtnDeleteInvoice.Enabled = true;
            }
            base.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            _appController.LoadDashboard();
        }

        private void BtnAddNewInvoice_Click(object sender, EventArgs e)
        {
            var customerCount = _appController.GetAllCustomers().Count;
            if (customerCount == 0)
            {
                MessageBox.Show("At least 1 customer needs to be added before an invoice can be created.");
            }
            else
            {
                Hide();
                _appController.LoadAddUpdateInvoiceScreen(false);
            }
        }

        private void BtnUpdateInvoice_Click(object sender, EventArgs e)
        {
            var invoiceId = DataGridViewInvoices.SelectedCells[0].EditedFormattedValue.ToString();
            _appController.LoadAddUpdateInvoiceScreenWithInvoiceId(invoiceId);
            Hide();
        }

        private void BtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            var invoiceId = DataGridViewInvoices.SelectedCells[0].EditedFormattedValue.ToString();
            var invoice = _appController.GetInvoiceByInvoiceId(Convert.ToInt32(invoiceId));

            var dialog = MessageBox.Show("Are you sure you want to delete this invoice?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _appController.DeleteInvoice(invoice);
            }

            DataGridViewInvoices.DataSource = _appController.GetAllInvoices();

            if (_appController.GetAllInvoices().Count == 0)
            {
                BtnDeleteInvoice.Enabled = false;
                BtnUpdateInvoice.Enabled = false;
            }
        }
    }
}
