namespace DataGridViewExample
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.IdNud = new System.Windows.Forms.NumericUpDown();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.AgeNud = new System.Windows.Forms.NumericUpDown();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.IdLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Namedgv,
            this.Surname,
            this.Age,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(997, 605);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(705, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // Namedgv
            // 
            this.Namedgv.HeaderText = "Name";
            this.Namedgv.MinimumWidth = 8;
            this.Namedgv.Name = "Namedgv";
            this.Namedgv.Width = 150;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 8;
            this.Surname.Name = "Surname";
            this.Surname.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(782, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(920, 406);
            this.dataGridView2.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(908, 524);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(130, 26);
            this.NameTxt.TabIndex = 2;
            // 
            // IdNud
            // 
            this.IdNud.Location = new System.Drawing.Point(782, 525);
            this.IdNud.Name = "IdNud";
            this.IdNud.Size = new System.Drawing.Size(120, 26);
            this.IdNud.TabIndex = 3;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(1044, 525);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(130, 26);
            this.SurnameTxt.TabIndex = 4;
            // 
            // AgeNud
            // 
            this.AgeNud.Location = new System.Drawing.Point(1180, 524);
            this.AgeNud.Name = "AgeNud";
            this.AgeNud.Size = new System.Drawing.Size(120, 26);
            this.AgeNud.TabIndex = 5;
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.StatusCb.Location = new System.Drawing.Point(1306, 522);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(121, 28);
            this.StatusCb.TabIndex = 6;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(1433, 522);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(147, 29);
            this.AddUserBtn.TabIndex = 7;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(778, 502);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(23, 20);
            this.IdLbl.TabIndex = 8;
            this.IdLbl.Text = "Id";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(904, 501);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 9;
            this.NameLbl.Text = "Name";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(1040, 501);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(74, 20);
            this.SurnameLbl.TabIndex = 10;
            this.SurnameLbl.Text = "Surname";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(1176, 501);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(38, 20);
            this.AgeLbl.TabIndex = 11;
            this.AgeLbl.Text = "Age";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(1302, 499);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(56, 20);
            this.StatusLbl.TabIndex = 12;
            this.StatusLbl.Text = "Status";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(30, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(742, 425);
            this.dataGridView3.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 482);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 264);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 1306);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.AgeNud);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.IdNud);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.NumericUpDown IdNud;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.NumericUpDown AgeNud;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

