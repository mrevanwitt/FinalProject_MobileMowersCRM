﻿using FinalProject_MobileMowersCRM.Helpers;
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
        private readonly AddUpdateCustomerScreen addUpdateCustomerScreen;
        private readonly ServiceScreen serviceScreen;
        private readonly InvoiceScreen invoiceScreen;
        private readonly AddUpdateInvoiceScreen addUpdateInvoiceScreen;
        private readonly ReportScreen reportScreen;

        public AppController()
        {
            navHelpers = new NavigationHelper();
            databaseHelpers = new DatabaseHelpers();

            dashboard = new Dashboard(this);
            customerScreen = new CustomerScreen(this);
            addUpdateCustomerScreen  = new AddUpdateCustomerScreen(this);
            serviceScreen = new ServiceScreen(this);
            invoiceScreen = new InvoiceScreen(this);
            addUpdateInvoiceScreen = new AddUpdateInvoiceScreen(this);
            reportScreen = new ReportScreen(this); 

            databaseHelpers.ConnectDatabase();
            Application.Run(new Dashboard(this));
        }

        public void LoadCustomerScreen()
        {
            customerScreen.Show();
        }

        public void LoadAddUpdateCustomerScreen()
        {
            addUpdateCustomerScreen.Show();
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

        public void LoadAddUpdateInvoiceScreen()
        {
            addUpdateInvoiceScreen.Show();
        }

        public void AddNewCustomer(Customer customer)
        {
            databaseHelpers.AddCusomter(customer);
        }

        public void AddNewInvoice(Invoice invoice)
        {
            databaseHelpers.AddInvoice(invoice);
        }

        public void AddnewServiceToInvoice(ServiceToInvoice serviceToInvoice)
        {
            databaseHelpers.AddServiceToInvoice(serviceToInvoice);
        }

        public List<Customer> GetAllCustomers()
        {
            return databaseHelpers.GetAllCustomers();
        }

        public List<Service> GetAllServices()
        {
            return databaseHelpers.GetAllServices();
        }
    }
}
