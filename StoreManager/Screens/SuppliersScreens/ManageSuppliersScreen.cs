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

namespace StoreManager.Screens.SuppliersScreens
{
    public partial class ManageSuppliersScreen : Form
    {
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

        public ManageSuppliersScreen()
        {
            InitializeComponent();
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.SuppliersScreens.AddNewSupplierScreen());

        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.SuppliersScreens.DeleteSupplierScreen());

        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.SuppliersScreens.UpdateSupplierScreen());

        }

        private void btnListSuppliers_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.SuppliersScreens.ListSuppliersScreen());

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
