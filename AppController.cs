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

        private readonly CustomerScreen customerScreen;
        private readonly Dashboard dashboard;

        public AppController()
        {
            navHelpers = new NavigationHelper();
            databaseHelpers = new DatabaseHelpers();

            customerScreen = new CustomerScreen(this);
            dashboard = new Dashboard(this);

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
    }
}
