using StoreManager.Classes;
using System;
using System.Windows.Forms;

namespace StoreManager.Screens.CustomerScreens
{
    public partial class DeleteCustomerScreen : Form
    {
        private clsCustomers _currentCustomer = null;

        public DeleteCustomerScreen()
        {
            InitializeComponent();
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
                btnDelete.Enabled = true;
            }
            else
            {
                ClearFields();
                btnDelete.Enabled = false;
                MessageBox.Show("Müşteri bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (_currentCustomer == null) return;

            DialogResult confirm = MessageBox.Show(
                $"'{_currentCustomer.Name} {_currentCustomer.LastName}' müşteriyi silmek istediğinizden emin misiniz?",
                "Müşteri Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            if (_currentCustomer.DeletCustomer())
            {
                MessageBox.Show("Müşteri başarıyla silindi ✅",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri silinemedi! ❌",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteCustomerScreen_Load_1(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtSearch.Select();
        }
    }
}