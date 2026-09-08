namespace StoreManager.Screens.CustomerScreens
{
    partial class ManageCustomersScreen
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
            this.btnAddNewCustomer = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.btnUpdateCustomer = new Krypton.Toolkit.KryptonButton();
            this.btnListCustomers = new Krypton.Toolkit.KryptonButton();
            this.btnDeleteCustomer = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(2, 195);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(253, 37);
            this.btnAddNewCustomer.StateCommon.Border.Rounding = 15F;
            this.btnAddNewCustomer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.TabIndex = 51;
            this.btnAddNewCustomer.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNewCustomer.Values.Text = "Yeni Müşteri Ekle";
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.btnUpdateCustomer);
            this.panel1.Controls.Add(this.btnListCustomers);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnAddNewCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 632);
            this.panel1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 35);
            this.label6.TabIndex = 61;
            this.label6.Text = "_______________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 35);
            this.label4.TabIndex = 59;
            this.label4.Text = "_______________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 35);
            this.label3.TabIndex = 58;
            this.label3.Text = "Müşteri İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 60);
            this.label2.TabIndex = 57;
            this.label2.Text = "🛒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 60);
            this.label1.TabIndex = 56;
            this.label1.Text = "🏛️";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(6, 558);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(246, 62);
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 55;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Ana Sayfaya Dön";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(2, 299);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(253, 37);
            this.btnUpdateCustomer.StateCommon.Border.Rounding = 15F;
            this.btnUpdateCustomer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.TabIndex = 54;
            this.btnUpdateCustomer.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdateCustomer.Values.Text = "Müşteri Bilgileri Güncelle";
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Location = new System.Drawing.Point(2, 351);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(253, 37);
            this.btnListCustomers.StateCommon.Border.Rounding = 15F;
            this.btnListCustomers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomers.TabIndex = 53;
            this.btnListCustomers.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnListCustomers.Values.Text = "Müşteriler Listesi";
            this.btnListCustomers.Click += new System.EventHandler(this.btnListCustomers_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(2, 247);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(253, 37);
            this.btnDeleteCustomer.StateCommon.Border.Rounding = 15F;
            this.btnDeleteCustomer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.TabIndex = 52;
            this.btnDeleteCustomer.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDeleteCustomer.Values.Text = "Müşteri Sil";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // ManageCustomersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 632);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "ManageCustomersScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomersScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnAddNewCustomer;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnUpdateCustomer;
        private Krypton.Toolkit.KryptonButton btnListCustomers;
        private Krypton.Toolkit.KryptonButton btnDeleteCustomer;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}