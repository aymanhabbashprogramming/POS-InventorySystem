using StoreManager.Classes;
using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.Screens.CustomerScreens
{
    public partial class ListCustomersScreen : Form
    {
        private readonly string _placeholder = "Email veya telefon ile ara...";

        public ListCustomersScreen()
        {
            InitializeComponent();
           
        }

        private void BindData(List<CustomersTabel> customers)
        {
            dataGridView1.Rows.Clear();

            foreach (var customer in customers)
            {
                dataGridView1.Rows.Add(
                    customer.Id,
                    customer.Email,
                    customer.Name,
                    customer.LastName,
                    customer.PhoneNumber,
                    customer.Address,
                    customer.isActive
                );
            }
        }
        private void ListCustomersScreen_Load_1(object sender, EventArgs e)
        {
            txtSearch.Text = _placeholder;
            txtSearch.ForeColor = Color.Gray;
            this.ActiveControl = dataGridView1;

            List<CustomersTabel> customers = clsCustomers.GetAll();
            lblCount.Text = customers.Count.ToString();
            lblCountAktive.Text = customers.Count(c => c.isActive).ToString();
            lblCountPassive.Text = customers.Count(c => !c.isActive).ToString();

            BindData(customers);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(search) || search == _placeholder)
            {
                BindData(clsCustomers.GetAll());
                return;
            }

            List<CustomersTabel> filtered = clsCustomers.GetAll()
                .Where(c => 
                       
                            (c.PhoneNumber != null && c.PhoneNumber == search) ||
                            (c.Email == search))
                .ToList();

            if (filtered.Count == 0)
            {
                MessageBox.Show("Sonuç bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            BindData(filtered);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = _placeholder;
            txtSearch.ForeColor = Color.Gray;
            BindData(clsCustomers.GetAll());
            List<CustomersTabel> customers = clsCustomers.GetAll();
            lblCount.Text = customers.Count.ToString();
            lblCountAktive.Text = customers.Count(c => c.isActive).ToString();
            lblCountPassive.Text = customers.Count(c => !c.isActive).ToString();
        }

        private void txtSearch_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = _placeholder;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == _placeholder)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}