namespace StoreManager.Screens.Products
{
    partial class ListAndDeleteProductScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clProdacutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Image = new Krypton.Toolkit.KryptonDataGridViewImageColumn();
            this.kryptonLabel20 = new Krypton.Toolkit.KryptonLabel();
            this.CategoriesList = new Krypton.Toolkit.KryptonComboBox();
            this.btnRefreshProductList = new Krypton.Toolkit.KryptonButton();
            this.btnSearchProduct = new Krypton.Toolkit.KryptonButton();
            this.txProduct_IDToSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            this.txtProduct_IDToDelete = new Krypton.Toolkit.KryptonTextBox();
            this.btnDeleteProduct = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(10, 92);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.dataGridView1);
            this.kryptonGroup1.Size = new System.Drawing.Size(1198, 523);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.SystemColors.HotTrack;
            this.kryptonGroup1.StateCommon.Border.Rounding = 30F;
            this.kryptonGroup1.TabIndex = 159;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProdacutID,
            this.clProductCode,
            this.clProductName,
            this.clCategoryName,
            this.clPrice,
            this.clQuantity,
            this.cl_Image});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 501);
            this.dataGridView1.TabIndex = 129;
            // 
            // clProdacutID
            // 
            this.clProdacutID.DataPropertyName = "clProdacutID";
            this.clProdacutID.FillWeight = 96.25671F;
            this.clProdacutID.HeaderText = "Ürün ID";
            this.clProdacutID.MinimumWidth = 6;
            this.clProdacutID.Name = "clProdacutID";
            this.clProdacutID.ReadOnly = true;
            // 
            // clProductCode
            // 
            this.clProductCode.DataPropertyName = "clProductCode";
            this.clProductCode.HeaderText = "Ürün Kodu";
            this.clProductCode.MinimumWidth = 6;
            this.clProductCode.Name = "clProductCode";
            this.clProductCode.ReadOnly = true;
            // 
            // clProductName
            // 
            this.clProductName.DataPropertyName = "clProductName";
            this.clProductName.FillWeight = 130.3608F;
            this.clProductName.HeaderText = "Ürün Adı";
            this.clProductName.MinimumWidth = 6;
            this.clProductName.Name = "clProductName";
            this.clProductName.ReadOnly = true;
            // 
            // clCategoryName
            // 
            this.clCategoryName.DataPropertyName = "clCategoryName";
            this.clCategoryName.HeaderText = "Kategori";
            this.clCategoryName.MinimumWidth = 6;
            this.clCategoryName.Name = "clCategoryName";
            this.clCategoryName.ReadOnly = true;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "clPrice";
            this.clPrice.FillWeight = 85.62753F;
            this.clPrice.HeaderText = "Fiyat";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // clQuantity
            // 
            this.clQuantity.DataPropertyName = "clQuantity";
            this.clQuantity.FillWeight = 85.62753F;
            this.clQuantity.HeaderText = "Miktar";
            this.clQuantity.MinimumWidth = 6;
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.ReadOnly = true;
            // 
            // cl_Image
            // 
            this.cl_Image.FillWeight = 116.5001F;
            this.cl_Image.HeaderText = "fotoğraf";
            this.cl_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cl_Image.MinimumWidth = 6;
            this.cl_Image.Name = "cl_Image";
            this.cl_Image.ReadOnly = true;
            this.cl_Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // kryptonLabel20
            // 
            this.kryptonLabel20.AutoSize = false;
            this.kryptonLabel20.Location = new System.Drawing.Point(663, 10);
            this.kryptonLabel20.Name = "kryptonLabel20";
            this.kryptonLabel20.Size = new System.Drawing.Size(327, 31);
            this.kryptonLabel20.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel20.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel20.TabIndex = 161;
            this.kryptonLabel20.Values.Text = "Kategori Sınıfına Göre Filtrele";
            // 
            // CategoriesList
            // 
            this.CategoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesList.DropDownWidth = 251;
            this.CategoriesList.Location = new System.Drawing.Point(674, 47);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(261, 39);
            this.CategoriesList.StateCommon.ComboBox.Border.Rounding = 15F;
            this.CategoriesList.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesList.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CategoriesList.TabIndex = 160;
            this.CategoriesList.SelectedIndexChanged += new System.EventHandler(this.CategoriesList_SelectedIndexChanged);
            // 
            // btnRefreshProductList
            // 
            this.btnRefreshProductList.Location = new System.Drawing.Point(1030, 47);
            this.btnRefreshProductList.Name = "btnRefreshProductList";
            this.btnRefreshProductList.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange;
            this.btnRefreshProductList.Size = new System.Drawing.Size(167, 37);
            this.btnRefreshProductList.StateCommon.Back.Color1 = System.Drawing.Color.Orange;
            this.btnRefreshProductList.StateCommon.Border.Rounding = 15F;
            this.btnRefreshProductList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProductList.StateDisabled.Back.Color1 = System.Drawing.Color.Orange;
            this.btnRefreshProductList.StateNormal.Back.Color1 = System.Drawing.Color.Orange;
            this.btnRefreshProductList.StatePressed.Back.Color1 = System.Drawing.Color.Orange;
            this.btnRefreshProductList.StateTracking.Back.Color1 = System.Drawing.Color.Orange;
            this.btnRefreshProductList.TabIndex = 170;
            this.btnRefreshProductList.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefreshProductList.Values.Text = "Listeyi Güncelle";
            this.btnRefreshProductList.Click += new System.EventHandler(this.btnRefreshProductList_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(521, 47);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearchProduct.Size = new System.Drawing.Size(83, 37);
            this.btnSearchProduct.StateCommon.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearchProduct.StateCommon.Border.Rounding = 15F;
            this.btnSearchProduct.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.StateDisabled.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearchProduct.StateNormal.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearchProduct.StatePressed.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearchProduct.StateTracking.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearchProduct.TabIndex = 169;
            this.btnSearchProduct.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearchProduct.Values.Text = "Ara";
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txProduct_IDToSearch
            // 
            this.txProduct_IDToSearch.Location = new System.Drawing.Point(303, 47);
            this.txProduct_IDToSearch.Multiline = true;
            this.txProduct_IDToSearch.Name = "txProduct_IDToSearch";
            this.txProduct_IDToSearch.Size = new System.Drawing.Size(212, 37);
            this.txProduct_IDToSearch.StateCommon.Border.Rounding = 10F;
            this.txProduct_IDToSearch.TabIndex = 168;
            this.txProduct_IDToSearch.WordWrap = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(290, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(352, 31);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 167;
            this.kryptonLabel3.Values.Text = "Ürün Bulmak İçin ID Veya Kod Giriniz";
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.AutoSize = false;
            this.kryptonLabel22.Location = new System.Drawing.Point(21, 12);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(253, 31);
            this.kryptonLabel22.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel22.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel22.TabIndex = 166;
            this.kryptonLabel22.Values.Text = "Ürün Silmek İçin ID Giriniz";
            // 
            // txtProduct_IDToDelete
            // 
            this.txtProduct_IDToDelete.Location = new System.Drawing.Point(21, 49);
            this.txtProduct_IDToDelete.Multiline = true;
            this.txtProduct_IDToDelete.Name = "txtProduct_IDToDelete";
            this.txtProduct_IDToDelete.Size = new System.Drawing.Size(139, 37);
            this.txtProduct_IDToDelete.StateCommon.Border.Rounding = 10F;
            this.txtProduct_IDToDelete.TabIndex = 165;
            this.txtProduct_IDToDelete.WordWrap = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(166, 49);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange;
            this.btnDeleteProduct.Size = new System.Drawing.Size(83, 37);
            this.btnDeleteProduct.StateCommon.Back.Color1 = System.Drawing.Color.Orange;
            this.btnDeleteProduct.StateCommon.Border.Rounding = 15F;
            this.btnDeleteProduct.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.StateDisabled.Back.Color1 = System.Drawing.Color.Orange;
            this.btnDeleteProduct.StateNormal.Back.Color1 = System.Drawing.Color.Orange;
            this.btnDeleteProduct.StatePressed.Back.Color1 = System.Drawing.Color.Orange;
            this.btnDeleteProduct.StateTracking.Back.Color1 = System.Drawing.Color.Orange;
            this.btnDeleteProduct.TabIndex = 164;
            this.btnDeleteProduct.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDeleteProduct.Values.Text = "Sil";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // ListAndDeleteProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 627);
            this.Controls.Add(this.btnRefreshProductList);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txProduct_IDToSearch);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel22);
            this.Controls.Add(this.txtProduct_IDToDelete);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.kryptonLabel20);
            this.Controls.Add(this.CategoriesList);
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "ListAndDeleteProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAndDeleteProductScreen";
            this.Load += new System.EventHandler(this.ListAndDeleteProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Krypton.Toolkit.KryptonComboBox CategoriesList;
        private Krypton.Toolkit.KryptonButton btnRefreshProductList;
        private Krypton.Toolkit.KryptonButton btnSearchProduct;
        private Krypton.Toolkit.KryptonTextBox txProduct_IDToSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonTextBox txtProduct_IDToDelete;
        private Krypton.Toolkit.KryptonButton btnDeleteProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProdacutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private Krypton.Toolkit.KryptonDataGridViewImageColumn cl_Image;
    }
}