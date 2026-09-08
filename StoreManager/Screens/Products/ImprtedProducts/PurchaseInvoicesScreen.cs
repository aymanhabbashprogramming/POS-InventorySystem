using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager.Screens.Products.ImprtedProducts
{
    public partial class PurchaseInvoicesScreen : Form
    {
        StoreManagerDBEntities StoreManagerDB = new StoreManagerDBEntities();
        public PurchaseInvoicesScreen()
        {
            InitializeComponent();
        }

        private void PurchaseInvoicesScreen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.Rows.Clear();

            dataGridView1.DataSource = StoreManagerDB.PurchaseBillTabels
                .Select(x => new
                {
                    clBill_ID = x.Id,
                    clSupplierName = x.SuppliersTabel.Name,
                    clUserFirstName = x.UsersTabel.UserName,
                    clDate = x.Date,
                    clDiscount = x.Discount,
                    clTotalBeforeDiscount = x.Total,
                    clTotalAfterDiscount = x.TotalAfterDiscount
                })
                .ToList();
        }

        private void btnRefreshBillList_Click(object sender, EventArgs e)
        {
            txtBill_IDToSearch.Clear();
            txtBill_IDToDelete.Clear();
            dataGridView2.Rows.Clear();
            LoadData();
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBill_IDToSearch.Text.Trim()))
            {
                MessageBox.Show("Fatura aramak için ID girmelisiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBill_IDToSearch.Text.Trim(), out int searchId))
            {
                MessageBox.Show("Geçerli bir ID giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bill = StoreManagerDB.PurchaseBillTabels.FirstOrDefault(x => x.Id == searchId);

            if (bill == null)
            {
                MessageBox.Show($"'{searchId}' ID'li fatura bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.Rows.Clear();

            dataGridView1.DataSource = StoreManagerDB.PurchaseBillTabels
                .Where(x => x.Id == searchId)
                .Select(x => new
                {
                    clBill_ID = x.Id,
                    clSupplierName = x.SuppliersTabel.Name,
                    clUserFirstName = x.UsersTabel.UserName,
                    clDate = x.Date,
                    clDiscount = x.Discount,
                    clTotalBeforeDiscount = x.Total,
                    clTotalAfterDiscount = x.TotalAfterDiscount
                })
                .ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Cells[0].Value == null) return;

            int id = int.Parse(dataGridView1.CurrentRow.Cells["clBill_ID"].Value.ToString());

            var bill = StoreManagerDB.PurchaseBillTabels.FirstOrDefault(x => x.Id == id);
            if (bill == null) return;

            dataGridView2.RowTemplate.Height = 70;

            foreach (var item in bill.PurchaseBillDetailsTabels)
            {
                
                Image productImage = null;
                try
                {
                    string imagePath = item.ProductsTabel?.Image;
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        using (Image original = Image.FromFile(imagePath))
                        {
                            Bitmap resized = new Bitmap(original, new Size(70, 70));
                            productImage = resized;
                        }
                    }
                    else
                    {
                        productImage = new Bitmap(70, 70);
                    }
                }
                catch
                {
                    productImage = new Bitmap(70, 70);
                }

                dataGridView2.Rows.Add(
                    item.ProductID,
                    item.ProductsTabel?.Name,
                    item.CostPrice,
                    item.Quantity,
                    item.TotalPrice,
                    productImage
                );
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBill_IDToDelete.Text.Trim()))
            {
                MessageBox.Show("Fatura silmek için ID girmelisiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBill_IDToDelete.Text.Trim(), out int billId))
            {
                MessageBox.Show("Geçerli bir ID giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bill = StoreManagerDB.PurchaseBillTabels.FirstOrDefault(x => x.Id == billId);

            if (bill == null)
            {
                MessageBox.Show($"'{billId}' ID'li fatura bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"'{billId}' ID'li faturayı silmek istediğinize emin misiniz?\nFatura detayları da silinecektir!",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            // Önce fatura detaylarını silاً
            var details = StoreManagerDB.PurchaseBillDetailsTabels
                            .Where(d => d.PurchaseBill_ID == billId)
                            .ToList();

            foreach (var detail in details)
                StoreManagerDB.PurchaseBillDetailsTabels.Remove(detail);

            // Sonra faturayı sil
            StoreManagerDB.PurchaseBillTabels.Remove(bill);
            StoreManagerDB.SaveChanges();

            MessageBox.Show("Fatura başarıyla silindi ✅",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBill_IDToDelete.Clear();
            dataGridView2.Rows.Clear();
            LoadData();
        }
    }
}
