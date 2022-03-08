using FinalProject_MobileMowersCRM.Helpers;
using FinalProject_MobileMowersCRM.Models;
using FinalProject_MobileMowersCRM.Views;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace FinalProject_MobileMowersCRM
{
   
    public class AppController
    {
        private readonly DatabaseHelpers databaseHelpers;

        private readonly Dashboard dashboard;
        private readonly CustomerScreen customerScreen;
        private readonly AddUpdateCustomerScreen addUpdateCustomerScreen;
        private readonly ServiceScreen serviceScreen;
        private readonly InvoiceScreen invoiceScreen;
        private readonly AddUpdateInvoiceScreen addUpdateInvoiceScreen;
        private readonly ReportScreen reportScreen;

        public AppController()
        {
            databaseHelpers = new DatabaseHelpers();

            dashboard = new Dashboard(this);
            customerScreen = new CustomerScreen(this);
            addUpdateCustomerScreen  = new AddUpdateCustomerScreen(this);
            serviceScreen = new ServiceScreen(this);
            invoiceScreen = new InvoiceScreen(this);
            addUpdateInvoiceScreen = new AddUpdateInvoiceScreen(this);
            reportScreen = new ReportScreen(this); 

            databaseHelpers.ConnectDatabase();
            Application.Run(new LoginScreen(this));
        }

        public void LoadCustomerScreen()
        {
            customerScreen.Show();
        }

        public void LoadAddUpdateCustomerScreen(bool isUpdating)
        {
            addUpdateCustomerScreen.Show(isUpdating);
        }

        public void LoadAddUpdateCustomerScreenWithCustomerId(string customerId)
        {
            var isUpdating = true;
            addUpdateCustomerScreen.Show(isUpdating);
            var customer = databaseHelpers.GetCustomerByCustomerId(Convert.ToInt32(customerId));
            addUpdateCustomerScreen.PopulateCustomer(customer);
        }

        public void LoadDashboard()
        {
            dashboard.Show();
        }

        public void LoadServiceScreen()
        {
            serviceScreen.Show();
        }

        public void LoadInvoiceScreen()
        {
            invoiceScreen.Show();
        }

        public void LoadReportScreen()
        {
            reportScreen.Show();
        }

        public void LoadAddUpdateInvoiceScreen(bool isUpdaing)
        {
            addUpdateInvoiceScreen.Show(isUpdaing);
        }

        public void LoadAddUpdateInvoiceScreenWithInvoiceId(string invoiceId)
        {
            //addUpdateInvoiceScreen.Show(isUpdating);
            var invoice = databaseHelpers.GetInvoiceByInvoiceId(Convert.ToInt32(invoiceId));
            var customer = databaseHelpers.GetCustomerByCustomerId(invoice.CustomerId);
            var listOfInvoiceToServices = databaseHelpers.GetAllServicesByInvoiceId(Convert.ToInt32(invoiceId));
            addUpdateInvoiceScreen.PopulateInvoice(invoice, listOfInvoiceToServices, customer);
        }

        public void AddNewCustomer(Customer customer)
        {
            databaseHelpers.AddCusomter(customer);
        }

        public Customer GetCustomerByCustomerId(int customerId)
        {
            return databaseHelpers.GetCustomerByCustomerId(customerId);
        }

        public void UpdateCustomer(Customer customer)
        {
            databaseHelpers.UpdateCustomer(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            databaseHelpers.DeleteCustomer(customer);
        }

        public void AddNewInvoice(Invoice invoice)
        {
            databaseHelpers.AddInvoice(invoice);
        }

        public void UpdateInvoice(Invoice invoice)
        {
            databaseHelpers.UpdateInvoice(invoice);
        }

        public void AddnewServiceToInvoice(ServiceToInvoice serviceToInvoice)
        {
            databaseHelpers.AddServiceToInvoice(serviceToInvoice);
        }

        public void DeleteAllServiceToInvoicesByInvoiceId(int invoiceId)
        {
            databaseHelpers.DeleteAllServiceToInvoicesByInvoiceId(invoiceId);
        }

        public List<Customer> GetAllCustomers()
        {
            return databaseHelpers.GetAllCustomers();
        }

        public List<Customer> GetCustomersBySearch(string searchText)
        {
            return databaseHelpers.GetCustomersBySearch(searchText).Result;
        }
        public List<Service> GetAllServices()
        {
            return databaseHelpers.GetAllServices();
        }

        public List<Invoice> GetAllInvoices()
        {
            return databaseHelpers.GetAllInvoices();
        }

        public Invoice GetInvoiceByInvoiceId(int invoiceId)
        {
            return databaseHelpers.GetInvoiceByInvoiceId(invoiceId);
        }

        public void DeleteInvoice(Invoice invoice)
        {
            databaseHelpers.DeleteInvoice(invoice);
        }

        public void DeleteInvoicesByCustomerId(int customerId)
        {
            databaseHelpers.DeleteInvoicesByCustomerId(customerId);
        }

        public List<Invoice> GetAllUnpaidInvoices()
        {
            return databaseHelpers.GetAllUnpaidInvoices().Result;
        }

        public List<Invoice> GetAllPaidInvoices()
        {
            return databaseHelpers.GetAllPaidInvoices().Result;
        }

        public List<Invoice> GetAllInvoicesByCustomerId(int customerId)
        {
            return databaseHelpers.GetAllInvoicesByCustomerId(customerId).Result;
        }

        public List<Customer> GetCustomerFirstNames()
        {
            var listOfCustomers = GetAllCustomers().ToList();
            var listOfComboBoxes = new List<ComboBox>();

            return listOfCustomers;
        }

        public bool validatePassword(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }

            var salt = databaseHelpers.GetSaltByUsername(username).ToString();

            if (salt == string.Empty)
            {
                return false;
            }

            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            var storedPassword = databaseHelpers.GetPasswordByUsername(username).ToString();

            if (hashedPassword == storedPassword)
            {
                return true;
            }

            return false;
        }

        public void PasswordHash(string password)
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = Convert.FromBase64String("salt");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

        }

        public void CheckPassword(string password)
        {
            var hashedPassword = "";
            var passwordVerififcationResult = new PasswordHasher<object?>().VerifyHashedPassword(null, hashedPassword, password);
        }

        public int AddToTotal (int addedAmount, int total)
        {
            return total + addedAmount;
        }

        public int SubtractFromTotal (int subtractedAmount, int total)
        {
            return total - subtractedAmount;
        }
    }
}
