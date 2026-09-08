using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.SuppliersScreens
{
    public partial class AddNewSupplierScreen : Form
    {
        public AddNewSupplierScreen()
        {
            InitializeComponent();
        }

        private void AddNewSupplierScreen_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private bool IsEmptyFields()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) &&
                string.IsNullOrEmpty(txtLastName.Text.Trim()) &&
                string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()) &&
                string.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
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

            if (string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
            {
                MessageBox.Show("Şirket adı boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return true;
            }

            if (!IsValidPhoneNumber(txtPhoneNumber.Text.Trim()))
                return true;

            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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
                txtPhoneNumber.Focus();
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Telefon numarası yalnızca rakam içerebilir!",
                                    "Geçersiz Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhoneNumber.Focus();
                    return false;
                }
            }

            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır!",
                                "Geçersiz Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
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
                txtEmail.Focus();
                return false;
            }

            bool hasLetter = false;

            foreach (char c in email)
            {
                if (!char.IsLetterOrDigit(c) && c != '@' && c != '.' && c != '_' && c != '-')
                {
                    MessageBox.Show("Email geçersiz karakterler içeriyor!",
                                    "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }

                if (char.IsLetter(c))
                    hasLetter = true;
            }

            if (!hasLetter)
            {
                MessageBox.Show("Email en az bir harf içermelidir!",
                                "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmptyFields()) return;

            if (clsSuppliers.GetByPhoneNumber(txtPhoneNumber.Text.Trim()) != null)
            {
                MessageBox.Show("Bu telefon numarası zaten mevcut!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            if (clsSuppliers.GetByEmail(txtEmail.Text.Trim()) != null)
            {
                MessageBox.Show("Bu email zaten mevcut!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Yeni Tedarikçi Ekle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            clsSuppliers supplier = new clsSuppliers();
            supplier.Name = txtFirstName.Text.Trim();
            supplier.LastName = txtLastName.Text.Trim();
            supplier.PhoneNumber = txtPhoneNumber.Text.Trim();
            supplier.Email = txtEmail.Text.Trim();
            supplier.Address = txtAddress.Text.Trim();
            supplier.CompanyName = txtCompanyName.Text.Trim();
            supplier.isActive = chkIsActive.Checked;

            if (supplier.Add())
            {
                MessageBox.Show("Tedarikçi başarıyla eklendi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tedarikçi eklenemedi! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) { }
        private void txtLastName_TextChanged(object sender, EventArgs e) { }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtAddress_TextChanged(object sender, EventArgs e) { }
        private void txtCompanyName_TextChanged(object sender, EventArgs e) { }
        private void chkIsActive_CheckedChanged(object sender, EventArgs e) { }
    }
}