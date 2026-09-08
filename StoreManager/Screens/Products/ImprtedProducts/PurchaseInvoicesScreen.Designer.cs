namespace StoreManager.Screens.Products.ImprtedProducts
{
    partial class PurchaseInvoicesScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefreshBillList = new Krypton.Toolkit.KryptonButton();
            this.btnSearchBill = new Krypton.Toolkit.KryptonButton();
            this.txtBill_IDToSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            this.txtBill_IDToDelete = new Krypton.Toolkit.KryptonTextBox();
            this.btnDeleteBill = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clProdacutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Image = new Krypton.Toolkit.KryptonDataGridViewImageColumn();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clBill_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalBeforeDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalAfterDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefreshBillList
            // 
            this.btnRefreshBillList.Location = new System.Drawing.Point(1032, 53);
            this.btnRefreshBillList.Name = "btnRefreshBillList";
            this.btnRefreshBillList.OverrideDefault.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRefreshBillList.Size = new System.Drawing.Size(166, 37);
            this.btnRefreshBillList.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRefreshBillList.StateCommon.Border.Rounding = 15F;
            this.btnRefreshBillList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBillList.StateDisabled.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRefreshBillList.StateNormal.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRefreshBillList.StatePressed.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRefreshBillList.StateTracking.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnRefreshBillList.TabIndex = 163;
            this.btnRefreshBillList.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefreshBillList.Values.Text = "Listeyi Güncelle";
            this.btnRefreshBillList.Click += new System.EventHandler(this.btnRefreshBillList_Click);
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Location = new System.Drawing.Point(878, 53);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.OverrideDefault.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchBill.Size = new System.Drawing.Size(70, 37);
            this.btnSearchBill.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchBill.StateCommon.Border.Rounding = 15F;
            this.btnSearchBill.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.StateDisabled.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchBill.StateNormal.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchBill.StatePressed.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchBill.StateTracking.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchBill.TabIndex = 162;
            this.btnSearchBill.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearchBill.Values.Text = "Ara";
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // txtBill_IDToSearch
            // 
            this.txtBill_IDToSearch.Location = new System.Drawing.Point(798, 53);
            this.txtBill_IDToSearch.Multiline = true;
            this.txtBill_IDToSearch.Name = "txtBill_IDToSearch";
            this.txtBill_IDToSearch.Size = new System.Drawing.Size(74, 37);
            this.txtBill_IDToSearch.StateCommon.Border.Rounding = 10F;
            this.txtBill_IDToSearch.TabIndex = 161;
            this.txtBill_IDToSearch.WordWrap = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(528, 56);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(264, 31);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 160;
            this.kryptonLabel3.Values.Text = "Fatura Bulmak İçin ID Giriniz";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(22, 387);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(197, 36);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.TabIndex = 159;
            this.kryptonLabel2.Values.Text = "Fatura Detayları";
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.AutoSize = false;
            this.kryptonLabel22.Location = new System.Drawing.Point(24, 56);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(253, 31);
            this.kryptonLabel22.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel22.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel22.TabIndex = 157;
            this.kryptonLabel22.Values.Text = "Fatura Silmek İçin ID Giriniz";
            // 
            // txtBill_IDToDelete
            // 
            this.txtBill_IDToDelete.Location = new System.Drawing.Point(283, 53);
            this.txtBill_IDToDelete.Multiline = true;
            this.txtBill_IDToDelete.Name = "txtBill_IDToDelete";
            this.txtBill_IDToDelete.Size = new System.Drawing.Size(74, 37);
            this.txtBill_IDToDelete.StateCommon.Border.Rounding = 10F;
            this.txtBill_IDToDelete.TabIndex = 156;
            this.txtBill_IDToDelete.WordWrap = false;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Location = new System.Drawing.Point(363, 53);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.OverrideDefault.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBill.Size = new System.Drawing.Size(83, 37);
            this.btnDeleteBill.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBill.StateCommon.Border.Rounding = 15F;
            this.btnDeleteBill.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.StateDisabled.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBill.StateNormal.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBill.StatePressed.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBill.StateTracking.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBill.TabIndex = 155;
            this.btnDeleteBill.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDeleteBill.Values.Text = "Sil";
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(11, 429);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.dataGridView2);
            this.kryptonGroup1.Size = new System.Drawing.Size(1198, 408);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonGroup1.StateCommon.Border.Rounding = 30F;
            this.kryptonGroup1.TabIndex = 158;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProdacutID,
            this.clProductName,
            this.clPrice,
            this.clQuantity,
            this.clTotal,
            this.cl_Image});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1176, 386);
            this.dataGridView2.TabIndex = 129;
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
            // clProductName
            // 
            this.clProductName.DataPropertyName = "clProductName";
            this.clProductName.FillWeight = 130.3608F;
            this.clProductName.HeaderText = "Ürün Adı";
            this.clProductName.MinimumWidth = 6;
            this.clProductName.Name = "clProductName";
            this.clProductName.ReadOnly = true;
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
            // clTotal
            // 
            this.clTotal.DataPropertyName = "clTotal";
            this.clTotal.FillWeight = 85.62753F;
            this.clTotal.HeaderText = "Toplam";
            this.clTotal.MinimumWidth = 6;
            this.clTotal.Name = "clTotal";
            this.clTotal.ReadOnly = true;
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(505, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(202, 36);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.TabIndex = 154;
            this.kryptonLabel1.Values.Text = "İthalat Faturaları";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBill_ID,
            this.clSupplierName,
            this.clUserFirstName,
            this.clDate,
            this.clDiscount,
            this.clTotalBeforeDiscount,
            this.clTotalAfterDiscount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 260);
            this.dataGridView1.TabIndex = 129;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clBill_ID
            // 
            this.clBill_ID.DataPropertyName = "clBill_ID";
            this.clBill_ID.FillWeight = 66.26429F;
            this.clBill_ID.HeaderText = "Fatura Id";
            this.clBill_ID.MinimumWidth = 6;
            this.clBill_ID.Name = "clBill_ID";
            this.clBill_ID.ReadOnly = true;
            // 
            // clSupplierName
            // 
            this.clSupplierName.DataPropertyName = "clSupplierName";
            this.clSupplierName.FillWeight = 110.6614F;
            this.clSupplierName.HeaderText = "Tedarikçi Adı";
            this.clSupplierName.MinimumWidth = 6;
            this.clSupplierName.Name = "clSupplierName";
            this.clSupplierName.ReadOnly = true;
            // 
            // clUserFirstName
            // 
            this.clUserFirstName.DataPropertyName = "clUserFirstName";
            this.clUserFirstName.FillWeight = 106.0314F;
            this.clUserFirstName.HeaderText = "Kullanıcı Adı";
            this.clUserFirstName.MinimumWidth = 6;
            this.clUserFirstName.Name = "clUserFirstName";
            this.clUserFirstName.ReadOnly = true;
            // 
            // clDate
            // 
            this.clDate.DataPropertyName = "clDate";
            this.clDate.FillWeight = 149.7326F;
            this.clDate.HeaderText = "Fatura Tarihi";
            this.clDate.MinimumWidth = 6;
            this.clDate.Name = "clDate";
            this.clDate.ReadOnly = true;
            // 
            // clDiscount
            // 
            this.clDiscount.DataPropertyName = "clDiscount";
            this.clDiscount.FillWeight = 53.38708F;
            this.clDiscount.HeaderText = "İndirm";
            this.clDiscount.MinimumWidth = 6;
            this.clDiscount.Name = "clDiscount";
            this.clDiscount.ReadOnly = true;
            // 
            // clTotalBeforeDiscount
            // 
            this.clTotalBeforeDiscount.DataPropertyName = "clTotalBeforeDiscount";
            this.clTotalBeforeDiscount.FillWeight = 103.2619F;
            this.clTotalBeforeDiscount.HeaderText = "İndirm Öncesi Toplam";
            this.clTotalBeforeDiscount.MinimumWidth = 6;
            this.clTotalBeforeDiscount.Name = "clTotalBeforeDiscount";
            this.clTotalBeforeDiscount.ReadOnly = true;
            // 
            // clTotalAfterDiscount
            // 
            this.clTotalAfterDiscount.DataPropertyName = "clTotalAfterDiscount";
            this.clTotalAfterDiscount.FillWeight = 110.6614F;
            this.clTotalAfterDiscount.HeaderText = "İndirm Sonrası Toplam";
            this.clTotalAfterDiscount.MinimumWidth = 6;
            this.clTotalAfterDiscount.Name = "clTotalAfterDiscount";
            this.clTotalAfterDiscount.ReadOnly = true;
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(11, 99);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.dataGridView1);
            this.kryptonGroup3.Size = new System.Drawing.Size(1198, 282);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonGroup3.StateCommon.Border.Rounding = 30F;
            this.kryptonGroup3.TabIndex = 153;
            // 
            // PurchaseInvoicesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 845);
            this.Controls.Add(this.btnRefreshBillList);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.txtBill_IDToSearch);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel22);
            this.Controls.Add(this.txtBill_IDToDelete);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonGroup3);
            this.Name = "PurchaseInvoicesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseInvoicesScreen";
            this.Load += new System.EventHandler(this.PurchaseInvoicesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnRefreshBillList;
        private Krypton.Toolkit.KryptonButton btnSearchBill;
        private Krypton.Toolkit.KryptonTextBox txtBill_IDToSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonTextBox txtBill_IDToDelete;
        private Krypton.Toolkit.KryptonButton btnDeleteBill;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProdacutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private Krypton.Toolkit.KryptonDataGridViewImageColumn cl_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBill_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalBeforeDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalAfterDiscount;
    }
}