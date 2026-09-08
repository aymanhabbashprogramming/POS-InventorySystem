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

namespace StoreManager.Screens.UserScreens
{
    public partial class ManageUsersScreen : Form
    {
        public ManageUsersScreen()
        {
            InitializeComponent();
        }
        void OpenForm()
        {
            Application.Run(new MainScreen());
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

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.UserScreens.AddNewUserScreen());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.UserScreens.DeleteUserScreen());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.UserScreens.UpdateUserScreen());

        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.UserScreens.ListUserScreen());

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
