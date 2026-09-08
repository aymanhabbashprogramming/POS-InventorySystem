using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.SuppliersScreens
{
    public partial class UpdateSupplierScreen : Form
    {
        private clsSuppliers _currentSupplier = null;

        public UpdateSupplierScreen()
        {
            InitializeComponent();
        }

        // ── Form Load ─────────────────────────────
        private void UpdateSupplierScreen_Load(object sender, EventArgs e)
        {
            SetFieldsEnabled(false);
            btnUpdate.Enabled = false;
            txtSearch.Select();
        }

        // ── تفعيل / تعطيل الحقول ──────────────────
        private void SetFieldsEnabled(bool status)
        {
            txtFirstName.Enabled = status;
            txtLastName.Enabled = status;
            txtPhoneNumber.Enabled = status;
            txtEmail.Enabled = status;
            txtAddress.Enabled = status;
            txtCompanyName.Enabled = status;
            chkIsActive.Enabled = status;
        }

        // ── ملء الحقول ────────────────────────────
        private void FillFields(clsSuppliers supplier)
        {
            txtFirstName.Text = supplier.Name;
            txtLastName.Text = supplier.LastName;
            txtPhoneNumber.Text = supplier.PhoneNumber;
            txtEmail.Text = supplier.Email;
            txtAddress.Text = supplier.Address;
            txtCompanyName.Text = supplier.CompanyName;
            chkIsActive.Checked = supplier.isActive;
        }

        // ── تفريغ الحقول ──────────────────────────
        private void ClearFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        // ── التحقق من الحقول ──────────────────────
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

            if (string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
            {
                MessageBox.Show("Şirket adı boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Select();
                return true;
            }

            return false;
        }

        // ── التحقق من رقم الهاتف ──────────────────
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

        // ── التحقق من الإيميل ─────────────────────
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

        // ── زر Ara ────────────────────────────────
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Lütfen telefon numarası veya email giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }

            _currentSupplier = clsSuppliers.GetByPhoneNumber(txtSearch.Text.Trim());

            if (_currentSupplier == null)
                _currentSupplier = clsSuppliers.GetByEmail(txtSearch.Text.Trim());

            if (_currentSupplier != null)
            {
                FillFields(_currentSupplier);
                SetFieldsEnabled(true);
                btnUpdate.Enabled = true;
                txtFirstName.Select();
            }
            else
            {
                ClearFields();
                SetFieldsEnabled(false);
                btnUpdate.Enabled = false;
                MessageBox.Show("Tedarikçi bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
            }
        }

        // ── زر Güncelle ───────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentSupplier == null) return;

            if (IsEmptyFields()) return;

            // التحقق من تكرار رقم الهاتف فقط إذا تغير
            if (txtPhoneNumber.Text.Trim() != _currentSupplier.PhoneNumber)
            {
                if (clsSuppliers.GetByPhoneNumber(txtPhoneNumber.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu telefon numarası zaten mevcut!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Select();
                    return;
                }
            }

            // التحقق من تكرار الإيميل فقط إذا تغير
            if (txtEmail.Text.Trim() != _currentSupplier.Email)
            {
                if (clsSuppliers.GetByEmail(txtEmail.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu email zaten mevcut!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Select();
                    return;
                }
            }

            DialogResult confirm = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Tedarikçi Güncelle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            _currentSupplier.Name = txtFirstName.Text.Trim();
            _currentSupplier.LastName = txtLastName.Text.Trim();
            _currentSupplier.PhoneNumber = txtPhoneNumber.Text.Trim();
            _currentSupplier.Email = txtEmail.Text.Trim();
            _currentSupplier.Address = txtAddress.Text.Trim();
            _currentSupplier.CompanyName = txtCompanyName.Text.Trim();
            _currentSupplier.isActive = chkIsActive.Checked;

            if (_currentSupplier.Update())
            {
                MessageBox.Show("Tedarikçi başarıyla güncellendi ✅",
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

        // ── زر İptal ──────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}