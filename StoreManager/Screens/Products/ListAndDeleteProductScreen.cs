using StoreManager.Classes.BusinessLogic;
using StoreManager.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManager.Screens.Products
{
    public partial class ListAndDeleteProductScreen : Form
    {
        ListAndDeleteProductService _Service = new ListAndDeleteProductService();
        public ListAndDeleteProductScreen()
        {
            InitializeComponent();
        }
        private void ListAndDeleteProductScreen_Load(object sender, EventArgs e)
        {
            CategoriesList.DisplayMember = "CategoryName";
            CategoriesList.ValueMember = "Id";
            CategoriesList.DataSource = _Service.GetAllCategories();

            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();

            var products = _Service.GetAllProducts();

            foreach (var x in products)
            {
                Image productImage = null;
                try
                {
                    string imagePath = x.Image;
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        using (Image original = Image.FromFile(imagePath))
                        {
                            productImage = new Bitmap(original, new Size(60, 60));
                        }
                    }
                    else
                    {
                        productImage = new Bitmap(60, 60);
                    }
                }
                catch
                {
                    productImage = new Bitmap(60, 60);
                }

                dataGridView1.Rows.Add(
                    x.Id,
                    x.Code,
                    x.Name,
                    x.CategoriesTabel.CategoryName,
                    x.Price,
                    x.Quantity,
                    productImage
                );
            }
        }
        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriesList.SelectedValue == null) return;

            int categoryId = (int)CategoriesList.SelectedValue;

            dataGridView1.Rows.Clear();

            var products = _Service.GetProductsByCategory(categoryId);

            foreach (var x in products)
            {
                Image productImage = null;
                try
                {
                    string imagePath = x.Image;
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        using (Image original = Image.FromFile(imagePath))
                        {
                            productImage = new Bitmap(original, new Size(60, 60));
                        }
                    }
                    else
                    {
                        productImage = new Bitmap(60, 60);
                    }
                }
                catch
                {
                    productImage = new Bitmap(60, 60);
                }

                dataGridView1.Rows.Add(
                    x.Id,
                    x.Code,
                    x.Name,
                    x.CategoriesTabel.CategoryName,
                    x.Price,
                    x.Quantity,
                    productImage
                );
            }
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txProduct_IDToSearch.Text.Trim()))
            {
                MessageBox.Show("Ürün aramak için ID veya Kod girmelisiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string search = txProduct_IDToSearch.Text.Trim();

            var product = _Service.SearchProduct(search);

            if (product == null)
            {
                MessageBox.Show($"'{search}' ile eşleşen ürün bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Clear();

            Image productImage = null;
            try
            {
                string imagePath = product.Image;
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    using (Image original = Image.FromFile(imagePath))
                    {
                        productImage = new Bitmap(original, new Size(60, 60));
                    }
                }
                else
                {
                    productImage = new Bitmap(60, 60);
                }
            }
            catch
            {
                productImage = new Bitmap(60, 60);
            }

            dataGridView1.Rows.Add(
                product.Id,
                product.Code,
                product.Name,
                product.CategoriesTabel.CategoryName,
                product.Price,
                product.Quantity,
                productImage
            );
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduct_IDToDelete.Text.Trim()))
            {
                MessageBox.Show("Ürün silmek için ID girmelisiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProduct_IDToDelete.Text.Trim(), out int productId))
            {
                MessageBox.Show("Geçerli bir ID giriniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = _Service.GetProductById(productId);

            if (product == null)
            {
                MessageBox.Show($"'{productId}' ID'li ürün bulunamadı!",
                                "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"'{product.Name}' ürününü silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            _Service.DeleteProductPurchaseDetails(productId);
            _Service.DeleteProduct(product);

            MessageBox.Show("Ürün başarıyla silindi ✅",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtProduct_IDToDelete.Clear();
            txProduct_IDToSearch.Clear();
            LoadData();
        }
        private void btnRefreshProductList_Click(object sender, EventArgs e)
        {
            txtProduct_IDToDelete.Clear();
            txProduct_IDToSearch.Clear();
            LoadData();
        }
    }
}