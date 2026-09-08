using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.CustomerScreens
{
    public partial class UpdateCustomerScreen : Form
    {
        private clsCustomers _currentCustomer = null;

        public UpdateCustomerScreen()
        {
            InitializeComponent();
        }


        private void SetFieldsEnabled(bool status)
        {
            txtFirstName.Enabled = status;
            txtLastName.Enabled = status;
            txtPhoneNumber.Enabled = status;
            txtEmail.Enabled = status;
            txtAddress.Enabled = status;
            chkIsActive.Enabled = status;
        }

        private void FillFields(clsCustomers customer)
        {
            txtFirstName.Text = customer.Name;
            txtLastName.Text = customer.LastName;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtEmail.Text = customer.Email;
            txtAddress.Text = customer.Address;
            chkIsActive.Checked = customer.isActive;
        }

        private void ClearFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
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

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Lütfen telefon numarası veya email giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }

            _currentCustomer = clsCustomers.GetCustomerByPhoneNumber(txtSearch.Text.Trim());

            if (_currentCustomer == null)
                _currentCustomer = clsCustomers.GetCustomerByEmail(txtSearch.Text.Trim());

            if (_currentCustomer != null)
            {
                FillFields(_currentCustomer);
                SetFieldsEnabled(true);
                btnUpdate.Enabled = true;
                txtFirstName.Select();
            }
            else
            {
                ClearFields();
                SetFieldsEnabled(false);
                btnUpdate.Enabled = false;
                MessageBox.Show("Müşteri bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            if (IsEmptyFields()) return;

            // التحقق من تكرار رقم الهاتف فقط إذا تغير
            if (txtPhoneNumber.Text.Trim() != _currentCustomer.PhoneNumber)
            {
                if (clsCustomers.GetCustomerByPhoneNumber(txtPhoneNumber.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu telefon numarası zaten mevcut!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Select();
                    return;
                }
            }

            // التحقق من تكرار الإيميل فقط إذا تغير
            if (txtEmail.Text.Trim() != _currentCustomer.Email)
            {
                if (clsCustomers.GetCustomerByEmail(txtEmail.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu email zaten mevcut!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Select();
                    return;
                }
            }

            DialogResult confirm = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Müşteri Güncelle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            _currentCustomer.Name = txtFirstName.Text.Trim();
            _currentCustomer.LastName = txtLastName.Text.Trim();
            _currentCustomer.PhoneNumber = txtPhoneNumber.Text.Trim();
            _currentCustomer.Email = txtEmail.Text.Trim();
            _currentCustomer.Address = txtAddress.Text.Trim();
            _currentCustomer.isActive = chkIsActive.Checked;

            if (_currentCustomer.UpdateCustomer())
            {
                MessageBox.Show("Müşteri başarıyla güncellendi ✅",
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

        private void UpdateCustomerScreen_Load_1(object sender, EventArgs e)
        {
            SetFieldsEnabled(false);
            btnUpdate.Enabled = false;
            txtSearch.Select();
        }
    }
}