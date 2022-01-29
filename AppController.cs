using FinalProject_MobileMowersCRM.Helpers;
using FinalProject_MobileMowersCRM.Models;
using FinalProject_MobileMowersCRM.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM
{
   
    public class AppController
    {
        private readonly NavigationHelper navHelpers;
        private readonly DatabaseHelpers databaseHelpers;

        private readonly Dashboard dashboard;
        private readonly CustomerScreen customerScreen;
        private readonly ServiceScreen serviceScreen;
        private readonly InvoiceScreen invoiceScreen;
        private readonly ReportScreen reportScreen;

        public AppController()
        {
            navHelpers = new NavigationHelper();
            databaseHelpers = new DatabaseHelpers();

            dashboard = new Dashboard(this);
            customerScreen = new CustomerScreen(this);
            serviceScreen = new ServiceScreen(this);
            invoiceScreen = new InvoiceScreen(this);
            reportScreen = new ReportScreen(this); 

            databaseHelpers.ConnectDatabase();
            Application.Run(new Dashboard(this));
        }

        public void LoadCustomerScreen()
        {
            navHelpers.Load(customerScreen);
        }

        public void LoadDashboard()
        {
            navHelpers.Load(dashboard);
        }

        public void LoadServiceScreen()
        {
            navHelpers.Load(serviceScreen);
        }

        public void LoadInvoiceScreen()
        {
            navHelpers.Load(invoiceScreen);
        }

        public void LoadReportScreen()
        {
            navHelpers.Load(reportScreen);
        }

        public void AddNewCustomer(Customer customer)
        {
            databaseHelpers.AddCusomter(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return databaseHelpers.GetAllCustomers();
        }
    }
}
