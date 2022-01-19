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
        NavigationHelper nav = new NavigationHelper();
        CustomerScreen customerScreen;
        Dashboard dashboard;

        public AppController()
        {
            customerScreen = new CustomerScreen(this);
            dashboard = new Dashboard(this);

            Application.Run(new Dashboard(this));
        }

        public void LoadCustomerScreen()
        {
            nav.Load(customerScreen);
        }

        public void LoadDashboard()
        {
            nav.Load(dashboard);
        }
    }
}
