namespace ListBoxComboBoxExample
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductListLb = new System.Windows.Forms.ListBox();
            this.ProductListLbl = new System.Windows.Forms.Label();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.MoveProductListCb = new System.Windows.Forms.ComboBox();
            this.MoveProductLbl = new System.Windows.Forms.Label();
            this.MoveProductBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sayiLbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.sayi2Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(193, 125);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(139, 26);
            this.ProductNameTxt.TabIndex = 0;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(193, 99);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(110, 20);
            this.ProductNameLbl.TabIndex = 1;
            this.ProductNameLbl.Text = "Product Name";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(193, 158);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(139, 34);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductListLb
            // 
            this.ProductListLb.FormattingEnabled = true;
            this.ProductListLb.ItemHeight = 20;
            this.ProductListLb.Location = new System.Drawing.Point(356, 125);
            this.ProductListLb.Name = "ProductListLb";
            this.ProductListLb.Size = new System.Drawing.Size(240, 144);
            this.ProductListLb.TabIndex = 3;
            // 
            // ProductListLbl
            // 
            this.ProductListLbl.AutoSize = true;
            this.ProductListLbl.Location = new System.Drawing.Point(356, 99);
            this.ProductListLbl.Name = "ProductListLbl";
            this.ProductListLbl.Size = new System.Drawing.Size(93, 20);
            this.ProductListLbl.TabIndex = 4;
            this.ProductListLbl.Text = "Product List";
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(356, 276);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(102, 33);
            this.ClearAllBtn.TabIndex = 5;
            this.ClearAllBtn.Text = "Clear All";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.Location = new System.Drawing.Point(464, 276);
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(132, 33);
            this.RemoveItemBtn.TabIndex = 6;
            this.RemoveItemBtn.Text = "Remove Item";
            this.RemoveItemBtn.UseVisualStyleBackColor = true;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // MoveProductListCb
            // 
            this.MoveProductListCb.FormattingEnabled = true;
            this.MoveProductListCb.Location = new System.Drawing.Point(639, 125);
            this.MoveProductListCb.Name = "MoveProductListCb";
            this.MoveProductListCb.Size = new System.Drawing.Size(167, 28);
            this.MoveProductListCb.TabIndex = 7;
            // 
            // MoveProductLbl
            // 
            this.MoveProductLbl.AutoSize = true;
            this.MoveProductLbl.Location = new System.Drawing.Point(639, 99);
            this.MoveProductLbl.Name = "MoveProductLbl";
            this.MoveProductLbl.Size = new System.Drawing.Size(106, 20);
            this.MoveProductLbl.TabIndex = 8;
            this.MoveProductLbl.Text = "Move Product";
            // 
            // MoveProductBtn
            // 
            this.MoveProductBtn.Location = new System.Drawing.Point(356, 325);
            this.MoveProductBtn.Name = "MoveProductBtn";
            this.MoveProductBtn.Size = new System.Drawing.Size(240, 46);
            this.MoveProductBtn.TabIndex = 9;
            this.MoveProductBtn.Text = "Move Product";
            this.MoveProductBtn.UseVisualStyleBackColor = true;
            this.MoveProductBtn.Click += new System.EventHandler(this.MoveProductBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sayiLbl
            // 
            this.sayiLbl.AutoSize = true;
            this.sayiLbl.Location = new System.Drawing.Point(693, 387);
            this.sayiLbl.Name = "sayiLbl";
            this.sayiLbl.Size = new System.Drawing.Size(18, 20);
            this.sayiLbl.TabIndex = 10;
            this.sayiLbl.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // sayi2Lbl
            // 
            this.sayi2Lbl.AutoSize = true;
            this.sayi2Lbl.Location = new System.Drawing.Point(797, 387);
            this.sayi2Lbl.Name = "sayi2Lbl";
            this.sayi2Lbl.Size = new System.Drawing.Size(18, 20);
            this.sayi2Lbl.TabIndex = 11;
            this.sayi2Lbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 507);
            this.Controls.Add(this.sayi2Lbl);
            this.Controls.Add(this.sayiLbl);
            this.Controls.Add(this.MoveProductBtn);
            this.Controls.Add(this.MoveProductLbl);
            this.Controls.Add(this.MoveProductListCb);
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.ProductListLbl);
            this.Controls.Add(this.ProductListLb);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.ProductNameTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.ListBox ProductListLb;
        private System.Windows.Forms.Label ProductListLbl;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button RemoveItemBtn;
        private System.Windows.Forms.ComboBox MoveProductListCb;
        private System.Windows.Forms.Label MoveProductLbl;
        private System.Windows.Forms.Button MoveProductBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sayiLbl;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label sayi2Lbl;
    }
}

