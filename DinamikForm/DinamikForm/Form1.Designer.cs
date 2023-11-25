namespace DinamikForm
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
            this.ItemTypeCb = new System.Windows.Forms.ComboBox();
            this.ItemTypeLbl = new System.Windows.Forms.Label();
            this.TextLbl = new System.Windows.Forms.Label();
            this.TextTxt = new System.Windows.Forms.TextBox();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.WidthNud = new System.Windows.Forms.NumericUpDown();
            this.HeigthNud = new System.Windows.Forms.NumericUpDown();
            this.HeigthLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.yPosNud = new System.Windows.Forms.NumericUpDown();
            this.yPosLbl = new System.Windows.Forms.Label();
            this.xPosNud = new System.Windows.Forms.NumericUpDown();
            this.xPosLbl = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ScreenPnl = new System.Windows.Forms.Panel();
            this.ScreenLbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeigthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosNud)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemTypeCb
            // 
            this.ItemTypeCb.FormattingEnabled = true;
            this.ItemTypeCb.Items.AddRange(new object[] {
            "Label",
            "Button",
            "TextBox"});
            this.ItemTypeCb.Location = new System.Drawing.Point(55, 90);
            this.ItemTypeCb.Name = "ItemTypeCb";
            this.ItemTypeCb.Size = new System.Drawing.Size(170, 28);
            this.ItemTypeCb.TabIndex = 0;
            // 
            // ItemTypeLbl
            // 
            this.ItemTypeLbl.AutoSize = true;
            this.ItemTypeLbl.Location = new System.Drawing.Point(55, 64);
            this.ItemTypeLbl.Name = "ItemTypeLbl";
            this.ItemTypeLbl.Size = new System.Drawing.Size(79, 20);
            this.ItemTypeLbl.TabIndex = 1;
            this.ItemTypeLbl.Text = "Item Type";
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(55, 139);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(39, 20);
            this.TextLbl.TabIndex = 2;
            this.TextLbl.Text = "Text";
            // 
            // TextTxt
            // 
            this.TextTxt.Location = new System.Drawing.Point(55, 162);
            this.TextTxt.Name = "TextTxt";
            this.TextTxt.Size = new System.Drawing.Size(170, 26);
            this.TextTxt.TabIndex = 3;
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(55, 268);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(50, 20);
            this.WidthLbl.TabIndex = 4;
            this.WidthLbl.Text = "Width";
            // 
            // WidthNud
            // 
            this.WidthNud.Location = new System.Drawing.Point(55, 291);
            this.WidthNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthNud.Name = "WidthNud";
            this.WidthNud.Size = new System.Drawing.Size(73, 26);
            this.WidthNud.TabIndex = 5;
            // 
            // HeigthNud
            // 
            this.HeigthNud.Location = new System.Drawing.Point(149, 291);
            this.HeigthNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HeigthNud.Name = "HeigthNud";
            this.HeigthNud.Size = new System.Drawing.Size(76, 26);
            this.HeigthNud.TabIndex = 7;
            // 
            // HeigthLbl
            // 
            this.HeigthLbl.AutoSize = true;
            this.HeigthLbl.Location = new System.Drawing.Point(149, 268);
            this.HeigthLbl.Name = "HeigthLbl";
            this.HeigthLbl.Size = new System.Drawing.Size(56, 20);
            this.HeigthLbl.TabIndex = 6;
            this.HeigthLbl.Text = "Heigth";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(55, 228);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(170, 26);
            this.NameTxt.TabIndex = 9;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(55, 205);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name";
            // 
            // yPosNud
            // 
            this.yPosNud.Location = new System.Drawing.Point(149, 370);
            this.yPosNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yPosNud.Name = "yPosNud";
            this.yPosNud.Size = new System.Drawing.Size(76, 26);
            this.yPosNud.TabIndex = 13;
            // 
            // yPosLbl
            // 
            this.yPosLbl.AutoSize = true;
            this.yPosLbl.Location = new System.Drawing.Point(149, 347);
            this.yPosLbl.Name = "yPosLbl";
            this.yPosLbl.Size = new System.Drawing.Size(51, 20);
            this.yPosLbl.TabIndex = 12;
            this.yPosLbl.Text = "y Pos.";
            // 
            // xPosNud
            // 
            this.xPosNud.Location = new System.Drawing.Point(55, 370);
            this.xPosNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xPosNud.Name = "xPosNud";
            this.xPosNud.Size = new System.Drawing.Size(73, 26);
            this.xPosNud.TabIndex = 11;
            // 
            // xPosLbl
            // 
            this.xPosLbl.AutoSize = true;
            this.xPosLbl.Location = new System.Drawing.Point(55, 347);
            this.xPosLbl.Name = "xPosLbl";
            this.xPosLbl.Size = new System.Drawing.Size(51, 20);
            this.xPosLbl.TabIndex = 10;
            this.xPosLbl.Text = "x Pos.";
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(55, 416);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(170, 47);
            this.AddItemBtn.TabIndex = 14;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // ScreenPnl
            // 
            this.ScreenPnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScreenPnl.Location = new System.Drawing.Point(270, 90);
            this.ScreenPnl.Name = "ScreenPnl";
            this.ScreenPnl.Size = new System.Drawing.Size(737, 373);
            this.ScreenPnl.TabIndex = 15;
            // 
            // ScreenLbl
            // 
            this.ScreenLbl.AutoSize = true;
            this.ScreenLbl.Location = new System.Drawing.Point(266, 64);
            this.ScreenLbl.Name = "ScreenLbl";
            this.ScreenLbl.Size = new System.Drawing.Size(60, 20);
            this.ScreenLbl.TabIndex = 16;
            this.ScreenLbl.Text = "Screen";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(270, 481);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(737, 37);
            this.progressBar1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 539);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ScreenLbl);
            this.Controls.Add(this.ScreenPnl);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.yPosNud);
            this.Controls.Add(this.yPosLbl);
            this.Controls.Add(this.xPosNud);
            this.Controls.Add(this.xPosLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.HeigthNud);
            this.Controls.Add(this.HeigthLbl);
            this.Controls.Add(this.WidthNud);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.TextTxt);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.ItemTypeLbl);
            this.Controls.Add(this.ItemTypeCb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WidthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeigthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemTypeCb;
        private System.Windows.Forms.Label ItemTypeLbl;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.TextBox TextTxt;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.NumericUpDown WidthNud;
        private System.Windows.Forms.NumericUpDown HeigthNud;
        private System.Windows.Forms.Label HeigthLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.NumericUpDown yPosNud;
        private System.Windows.Forms.Label yPosLbl;
        private System.Windows.Forms.NumericUpDown xPosNud;
        private System.Windows.Forms.Label xPosLbl;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Panel ScreenPnl;
        private System.Windows.Forms.Label ScreenLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

