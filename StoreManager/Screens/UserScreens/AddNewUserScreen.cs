using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.UserScreens
{
    public partial class AddNewUserScreen : Form
    {
        public AddNewUserScreen()
        {
            InitializeComponent();
        }

        private bool IsEmptyFields()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) &&
                string.IsNullOrEmpty(txtLastName.Text.Trim()) &&
                string.IsNullOrEmpty(txtUserName.Text.Trim()) &&
                string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Tüm alanlar boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("Ad boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Soyad boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return true;
            }

            if (!IsValidUserName(txtUserName.Text.Trim()))
                return true;

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Şifre boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
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
                txtUserName.Focus();
                return false;
            }

            bool hasLetter = false;

            foreach (char c in userName)
            {
                if (!char.IsLetterOrDigit(c) || c > 127)
                {
                    MessageBox.Show("Kullanıcı adı yalnızca İngilizce harf ve rakam içerebilir!",
                                    "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return false;
                }

                if (char.IsLetter(c))
                    hasLetter = true;
            }

            if (!hasLetter)
            {
                MessageBox.Show("Kullanıcı adı yalnızca rakamlardan oluşamaz! En az bir harf içermelidir.",
                                "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
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
                txtPassword.Focus();
                return false;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır!",
                                "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
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
                    txtPassword.Focus();
                    return false;
                }

                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            // لا يسمح بحروف فقط — يجب أن يحتوي على رقم واحد على الأقل
            if (hasLetter && !hasDigit)
            {
                MessageBox.Show("Şifre yalnızca harflerden oluşamaz! En az bir rakam içermelidir.",
                                "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (IsEmptyFields()) return;

            if (clsUser.GetByUserName(txtUserName.Text.Trim()) != null)
            {
                MessageBox.Show("Bu kullanıcı adı zaten mevcut!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Select();
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Yeni Kullanıcı Ekle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            clsUser newUser = new clsUser(
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                txtUserName.Text.Trim(),
                txtPassword.Text.Trim(),
                chkIsActive.Checked
            );

            if (newUser.Add())
            {
                MessageBox.Show("Kullanıcı başarıyla eklendi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı eklenemedi! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUserScreen_Load_1(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }
    }
}