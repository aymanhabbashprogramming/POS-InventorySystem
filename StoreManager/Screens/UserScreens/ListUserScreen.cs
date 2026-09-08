using StoreManager.Classes;
using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.Screens.UserScreens
{
    public partial class ListUserScreen : Form
    {
        private readonly string _placeholder = "Kullanıcı adıyla ara...";

        public ListUserScreen()
        {
            InitializeComponent();
        }

        private void BindData(List<UsersTabel> users)
        {
            dataGridView1.Rows.Clear();

            foreach (var user in users)
            {
                dataGridView1.Rows.Add(
                    user.Id,
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.Password,
                    user.isActive 
                );
            }
        }

        private void ListUserScreen_Load_1(object sender, EventArgs e)
        {
            txtSearch.Text = _placeholder;
            txtSearch.ForeColor = Color.Gray;
            this.ActiveControl = dataGridView1;

            List<UsersTabel> users = clsUser.GetAll();
            lblCount.Text = users.Count.ToString();
            lblCountAktive.Text = users.Count(u => u.isActive).ToString();
            lblCountPassive.Text = users.Count(u => !u.isActive).ToString();

            BindData(users);
        }

        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == _placeholder)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = _placeholder;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(search) || search == _placeholder)
            {
                BindData(clsUser.GetAll());
                return;
            }

            List<UsersTabel> filtered = clsUser.GetAll()
                .Where(u => (u.FirstName != null && u.FirstName.ToLower() == search.ToLower()) ||
                            (u.LastName != null && u.LastName.ToLower() == search.ToLower()) ||
                            (u.UserName != null && u.UserName.ToLower() == search.ToLower()))
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
            BindData(clsUser.GetAll());
            List<UsersTabel> users = clsUser.GetAll();
            lblCount.Text = users.Count.ToString();
            lblCountAktive.Text = users.Count(u => u.isActive).ToString();
            lblCountPassive.Text = users.Count(u => !u.isActive).ToString();
        }

    }
}