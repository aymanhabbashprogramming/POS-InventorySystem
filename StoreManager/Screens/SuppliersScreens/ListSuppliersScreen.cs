using StoreManager.Classes;
using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.Screens.SuppliersScreens
{
    public partial class ListSuppliersScreen : Form
    {
        private readonly string _placeholder = "Email veya telefon ile ara...";

        public ListSuppliersScreen()
        {
            InitializeComponent();
        }

        private void BindData(List<SuppliersTabel> suppliers)
        {
            dataGridView1.Rows.Clear();

            foreach (var supplier in suppliers)
            {
                dataGridView1.Rows.Add(
                    supplier.Id,
                    supplier.CompanyName,
                    supplier.Email,
                    supplier.Name,
                    supplier.LastName,
                    supplier.PhoneNumber,
                    supplier.Address,
                    supplier.isActive
                );
            }
        }

        private void ListSuppliersScreen_Load(object sender, EventArgs e)
        {
            txtSearch.Text = _placeholder;
            txtSearch.ForeColor = Color.Gray;
            this.ActiveControl = dataGridView1;

            List<SuppliersTabel> suppliers = clsSuppliers.GetAll();
            lblCount.Text = suppliers.Count.ToString();
            lblCountAktive.Text = suppliers.Count(s => s.isActive).ToString();
            lblCountPassive.Text = suppliers.Count(s => !s.isActive).ToString();

            BindData(suppliers);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == _placeholder)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = _placeholder;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(search) || search == _placeholder)
            {
                BindData(clsSuppliers.GetAll());
                return;
            }

            List<SuppliersTabel> filtered = clsSuppliers.GetAll()
                .Where(s => (s.PhoneNumber != null && s.PhoneNumber == search) ||
                            (s.Email != null && s.Email == search))
                .ToList();

            if (filtered.Count == 0)
            {
                MessageBox.Show("Sonuç bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            BindData(filtered);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = _placeholder;
            txtSearch.ForeColor = Color.Gray;

            List<SuppliersTabel> suppliers = clsSuppliers.GetAll();
            lblCount.Text = suppliers.Count.ToString();
            lblCountAktive.Text = suppliers.Count(s => s.isActive).ToString();
            lblCountPassive.Text = suppliers.Count(s => !s.isActive).ToString();

            BindData(suppliers);
        }
    }
}