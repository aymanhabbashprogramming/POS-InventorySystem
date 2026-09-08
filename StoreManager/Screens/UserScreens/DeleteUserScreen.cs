using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.UserScreens
{
    public partial class DeleteUserScreen : Form
    {
        private clsUser _currentUser = null;

        public DeleteUserScreen()
        {
            InitializeComponent();
        }

        private void FillFields(clsUser user)
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            chkIsActive.Checked = user.isActive;
        }

        private void ClearFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            chkIsActive.Checked = false;
        }
       
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Lütfen kullanıcı adını giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            _currentUser = clsUser.GetByUserName(txtSearch.Text.Trim());

            if (_currentUser != null)
            {
                FillFields(_currentUser);
                btnDelete.Enabled = true;
            }
            else
            {
                ClearFields();
                btnDelete.Enabled = false;
                MessageBox.Show("Kullanıcı bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (_currentUser == null) return;

            DialogResult confirm = MessageBox.Show(
                $"'{_currentUser.UserName}' kullanıcısını silmek istediğinizden emin misiniz?",
                "Kullanıcı Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            if (_currentUser.Delete())
            {
                MessageBox.Show("Kullanıcı başarıyla silindi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı silinemedi! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUserScreen_Load_1(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            this.ActiveControl = txtSearch;
        }
    }
}