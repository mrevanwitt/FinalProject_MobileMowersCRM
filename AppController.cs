using FinalProject_MobileMowersCRM.Helpers;
using FinalProject_MobileMowersCRM.Views;
using System;
using System.Collections.Generic;
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

        public AppController()
        {
            navHelpers = new NavigationHelper();
            databaseHelpers = new DatabaseHelpers();

            dashboard = new Dashboard(this);
            customerScreen = new CustomerScreen(this);
            serviceScreen = new ServiceScreen(this);
            invoiceScreen = new InvoiceScreen(this);

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

        public void LoadInvoices()
        {
            navHelpers.Load(invoiceScreen);
        }
    }
}
