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
    public partial class AddUpdateInvoiceScreen : Form
    {
        private AppController _appController;
        private int _selectedCustomerId;
        private bool _isUpdating;
        private Customer _currentCustomer;
        private Invoice _currentInvoice;
        private bool HasLoadedForTheFirstTime = false;

        private List<Customer> listOfCustomers;
        private List<Service> listOfServices;
        private List<CheckBox> listOfCheckboxes = new List<CheckBox>();
        private List<Label> listOfLabels = new List<Label>();
        private int total;

        public AddUpdateInvoiceScreen(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }

        //public new void Show(bool isUpdaing)
        //{
        //    base.Show();
        //}

        public void Show(bool isUpdating)
        {
            LoadComponents();
            _isUpdating = isUpdating;
            if (_isUpdating)
            {
                BtnAddNewInvoice.Text = "Save";
                Text = "Update Invoice";
                DropDownCustomers.SelectedItem = _currentCustomer;
            }
            else
            {
                BtnAddNewInvoice.Text = "Add";
                Text = "Add new Invoice";
                CheckBoxHasPaid.Enabled = false;
                BtnAddNewInvoice.Enabled = false;
                TextBoxDateCreated.Text = String.Empty;
                TextBoxDatePaid.Text = String.Empty;
            }
            Show();
        }

        private void BtnAddNewInvoice_Click(object sender, EventArgs e)
        {
            if (_isUpdating)
            {
                var invoice = _currentInvoice;
                if (CheckBoxHasPaid.Checked)
                {
                    invoice.DatePaid = DateTime.Now.ToString();
                    invoice.HasPaid = true;
                }

                invoice.CustomerId = _selectedCustomerId;
                invoice.InvoiceAmount = total;

                _appController.UpdateInvoice(invoice);
                _appController.DeleteAllServiceToInvoicesByInvoiceId(_currentInvoice.InvoiceID);

                foreach (var checkbox in listOfCheckboxes)
                {
                    if (checkbox.Checked)
                    {
                        var serviceToInvoice = new ServiceToInvoice()
                        {
                            InvoiceId = invoice.InvoiceID,
                            ServiceId = GetServiceId(checkbox.Text)
                        };
                        _appController.AddnewServiceToInvoice(serviceToInvoice);
                    }
                }
            }
            else
            {
                var invoice = new Invoice()
                {
                    CustomerId = _selectedCustomerId,
                    DateCreated = DateTime.Now.ToString(),
                    HasPaid = CheckBoxHasPaid.Checked,
                    InvoiceAmount = total
                };
                if (CheckBoxHasPaid.Checked)
                {
                    invoice.DatePaid = DateTime.Now.ToString();
                }
                _appController.AddNewInvoice(invoice);

                foreach (var checkbox in listOfCheckboxes)
                {
                    if (checkbox.Checked)
                    {
                        var serviceToInvoice = new ServiceToInvoice()
                        {
                            InvoiceId = invoice.InvoiceID,
                            ServiceId = GetServiceId(checkbox.Text)
                        };
                        _appController.AddnewServiceToInvoice(serviceToInvoice);
                    }
                }
            }
            CleanUp();
            Hide();
            _appController.LoadInvoiceScreen();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CleanUp();
        }

        public int GetServiceId(string name)
        {
            int id = 0;
            for (var i = 0; i < listOfServices.Count; i++)
            {
                if (listOfServices[i].ServiceName == name)
                {
                    id = listOfServices[i].ServiceId;
                    break;
                }
            }
            return id;
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                total = _appController.AddToTotal(Convert.ToInt32(box.Tag), total);
            }
            else
            {
                total = _appController.SubtractFromTotal(Convert.ToInt32(box.Tag), total);
            }
            if (total == 0)
            {
                CheckBoxHasPaid.Enabled = false;
                BtnAddNewInvoice.Enabled = false;
            } 
            else
            {
                CheckBoxHasPaid.Enabled = true;
                BtnAddNewInvoice.Enabled = true;
            }
            UpdateTotal();
        }


        private void LoadComponents()
        {

            listOfServices = _appController.GetAllServices();

            if (listOfCheckboxes.Count == 0)
            {
                for (var i = 0; i < listOfServices.Count; i++)
                {
                    var service = listOfServices[i];
                    var box = new CheckBox();
                    box.Text = service.ServiceName;
                    box.Tag = service.ServiceAmount;
                    box.AutoSize = true;
                    box.Location = new Point(33, 275 + (i * 40));
                    box.CheckedChanged += new EventHandler(CheckBox_Checked);
                    Controls.Add(box);

                    var lbl = new Label();
                    lbl.Text = DisplayAmount(service.ServiceAmount.ToString());
                    lbl.AutoSize = true;
                    lbl.Location = new Point(257, 275 + (i * 40));
                    Controls.Add(lbl);

                    listOfCheckboxes.Add(box);
                    listOfLabels.Add(lbl);
                }
            }

            listOfCustomers = _appController.GetAllCustomers().ToList();
            DropDownCustomers.DataSource = listOfCustomers;
            DropDownCustomers.DisplayMember = "FirstName";
            DropDownCustomers.ValueMember = "CustomerID";

            LblWarningText.Text = "Checking this box will lock the Invoice. \n This cannot be undone";

            HasLoadedForTheFirstTime = true;
        }

        private string DisplayAmount(string value)
        {
            return "$ " + value; 
        }

        public void UpdateTotal()
        {
            TextBoxTotalAmount.Text = total.ToString();
        }

        private void AddUpdateInvoiceScreen_Load(object sender, EventArgs e)
        {

        }

        public void ClearFields()
        {
            foreach (var checkbox in listOfCheckboxes)
            {
                checkbox.Checked = false;
                checkbox.Enabled = true;
            }
            CheckBoxHasPaid.Checked = false;
            TextBoxDateCreated.Text = String.Empty;
            TextBoxDatePaid.Text = String.Empty;
            DropDownCustomers.Enabled = true;
            BtnAddNewInvoice.Enabled = true;
            CheckBoxHasPaid.Enabled = true;
        }

        public void CleanUp()
        {
            ClearFields();
            Hide();
            _appController.LoadInvoiceScreen();
        }

        public void PopulateInvoice(Invoice invoice, Task<List<ServiceToInvoice>> listOfServiceToInvoices, Customer customer)
        {
            BtnAddNewInvoice.Text = "Save";
            if (HasLoadedForTheFirstTime == false)
            {
                LoadComponents();
            }
            Show();
            _isUpdating = true;
            _currentInvoice = invoice;
            _currentCustomer = customer;

            DropDownCustomers.SelectedValue = customer.CustomerID;

            CheckBoxHasPaid.Checked = invoice.HasPaid;
            TextBoxDateCreated.Text = invoice.DateCreated;

            foreach (var service in listOfServices)
            {
                foreach (var serviceToInvoice in listOfServiceToInvoices.Result)
                {
                    if (serviceToInvoice.ServiceId == service.ServiceId)
                    {
                        SetCheckBox(service.ServiceName);
                        break;
                    }
                }
            }

            if (invoice.HasPaid)
            {
                TextBoxDatePaid.Text = invoice.DatePaid;
                LockInvoice();

            } 
            else
            {
                LblWarningText.Text = "Checking this box will lock the Invoice. \n This cannot be undone";
            }
        }

        public void SetCheckBox (string serviceName)
        {
            for (var i = 0; i < listOfCheckboxes.Count; i++)
            {
                var checkbox = listOfCheckboxes[i];
                if (checkbox.Text == serviceName)
                {
                    checkbox.Checked = true;
                    break;
                }
            }
        }


        private void DropDownCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCustomerId = listOfCustomers[DropDownCustomers.SelectedIndex].CustomerID;
            _currentCustomer = _appController.GetCustomerByCustomerId(_selectedCustomerId);
            PopulateCustomerInfo();
        }

        public void PopulateCustomerInfo()
        {
            LblFullName.Text = _currentCustomer?.FirstName + " " + _currentCustomer?.LastName;
            LblPhone.Text = _currentCustomer?.PhoneNumber;
            LblEmail.Text = _currentCustomer?.Email;
            LblAddress1.Text = _currentCustomer?.Address1;
            LblAddress2.Text = _currentCustomer?.Address2;
            LblCity.Text = _currentCustomer?.City;
            LblState.Text = _currentCustomer?.State;
            LblAreaCode.Text = _currentCustomer?.AreaCode.ToString();
        }

        private void CheckBoxHasPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxHasPaid.Checked)
            {
                LockInvoice();
            }
        }

        private void LockInvoice()
        {
            DropDownCustomers.Enabled = false;
            CheckBoxHasPaid.Enabled = false;
            LblWarningText.Text = "This invoice is locked.";

            foreach (var checkBox in listOfCheckboxes)
            {
                checkBox.Enabled = false;
            }
        }
    }
}
