using StoreManager.Classes;
using StoreManager.Screens;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        public static class CurrentUserInfo
        {
            public static string UserName_LastName;
            public static string UserName;
            public static int UserID;

        }
        void OpenForm()
        {
            Application.Run(new MainScreen());
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz!",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Giriş kontrolü
            clsUser user = clsUser.Login(userName, password);

            if (user != null)
            {
                CurrentUserInfo.UserName_LastName = user.FirstName + " " + user.LastName;
                CurrentUserInfo.UserID = user.Id;
                CurrentUserInfo.UserName =user.UserName;

                MessageBox.Show($"Hoş geldiniz, {user.FirstName} {user.LastName}!",
                                "Başarılı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                  
                // Ana ekranı aç
                
                this.Close();
                Thread th = new Thread(OpenForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void kryptonGroup1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}