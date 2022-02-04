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

        private List<Customer> listOfCustomers;
        private List<Service> listOfServices;
        private List<CheckBox> ListOfCheckboxes;
        private List<Label> ListOfLabels;
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
            Show();
        }

        private void BtnAddNewInvoice_Click(object sender, EventArgs e)
        {
            _selectedCustomerId = listOfCustomers[DropDownCustomers.SelectedIndex].CustomerID;

            var invoice = new Invoice()
            {
                InvoiceAmount = total,
                CustomerId = _selectedCustomerId,
                DateCreated = DateTime.Now.ToString()
            };
            _appController.AddNewInvoice(invoice);

            foreach (var checkbox in ListOfCheckboxes)
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
                total += Convert.ToInt32(box.Tag);
            }
            else
            {
                total -= Convert.ToInt32(box.Tag);
            }
            UpdateTotal();
        }


        private void LoadComponents()
        {
            listOfServices = _appController.GetAllServices();
            ListOfCheckboxes = new List<CheckBox>();
            ListOfLabels = new List<Label>();

            for (var i = 0; i < listOfServices.Count; i++)
            {
                var service = listOfServices[i];
                var box = new CheckBox();
                box.Text = service.ServiceName;
                box.Tag = service.ServiceAmount;
                box.AutoSize = true;
                box.Location = new Point(33, 143 + (i * 40));
                box.CheckedChanged += new EventHandler(CheckBox_Checked);
                Controls.Add(box);

                var lbl = new Label();
                lbl.Text = DisplayAmount(service.ServiceAmount.ToString());
                lbl.AutoSize = true;
                lbl.Location = new Point(257, 142 + (i * 40));
                Controls.Add(lbl);

                ListOfCheckboxes.Add(box);
                ListOfLabels.Add(lbl);
            }

            listOfCustomers = _appController.GetAllCustomers().ToList();
            var listOfFirstNames = new List<string>();
            foreach (var customer in listOfCustomers)
            {
                listOfFirstNames.Add(customer.FirstName);
            }
            DropDownCustomers.DataSource = listOfFirstNames;

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
    }
}
