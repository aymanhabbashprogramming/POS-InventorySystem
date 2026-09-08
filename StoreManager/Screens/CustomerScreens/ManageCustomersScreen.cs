using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager.Screens.CustomerScreens
{
    public partial class ManageCustomersScreen : Form
    {
        public ManageCustomersScreen()
        {
            InitializeComponent();
        }

        private Form _currentScreen = null;
        private void OpenScreen(Form newScreen)
        {

            if (_currentScreen != null && !_currentScreen.IsDisposed)
                _currentScreen.Close();

            _currentScreen = newScreen;
            newScreen.MdiParent = this;
            newScreen.FormClosed += (s, e) => _currentScreen = null;
            newScreen.StartPosition = FormStartPosition.Manual;
            newScreen.Location = new Point(10, 10);
            newScreen.Show();
        }
        void OpenForm()
        {
            Application.Run(new MainScreen());
        }


        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.CustomerScreens.AddNewCustomerScreen());
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.CustomerScreens.DeleteCustomerScreen());
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.CustomerScreens.UpdateCustomerScreen());
        }

        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.CustomerScreens.ListCustomersScreen());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Screens.MainScreen mainScreen = new Screens.MainScreen();
    

            this.Close();
            Thread th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
