using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.SuppliersScreens
{
    public partial class DeleteSupplierScreen : Form
    {
        private clsSuppliers _currentSupplier = null;

        public DeleteSupplierScreen()
        {
            InitializeComponent();
        }

        private void DeleteSupplierScreen_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtSearch.Select();
        }

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
                btnDelete.Enabled = true;
            }
            else
            {
                ClearFields();
                btnDelete.Enabled = false;
                MessageBox.Show("Tedarikçi bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentSupplier == null) return;

            DialogResult confirm = MessageBox.Show(
                $"'{_currentSupplier.Name} {_currentSupplier.LastName}' tedarikçiyi silmek istediğinizden emin misiniz?",
                "Tedarikçi Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            if (_currentSupplier.Delete())
            {
                MessageBox.Show("Tedarikçi başarıyla silindi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tedarikçi silinemedi! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}