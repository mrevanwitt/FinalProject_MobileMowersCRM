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
    public partial class ServiceScreen : Form
    {
        private AppController _appController;
        public ServiceScreen(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }
    }
}
