using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.UserScreens
{
    public partial class UpdateUserScreen : Form
    {
        private clsUser _currentUser = null;

        public UpdateUserScreen()
        {
            InitializeComponent();
        }

        private void SetFieldsEnabled(bool status)
        {
            txtFirstName.Enabled = status;
            txtLastName.Enabled = status;
            txtUserName.Enabled = status;
            txtPassword.Enabled = status;
            chkIsActive.Enabled = status;
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

        private bool IsEmptyFields()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("Ad boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Select();
                return true;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Soyad boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Select();
                return true;
            }

            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return true;
            }

            if (!IsValidUserName(txtUserName.Text.Trim()))
                return true;

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Şifre boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return true;
            }

            if (!IsValidPassword(txtPassword.Text.Trim()))
                return true;

            return false;
        }

        private bool IsValidUserName(string userName)
        {
            if (userName.Contains(" "))
            {
                MessageBox.Show("Kullanıcı adı boşluk içeremez!",
                                "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return false;
            }

            bool hasLetter = false;

            foreach (char c in userName)
            {
                if (!char.IsLetterOrDigit(c) || c > 127)
                {
                    MessageBox.Show("Kullanıcı adı yalnızca İngilizce harf ve rakam içerebilir!",
                                    "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Select();
                    return false;
                }

                if (char.IsLetter(c)) hasLetter = true;
            }

            if (!hasLetter)
            {
                MessageBox.Show("Kullanıcı adı yalnızca rakamlardan oluşamaz! En az bir harf içermelidir.",
                                "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return false;
            }

            return true;
        }

        private bool IsValidPassword(string password)
        {
            if (password.Contains(" "))
            {
                MessageBox.Show("Şifre boşluk içeremez!",
                                "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return false;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır!",
                                "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return false;
            }

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c) || c > 127)
                {
                    MessageBox.Show("Şifre yalnızca İngilizce harf ve rakam içerebilir!",
                                    "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Select();
                    return false;
                }

                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            if (hasLetter && !hasDigit)
            {
                MessageBox.Show("Şifre yalnızca harflerden oluşamaz! En az bir rakam içermelidir.",
                                "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return false;
            }

            return true;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Lütfen kullanıcı adını giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }

            _currentUser = clsUser.GetByUserName(txtSearch.Text.Trim());

            if (_currentUser != null)
            {
                FillFields(_currentUser);
                SetFieldsEnabled(true);
                btnUpdate.Enabled = true;
                txtFirstName.Select();
            }
            else
            {
                ClearFields();
                SetFieldsEnabled(false);
                btnUpdate.Enabled = false;
                MessageBox.Show("Kullanıcı bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (_currentUser == null) return;

            if (IsEmptyFields()) return;

            // التحقق من تكرار اسم المستخدم فقط إذا تم تغييره
            if (txtUserName.Text.Trim() != _currentUser.UserName)
            {
                clsUser existingUser = clsUser.GetByUserName(txtUserName.Text.Trim());
                if (existingUser != null)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Select();
                    return;
                }
            }

            DialogResult confirm = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Kullanıcı Güncelle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            _currentUser.FirstName = txtFirstName.Text.Trim();
            _currentUser.LastName = txtLastName.Text.Trim();
            _currentUser.UserName = txtUserName.Text.Trim();
            _currentUser.Password = txtPassword.Text.Trim();
            _currentUser.isActive = chkIsActive.Checked;

            if (_currentUser.Update())
            {
                MessageBox.Show("Kullanıcı başarıyla güncellendi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        private void UpdateUserScreen_Load_1(object sender, EventArgs e)
        {
            SetFieldsEnabled(false);
            btnUpdate.Enabled = false;
            txtSearch.Select();
        }
    }
}