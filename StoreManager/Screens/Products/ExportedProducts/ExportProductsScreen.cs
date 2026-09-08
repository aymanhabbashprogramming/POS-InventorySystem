using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.Screens.Products.ExportedProducts
{
    public partial class ExportProductsScreen : Form
    {
        StoreManagerDBEntities StoreManagerDB = new StoreManagerDBEntities();
        List<Database.ProductsTabel> productsList;
        int CustomerID = 0;
        int selectedQuantity = 0;
        Database.ProductsTabel currentProduct = null;

        public ExportProductsScreen()
        {
            InitializeComponent();
            lblUserFirstName.Text = LoginScreen.CurrentUserInfo.UserName_LastName;
            lblUserName.Text = LoginScreen.CurrentUserInfo.UserName;

            imageList1.ImageSize = new Size(70, 70);
            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imageList1;

            // Kategorileri yükle
            CategoriesList.DataSource = StoreManagerDB.CategoriesTabels.ToList();
            CategoriesList.DisplayMember = "CategoryName";
            CategoriesList.ValueMember = "Id";

            productsList = StoreManagerDB.ProductsTabels.ToList();
        }

        // Form Load 
        private void ExportProductsScreen_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            DisableProductButtons();
        }

        // Tüm ürünleri ListView'a yükle 
        private void LoadAllProducts()
        {
            productsList = StoreManagerDB.ProductsTabels.ToList();
            LoadProductsToListView(productsList);
        }
        private void LoadProductsToListView(List<Database.ProductsTabel> products)
        {
            listView1.Items.Clear();
            imageList1.Images.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                string imagePath = products[i].Image;

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                    imageList1.Images.Add(Image.FromFile(imagePath));
                else
                {
                    Bitmap btm = new Bitmap(70, 70);
                    using (Graphics g = Graphics.FromImage(btm))
                    {
                        g.Clear(Color.FromArgb(240, 240, 240));
                        g.DrawRectangle(Pens.Gray, 0, 0, 69, 69);
                    }
                    imageList1.Images.Add(btm);
                }

                ListViewItem item = new ListViewItem();
                item.Text = products[i].Name;
                item.ImageIndex = i;
                item.Tag = products[i];
                listView1.Items.Add(item);
            }
        }

        // Ürün butonlarını devre dışı bırak
        private void DisableProductButtons()
        {
            btnIncreaseQuantity.Enabled = false;
            btnDecreaseQuantity.Enabled = false;
            btnAddProductToBill.Enabled = false;
        }

        // Butonların durumunu güncelle
        private void UpdateButtons()
        {
            if (currentProduct == null)
            {
                DisableProductButtons();
                return;
            }

            btnIncreaseQuantity.Enabled = selectedQuantity < currentProduct.Quantity;
            btnDecreaseQuantity.Enabled = selectedQuantity > 0;
            btnAddProductToBill.Enabled = selectedQuantity > 0;
        }

        // ListView'dan ürün seç
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            currentProduct = (Database.ProductsTabel)listView1.SelectedItems[0].Tag;

            lblSelectedProducName.Text = currentProduct.Name;
            lblSelectedProductPrice.Text = currentProduct.Price.ToString("0.00") + " ₺";
            lblTotalPrice.Text = "0.00";
            lblAvailableQuantity.Text = currentProduct.Quantity.ToString();

            // Ürün resmini göster
            if (!string.IsNullOrEmpty(currentProduct.Image) && File.Exists(currentProduct.Image))
                picSelectedProduct.Image = Image.FromFile(currentProduct.Image);
            else
                picSelectedProduct.Image = null;

            selectedQuantity = 0;
            lblSelectedQuantity.Text = "0";

            UpdateButtons();
        }

        // Miktarı artır butonu
        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            if (currentProduct == null) return;

            if (selectedQuantity < currentProduct.Quantity)
            {
                selectedQuantity++;
                lblSelectedQuantity.Text = selectedQuantity.ToString();
                lblTotalPrice.Text = (selectedQuantity * currentProduct.Price).ToString();
            }

            UpdateButtons();
        }

        // Miktarı azalt butonu
        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (currentProduct == null) return;

            if (selectedQuantity > 0)
            {
                selectedQuantity--;
                lblSelectedQuantity.Text = selectedQuantity.ToString();
                lblTotalPrice.Text = (selectedQuantity * currentProduct.Price).ToString();

            }

            UpdateButtons();
        }

        // Ürünü faturaya ekle
        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            // Önce müşteriyi kontrol et
            if (CustomerID == 0)
            {
                MessageBox.Show("Lütfen önce müşteri seçiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            if (currentProduct == null || selectedQuantity == 0) return;

            decimal price = currentProduct.Price;
            int quantity = selectedQuantity;
            decimal totalPrice = price * quantity;

            // Kategori adını getir
            string categoryName = "";
            var category = StoreManagerDB.CategoriesTabels
                            .FirstOrDefault(c => c.Id == currentProduct.CategoryId);
            if (category != null)
                categoryName = category.CategoryName;

            dataGridView1.Rows.Add(
                currentProduct.Id,
                currentProduct.Name,
                price,
                quantity,
                categoryName,
                totalPrice
            );

            // Sıfırla
            selectedQuantity = 0;
            lblSelectedQuantity.Text = "0";
            UpdateButtons();
            UpdateTotal();
        }

        //Toplamı güncelle
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

        // İndirimi uygula
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

        // İndirim uygula butonu
        private void btnPerformDiscount_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TotalBeforeDiscount.Text, out decimal total))
                return;

            ApplyDiscount(total);
        }

        // Üründen faturayı sil
        private void btnDeleteProductFromBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeleteID.Text.Trim()) ||
                !int.TryParse(txtDeleteID.Text.Trim(), out int productIdToDelete))
            {
                MessageBox.Show("Geçerli bir ID giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.Parse(row.Cells["clProductID"].Value.ToString()) == productIdToDelete)
                {
                    dataGridView1.Rows.Remove(row);
                    txtDeleteID.Clear();
                    UpdateTotal();
                    MessageBox.Show("Ürün faturadan kaldırıldı ✅",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Bu ID ile ürün faturada bulunamadı!",
                            "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Müşteri ara
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inputText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Telefon NO veya Mail Giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database.CustomersTabel customer = StoreManagerDB.CustomersTabels
                .FirstOrDefault(c => c.PhoneNumber == inputText || c.Email == inputText);

            if (customer != null)
            {
                CustomerID = customer.Id;
                lblCustomerMail.Text = customer.Email;
                lblCustomerName.Text = customer.Name + " " + customer.LastName;
                lblCustomerPhone.Text = customer.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Kategoriye göre filtrele
        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CategoriesList.DataSource = StoreManagerDB.CategoriesTabels.ToList();
            CategoriesList.DisplayMember = "CategoryName";
            CategoriesList.ValueMember = "Id";
            if (CategoriesList.SelectedValue == null) return;

            int categoryId = int.Parse(CategoriesList.SelectedValue.ToString());

            var products = StoreManagerDB.ProductsTabels
                            .Where(x => x.CategoryId == categoryId)
                            .ToList();

            LoadProductsToListView(products);

            // Mevcut ürünü sıfırla
            //currentProduct = null;
            //selectedQuantity = 0;
            //lblSelectedQuantity.Text = "0";
            //DisableProductButtons();
        }

        // Yenile butonu (listeyi güncelle)
        private void btnRefrehListView_Click(object sender, EventArgs e)
        {
            LoadAllProducts();
            //currentProduct = null;
            //selectedQuantity = 0;
            //lblSelectedQuantity.Text = "0";
           // DisableProductButtons();
        }

        // Ürün önizlemesini iptal et
        private void btnCancelProductReview_Click(object sender, EventArgs e)
        {
            currentProduct = null;
            selectedQuantity = 0;
            lblSelectedProducName.Text = "";
            lblSelectedProductPrice.Text = "";
            lblSelectedQuantity.Text = "";
            lblAvailableQuantity.Text = "";
            lblTotalPrice.Text = "";
            picSelectedProduct.Image = null;
            DisableProductButtons();
        }

        // Faturayı kaydet
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (CustomerID == 0)
            {
                MessageBox.Show("Lütfen önce müşteri seçiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (dataGridView1.Rows.Count == 0 ||
                (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Faturaya en az bir ürün ekleyiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            decimal.TryParse(TotalBeforeDiscount.Text, out decimal total);
            decimal.TryParse(TotalAfterDiscount.Text, out decimal totalAfterDiscount);
            decimal.TryParse(txtDiscount.Text.Trim(), out decimal discount);

            // Satış faturası oluştur
            SalesBillTabel salesBill = new SalesBillTabel();
            salesBill.CustomerId = CustomerID;
            salesBill.UserId = LoginScreen.CurrentUserInfo.UserID;
            salesBill.Date = BillDate.Value;
            salesBill.Total = total;
            salesBill.Discount = discount;
            salesBill.TotalAfterDiscount = totalAfterDiscount;

            // Fatura detaylarını oluştur
            List<SalesBillDetailsTabel> details = new List<SalesBillDetailsTabel>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                decimal rowPrice = decimal.Parse(row.Cells["clProductPrice"].Value.ToString());
                int rowQuantity = int.Parse(row.Cells["clQuantity"].Value.ToString());
                decimal rowTotal = decimal.Parse(row.Cells["clTotalPrice"].Value.ToString());

                details.Add(new SalesBillDetailsTabel
                {
                    ProductID = int.Parse(row.Cells["clProductID"].Value.ToString()),
                    Price = rowPrice,
                    Quantity = rowQuantity,
                    TotalPrice = rowTotal
                });

                // Veritabanında ürün miktarını güncelle
                int productId = int.Parse(row.Cells["clProductID"].Value.ToString());
                ProductsTabel product = StoreManagerDB.ProductsTabels
                                        .FirstOrDefault(p => p.Id == productId);
                if (product != null)
                    product.Quantity -= rowQuantity;
            }

            // Detayları faturaya bağla
            salesBill.SalesBillDetailsTabels = details;

            StoreManagerDB.SalesBillTabels.Add(salesBill);
            StoreManagerDB.SaveChanges();

            MessageBox.Show("Fatura başarıyla kaydedildi ✅",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearAll();
        }

        // Faturayı iptal et
        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Faturayı iptal etmek istediğinize emin misiniz?",
                    "İptal Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.No) return;
            }

            ClearAll();
        }
        private void ClearAll()
        {
            CustomerID = 0;
            currentProduct = null;
            selectedQuantity = 0;

            dataGridView1.Rows.Clear();

            lblCustomerName.Text = "";
            lblCustomerPhone.Text = "";
            lblCustomerMail.Text = "";
            lblSelectedProducName.Text = "";
            lblSelectedProductPrice.Text = "";
            lblSelectedQuantity.Text = "0";
            lblAvailableQuantity.Text = "";

            TotalBeforeDiscount.Text = "0.00";
            TotalAfterDiscount.Text = "0.00";
            txtDiscount.Clear();
            txtDeleteID.Clear();
            txtSearch.Clear();
            picSelectedProduct.Image = null;

            DisableProductButtons();
            LoadAllProducts();
            txtSearch.Focus();
        }
    }
}