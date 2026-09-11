using StoreManager.Classes;
using StoreManager.Classes.BusinessLogic;
using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static StoreManager.LoginScreen;

namespace StoreManager.Screens.Products.ImprtedProducts
{
    public partial class ImportProductScreen : Form
    {
        ImportProductService _Service = new ImportProductService();

        int SupplierID = 0;
        string ProducImagePath = "";

        List<ProductsTabel> addedProducts = new List<ProductsTabel>();

        public ImportProductScreen()
        {
            InitializeComponent();
            lblUserFirstName.Text = CurrentUserInfo.UserName_LastName;
            lblUserName.Text = CurrentUserInfo.UserName;
            LoadCategories();
        }

        // Toplamı güncelle
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                total += decimal.Parse(row.Cells["clTotalPrice"].Value.ToString());
            }
            TotalBeforeDiscount.Text = total.ToString("N2");
            ApplyDiscount(total);
        }

        private void LoadCategories()
        {
            CategoriesList.DataSource = _Service.GetAllCategories();
            CategoriesList.DisplayMember = "CategoryName";
            CategoriesList.ValueMember = "Id";
        }

        // Tedarikçi ara
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string InputText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(InputText))
            {
                MessageBox.Show("Telefon NO veya Mail Giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SuppliersTabel supplier = _Service.GetSupplierByPhoneOrEmail(InputText);

            if (supplier != null)
            {
                SupplierID = supplier.Id;
                lblSupplierMail.Text = supplier.Email;
                lblSupplierName.Text = supplier.Name + " " + supplier.LastName;
                lblSupplierPhone.Text = supplier.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Tedarikçi bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProductPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProducImagePath = openFileDialog.FileName;
                ProductPicture.ImageLocation = ProducImagePath;
            }
        }

        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            if (SupplierID == 0)
            {
                MessageBox.Show("Lütfen önce tedarikçi seçiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
            {
                MessageBox.Show("Ürün adı boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProductPrice.Text.Trim()) ||
                !decimal.TryParse(txtProductPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Geçerli bir ürün fiyatı giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductPrice.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProductQuantity.Text.Trim()) ||
                !int.TryParse(txtProductQuantity.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Geçerli bir miktar giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductQuantity.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProductCode.Text.Trim()))
            {
                MessageBox.Show("Ürün kodu boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductCode.Focus();
                return;
            }

            bool codeExists = _Service.ProductCodeExists(txtProductCode.Text.Trim());

            if (codeExists)
            {
                MessageBox.Show("Bu ürün kodu zaten mevcut! Lütfen farklı bir kod giriniz.",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductCode.Focus();
                return;
            }

            int categoryId = int.Parse(CategoriesList.SelectedValue.ToString());
            string categoryName = (CategoriesList.SelectedItem as CategoriesTabel)?.CategoryName;

            ProductsTabel newProduct = new ProductsTabel();
            newProduct.Name = txtProductName.Text.Trim();
            newProduct.Code = txtProductCode.Text.Trim();
            newProduct.Price = price;
            newProduct.Quantity = quantity;
            newProduct.CategoryId = categoryId;

            _Service.AddProduct(newProduct);

            if (!string.IsNullOrEmpty(ProducImagePath))
            {
                string folderPath = Environment.CurrentDirectory + "\\Images\\Products\\";
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string destPath = folderPath + newProduct.Id + "_product.jpeg";
                File.Copy(ProducImagePath, destPath, true);

                _Service.UpdateProductImage(newProduct, destPath);

                ProducImagePath = "";
                ProductPicture.ImageLocation = "";
            }

            addedProducts.Add(newProduct);

            decimal totalPrice = price * quantity;
            dataGridView1.Rows.Add(
                newProduct.Id,
                newProduct.Name,
                price,
                quantity,
                categoryName,
                totalPrice
            );

            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductQuantity.Clear();
            txtProductCode.Clear();
            txtProductName.Focus();
            UpdateTotal();
        }

        private void btnDeleteProductFromBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeleteID.Text.Trim()) ||
                !int.TryParse(txtDeleteID.Text.Trim(), out int deleteId))
            {
                MessageBox.Show("Geçerli bir ID giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.Parse(row.Cells["clProductID"].Value.ToString()) == deleteId)
                {
                    ProductsTabel product = _Service.GetProductById(deleteId);
                    if (product != null)
                    {
                        _Service.DeleteProduct(deleteId);
                    }

                    addedProducts.RemoveAll(p => p.Id == deleteId);

                    dataGridView1.Rows.Remove(row);
                    UpdateTotal();
                    txtDeleteID.Clear();
                    MessageBox.Show("Ürün başarıyla kaldırıldı ✅",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Bu ID ile ürün bulunamadı!",
                            "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtNewCategory.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewCategory.Focus();
                return;
            }

            bool exists = _Service.CategoryExists(categoryName);
            if (exists)
            {
                MessageBox.Show("Bu kategori zaten mevcut!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriesTabel newCategory = new CategoriesTabel();
            newCategory.CategoryName = categoryName;

            _Service.AddCategory(newCategory);

            LoadCategories();
            CategoriesList.SelectedValue = newCategory.Id;

            txtNewCategory.Clear();
            MessageBox.Show("Kategori başarıyla eklendi ✅",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelNewCategory_Click(object sender, EventArgs e)
        {
            txtNewCategory.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SupplierID == 0)
            {
                MessageBox.Show("Lütfen önce tedarikçi seçiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (addedProducts.Count == 0)
            {
                MessageBox.Show("Faturaya en az bir ürün ekleyiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                total += decimal.Parse(row.Cells["clTotalPrice"].Value.ToString());
            }

            decimal discount = 0;
            if (!string.IsNullOrEmpty(txtDiscount.Text.Trim()))
                decimal.TryParse(txtDiscount.Text.Trim(), out discount);

            decimal totalAfterDiscount = total - (total * discount / 100);

            PurchaseBillTabel newBill = new PurchaseBillTabel();
            newBill.SupplierId = SupplierID;
            newBill.UserId = CurrentUserInfo.UserID;
            newBill.Date = BillDate.Value;
            newBill.Total = total;
            newBill.Discount = discount;
            newBill.TotalAfterDiscount = totalAfterDiscount;

            _Service.AddPurchaseBill(newBill);

            foreach (var product in addedProducts)
            {
                PurchaseBillDetailsTabel detail = new PurchaseBillDetailsTabel();
                detail.PurchaseBill_ID = newBill.Id;
                detail.ProductID = product.Id;
                detail.Quantity = product.Quantity;
                detail.CostPrice = product.Price;
                detail.TotalPrice = product.Price * product.Quantity;

                _Service.AddPurchaseBillDetail(detail);
            }

            _Service.SaveChanges();

            MessageBox.Show("Fatura başarıyla kaydedildi ✅",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearAll();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (addedProducts.Count > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "İptal etmek istediğinize emin misiniz? Eklenen ürünler silinecektir!",
                    "İptal Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.No) return;

                var idsToDelete = addedProducts.Select(p => p.Id).ToList();
                _Service.DeleteProducts(idsToDelete);
            }

            ClearAll();
        }

        private void ClearAll()
        {
            SupplierID = 0;
            ProducImagePath = "";
            addedProducts.Clear();
            dataGridView1.Rows.Clear();

            lblSupplierName.Text = "";
            lblSupplierPhone.Text = "";
            lblSupplierMail.Text = "";

            txtSearch.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductQuantity.Clear();
            txtProductCode.Clear();
            txtDeleteID.Clear();
            txtNewCategory.Clear();
            ProductPicture.ImageLocation = "";
            txtDiscount.Text = "";
            TotalBeforeDiscount.Text = "0.00";
            TotalAfterDiscount.Text = "0.00";
            txtSearch.Focus();
        }

        private void btnPerformDiscount_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TotalBeforeDiscount.Text, out decimal total))
                return;

            ApplyDiscount(total);
        }

        private void ApplyDiscount(decimal total)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text.Trim()) ||
                !decimal.TryParse(txtDiscount.Text.Trim(), out decimal discount) ||
                discount == 0)
            {
                TotalAfterDiscount.Text = total.ToString("N2");
                return;
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("İndirim oranı 0 ile 100 arasında olmalıdır!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TotalAfterDiscount.Text = total.ToString("N2");
                return;
            }

            decimal totalAfter = total - (total * discount / 100);
            TotalAfterDiscount.Text = totalAfter.ToString("N2");
        }

        private void TotalAfterDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TotalBeforeDiscount.Text, out decimal total))
                return;

            ApplyDiscount(total);
        }
    }
}