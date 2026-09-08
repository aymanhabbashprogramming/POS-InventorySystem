using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.CustomerScreens
{
    public partial class AddNewCustomerScreen : Form
    {
        public AddNewCustomerScreen()
        {
            InitializeComponent();
        }

        private bool IsEmptyFields()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) &&
                string.IsNullOrEmpty(txtLastName.Text.Trim()) &&
                string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()) &&
                string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Tüm alanlar boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Select();
                return true;
            }

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

            if (string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Select();
                return true;
            }

            if (!IsValidPhoneNumber(txtPhoneNumber.Text.Trim()))
                return true;

            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Select();
                return true;
            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
                return true;

            return false;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Contains(" "))
            {
                MessageBox.Show("Telefon numarası boşluk içeremez!",
                                "Geçersiz Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Select();
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Telefon numarası yalnızca rakam içerebilir!",
                                    "Geçersiz Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhoneNumber.Select();
                    return false;
                }
            }

            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır!",
                                "Geçersiz Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Select();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            if (email.Contains(" "))
            {
                MessageBox.Show("Email boşluk içeremez!",
                                "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Select();
                return false;
            }

            bool hasLetter = false;

            foreach (char c in email)
            {
                if (!char.IsLetterOrDigit(c) && c != '@' && c != '.' && c != '_' && c != '-')
                {
                    MessageBox.Show("Email geçersiz karakterler içeriyor!",
                                    "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Select();
                    return false;
                }

                if (char.IsLetter(c))
                    hasLetter = true;
            }

            if (!hasLetter)
            {
                MessageBox.Show("Email en az bir harf içermelidir!",
                                "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Select();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmptyFields()) return;

            if (clsCustomers.GetCustomerByPhoneNumber(txtPhoneNumber.Text.Trim()) != null)
            {
                MessageBox.Show("Bu telefon numarası zaten mevcut!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Select();
                return;
            }

            if (clsCustomers.GetCustomerByEmail(txtEmail.Text.Trim()) != null)
            {
                MessageBox.Show("Bu email zaten mevcut!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Select();
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Yeni Müşteri Ekle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            clsCustomers customer = new clsCustomers();
            customer.Name = txtFirstName.Text.Trim();
            customer.LastName = txtLastName.Text.Trim();
            customer.Address = txtAddress.Text.Trim();
            customer.Email = txtEmail.Text.Trim();
            customer.PhoneNumber = txtPhoneNumber.Text.Trim();
            customer.isActive = chkIsActive.Checked;
            

            if (customer.AddNewCustomer())
            {
                MessageBox.Show("Müşteri başarıyla eklendi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri eklenemedi! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}