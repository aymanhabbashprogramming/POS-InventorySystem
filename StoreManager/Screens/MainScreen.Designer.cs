namespace StoreManager.Screens
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProducts = new Krypton.Toolkit.KryptonButton();
            this.btnSuppliers = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomers = new Krypton.Toolkit.KryptonButton();
            this.btnUsers = new Krypton.Toolkit.KryptonButton();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.btnUsersList = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalUsers = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalProduct = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalCustumer = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup4 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalSuppliers = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).BeginInit();
            this.kryptonGroup4.Panel.SuspendLayout();
            this.kryptonGroup4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 545);
            this.panel1.TabIndex = 54;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(3, 347);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(253, 37);
            this.btnProducts.StateCommon.Border.Rounding = 15F;
            this.btnProducts.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.TabIndex = 55;
            this.btnProducts.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnProducts.Values.Text = "Ürün Ve Faturalar";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(3, 286);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(253, 37);
            this.btnSuppliers.StateCommon.Border.Rounding = 15F;
            this.btnSuppliers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.TabIndex = 59;
            this.btnSuppliers.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSuppliers.Values.Text = "Tedarikçiler";
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ana Sayfa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 60);
            this.label1.TabIndex = 57;
            this.label1.Text = "🏛️";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(3, 225);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(253, 37);
            this.btnCustomers.StateCommon.Border.Rounding = 15F;
            this.btnCustomers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.TabIndex = 52;
            this.btnCustomers.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCustomers.Values.Text = "Müşteriler";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(3, 164);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(253, 37);
            this.btnUsers.StateCommon.Border.Rounding = 15F;
            this.btnUsers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.TabIndex = 51;
            this.btnUsers.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUsers.Values.Text = "Kullanıcılar";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentUser.Location = new System.Drawing.Point(544, 12);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(360, 38);
            this.lblCurrentUser.TabIndex = 60;
            this.lblCurrentUser.Text = "Current User";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.kryptonGroup1.Location = new System.Drawing.Point(265, 75);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.btnUsersList);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroup1.Panel.Controls.Add(this.lblTotalUsers);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroup1.Size = new System.Drawing.Size(372, 216);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 64;
            // 
            // btnUsersList
            // 
            this.btnUsersList.Location = new System.Drawing.Point(8, 156);
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.OverrideDefault.Back.Color1 = System.Drawing.Color.Lime;
            this.btnUsersList.Size = new System.Drawing.Size(341, 37);
            this.btnUsersList.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnUsersList.StateCommon.Border.Rounding = 15F;
            this.btnUsersList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersList.TabIndex = 60;
            this.btnUsersList.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUsersList.Values.Text = "Kullanıcıları Görüntüle";
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.AutoSize = false;
            this.kryptonLabel6.Location = new System.Drawing.Point(10, 107);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(175, 33);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "Toplam Kullanıcı : ";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = false;
            this.lblTotalUsers.Location = new System.Drawing.Point(191, 107);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(141, 33);
            this.lblTotalUsers.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.TabIndex = 1;
            this.lblTotalUsers.Values.Text = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 62);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "👥";
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.kryptonGroup2.Location = new System.Drawing.Point(655, 75);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroup2.Panel.Controls.Add(this.lblTotalProduct);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroup2.Size = new System.Drawing.Size(372, 216);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 65;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(7, 156);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.Peru;
            this.kryptonButton1.Size = new System.Drawing.Size(341, 37);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Peru;
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 61;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Ürünleri Görüntüle";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 107);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(152, 33);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Toplam Ürün : ";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = false;
            this.lblTotalProduct.Location = new System.Drawing.Point(161, 107);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(141, 33);
            this.lblTotalProduct.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduct.TabIndex = 3;
            this.lblTotalProduct.Values.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 19);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 62);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Peru;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "📦";
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.kryptonGroup3.Location = new System.Drawing.Point(265, 297);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroup3.Panel.Controls.Add(this.lblTotalCustumer);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup3.Size = new System.Drawing.Size(372, 216);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup3.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup3.TabIndex = 66;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(8, 153);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonButton2.Size = new System.Drawing.Size(341, 37);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonButton2.StateCommon.Border.Rounding = 15F;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 61;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "Müşterileri Görüntüle";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(10, 98);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(175, 33);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Toplam Müşteri : ";
            // 
            // lblTotalCustumer
            // 
            this.lblTotalCustumer.AutoSize = false;
            this.lblTotalCustumer.Location = new System.Drawing.Point(191, 98);
            this.lblTotalCustumer.Name = "lblTotalCustumer";
            this.lblTotalCustumer.Size = new System.Drawing.Size(141, 33);
            this.lblTotalCustumer.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustumer.TabIndex = 3;
            this.lblTotalCustumer.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(8, 19);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(90, 62);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "🛒";
            // 
            // kryptonGroup4
            // 
            this.kryptonGroup4.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.kryptonGroup4.Location = new System.Drawing.Point(655, 297);
            // 
            // kryptonGroup4.Panel
            // 
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonButton3);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonGroup4.Panel.Controls.Add(this.lblTotalSuppliers);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonGroup4.Size = new System.Drawing.Size(372, 216);
            this.kryptonGroup4.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup4.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup4.TabIndex = 67;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(7, 153);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(341, 37);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButton3.StateCommon.Border.Rounding = 15F;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 62;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Text = "Tedarikçileri Görüntüle";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.AutoSize = false;
            this.kryptonLabel8.Location = new System.Drawing.Point(7, 98);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(175, 33);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 64;
            this.kryptonLabel8.Values.Text = "Toplam Tedarikçi : ";
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = false;
            this.lblTotalSuppliers.Location = new System.Drawing.Point(188, 98);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(141, 33);
            this.lblTotalSuppliers.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuppliers.TabIndex = 63;
            this.lblTotalSuppliers.Values.Text = "";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(7, 2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(90, 78);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 62;
            this.kryptonLabel7.Values.Text = "🚚";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(448, 0);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(90, 62);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Orange;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 61;
            this.kryptonLabel9.Values.Text = "👤";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 545);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonGroup4);
            this.Controls.Add(this.kryptonGroup3);
            this.Controls.Add(this.kryptonGroup2);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            this.kryptonGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            this.kryptonGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).EndInit();
            this.kryptonGroup4.Panel.ResumeLayout(false);
            this.kryptonGroup4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).EndInit();
            this.kryptonGroup4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnUsers;
        private Krypton.Toolkit.KryptonButton btnCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton btnSuppliers;
        private Krypton.Toolkit.KryptonButton btnProducts;
        private System.Windows.Forms.Label lblCurrentUser;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnUsersList;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel lblTotalUsers;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private Krypton.Toolkit.KryptonGroup kryptonGroup4;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel lblTotalProduct;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lblTotalCustumer;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel lblTotalSuppliers;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
    }
}