using StoreManager.Database;
using StoreManager.Screens.CustomerScreens;
using StoreManager.Screens.Products;
using StoreManager.Screens.Products.ExportedProducts;
using StoreManager.Screens.Products.ImprtedProducts;
using StoreManager.Screens.SuppliersScreens;
using StoreManager.Screens.UserScreens;
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

namespace StoreManager.Screens
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            lblCurrentUser.Text = LoginScreen.CurrentUserInfo.UserName_LastName;
             LoadDashboardLabels();
        }

                void OpenForm()
        {
            Application.Run(new ManageUsersScreen());
        }
        void OpenForm2()
        {
            Application.Run(new ManageCustomersScreen());
        }

        void OpenForm3()
        {
            Application.Run(new ManageSuppliersScreen());
        }

        void OpenManageProductsScreen()
        {
            Application.Run(new ManageProductsScreen());
        }
    
        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenManageProductsScreen);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void LoadDashboardLabels()
        {
            using (StoreManagerDBEntities storeManagerDB = new StoreManagerDBEntities())
            {
                lblTotalUsers.Text = storeManagerDB.UsersTabels.Count().ToString();
                lblTotalProduct.Text= storeManagerDB.ProductsTabels.Count().ToString();
                lblTotalCustumer.Text = storeManagerDB.CustomersTabels.Count().ToString();
                lblTotalSuppliers.Text = storeManagerDB.SuppliersTabels.Count().ToString();
            }
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            Screens.UserScreens.ListUserScreen listUser = new ListUserScreen();
            listUser.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Screens.Products.ListAndDeleteProductScreen listandDeleteProductScreen = new ListAndDeleteProductScreen();
            listandDeleteProductScreen.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Screens.CustomerScreens.ListCustomersScreen listCustomersScreen = new ListCustomersScreen();
            listCustomersScreen.ShowDialog();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Screens.SuppliersScreens.ListSuppliersScreen listSuppliersScreen = new ListSuppliersScreen();
            listSuppliersScreen.ShowDialog();
        }
    }
}
