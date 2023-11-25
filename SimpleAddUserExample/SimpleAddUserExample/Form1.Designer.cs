namespace SimpleAddUserExample
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.UserListLb = new System.Windows.Forms.ListBox();
            this.UserListLbl = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.HighRb = new System.Windows.Forms.RadioButton();
            this.PrimaryRb = new System.Windows.Forms.RadioButton();
            this.UniversityRb = new System.Windows.Forms.RadioButton();
            this.GanderGb = new System.Windows.Forms.GroupBox();
            this.ErkekRb = new System.Windows.Forms.RadioButton();
            this.KadinRb = new System.Windows.Forms.RadioButton();
            this.SchoolGb = new System.Windows.Forms.GroupBox();
            this.HobbiesGb = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.GanderGb.SuspendLayout();
            this.SchoolGb.SuspendLayout();
            this.HobbiesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(93, 79);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(97, 102);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 26);
            this.NameTxt.TabIndex = 1;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(97, 161);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(100, 26);
            this.SurnameTxt.TabIndex = 3;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(93, 138);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(74, 20);
            this.SurnameLbl.TabIndex = 2;
            this.SurnameLbl.Text = "Surname";
            // 
            // UserListLb
            // 
            this.UserListLb.FormattingEnabled = true;
            this.UserListLb.ItemHeight = 20;
            this.UserListLb.Location = new System.Drawing.Point(299, 102);
            this.UserListLb.Name = "UserListLb";
            this.UserListLb.Size = new System.Drawing.Size(705, 184);
            this.UserListLb.TabIndex = 7;
            // 
            // UserListLbl
            // 
            this.UserListLbl.AutoSize = true;
            this.UserListLbl.Location = new System.Drawing.Point(295, 79);
            this.UserListLbl.Name = "UserListLbl";
            this.UserListLbl.Size = new System.Drawing.Size(72, 20);
            this.UserListLbl.TabIndex = 8;
            this.UserListLbl.Text = "User List";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(97, 602);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(100, 31);
            this.AddUserBtn.TabIndex = 9;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // HighRb
            // 
            this.HighRb.AutoSize = true;
            this.HighRb.Location = new System.Drawing.Point(14, 64);
            this.HighRb.Name = "HighRb";
            this.HighRb.Size = new System.Drawing.Size(67, 24);
            this.HighRb.TabIndex = 11;
            this.HighRb.Text = "High";
            this.HighRb.UseVisualStyleBackColor = true;
            // 
            // PrimaryRb
            // 
            this.PrimaryRb.AutoSize = true;
            this.PrimaryRb.Checked = true;
            this.PrimaryRb.Location = new System.Drawing.Point(14, 34);
            this.PrimaryRb.Name = "PrimaryRb";
            this.PrimaryRb.Size = new System.Drawing.Size(86, 24);
            this.PrimaryRb.TabIndex = 10;
            this.PrimaryRb.TabStop = true;
            this.PrimaryRb.Text = "Primary";
            this.PrimaryRb.UseVisualStyleBackColor = true;
            // 
            // UniversityRb
            // 
            this.UniversityRb.AutoSize = true;
            this.UniversityRb.Location = new System.Drawing.Point(14, 94);
            this.UniversityRb.Name = "UniversityRb";
            this.UniversityRb.Size = new System.Drawing.Size(102, 24);
            this.UniversityRb.TabIndex = 13;
            this.UniversityRb.Text = "University";
            this.UniversityRb.UseVisualStyleBackColor = true;
            // 
            // GanderGb
            // 
            this.GanderGb.Controls.Add(this.ErkekRb);
            this.GanderGb.Controls.Add(this.KadinRb);
            this.GanderGb.Location = new System.Drawing.Point(97, 193);
            this.GanderGb.Name = "GanderGb";
            this.GanderGb.Size = new System.Drawing.Size(149, 100);
            this.GanderGb.TabIndex = 14;
            this.GanderGb.TabStop = false;
            this.GanderGb.Text = "Gander";
            // 
            // ErkekRb
            // 
            this.ErkekRb.AutoSize = true;
            this.ErkekRb.Checked = true;
            this.ErkekRb.Location = new System.Drawing.Point(18, 27);
            this.ErkekRb.Name = "ErkekRb";
            this.ErkekRb.Size = new System.Drawing.Size(75, 24);
            this.ErkekRb.TabIndex = 4;
            this.ErkekRb.TabStop = true;
            this.ErkekRb.Text = "Erkek";
            this.ErkekRb.UseVisualStyleBackColor = true;
            // 
            // KadinRb
            // 
            this.KadinRb.AutoSize = true;
            this.KadinRb.Location = new System.Drawing.Point(18, 57);
            this.KadinRb.Name = "KadinRb";
            this.KadinRb.Size = new System.Drawing.Size(74, 24);
            this.KadinRb.TabIndex = 5;
            this.KadinRb.Text = "Kadın";
            this.KadinRb.UseVisualStyleBackColor = true;
            // 
            // SchoolGb
            // 
            this.SchoolGb.Controls.Add(this.UniversityRb);
            this.SchoolGb.Controls.Add(this.PrimaryRb);
            this.SchoolGb.Controls.Add(this.HighRb);
            this.SchoolGb.Location = new System.Drawing.Point(97, 299);
            this.SchoolGb.Name = "SchoolGb";
            this.SchoolGb.Size = new System.Drawing.Size(149, 137);
            this.SchoolGb.TabIndex = 15;
            this.SchoolGb.TabStop = false;
            this.SchoolGb.Text = "School";
            // 
            // HobbiesGb
            // 
            this.HobbiesGb.Controls.Add(this.checkBox4);
            this.HobbiesGb.Controls.Add(this.checkBox3);
            this.HobbiesGb.Controls.Add(this.checkBox2);
            this.HobbiesGb.Controls.Add(this.checkBox1);
            this.HobbiesGb.Location = new System.Drawing.Point(97, 443);
            this.HobbiesGb.Name = "HobbiesGb";
            this.HobbiesGb.Size = new System.Drawing.Size(149, 153);
            this.HobbiesGb.TabIndex = 16;
            this.HobbiesGb.TabStop = false;
            this.HobbiesGb.Text = "Hobbies";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Reading";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Walking";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Sleeping";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(14, 118);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(114, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Code Write";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 701);
            this.Controls.Add(this.HobbiesGb);
            this.Controls.Add(this.SchoolGb);
            this.Controls.Add(this.GanderGb);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.UserListLbl);
            this.Controls.Add(this.UserListLb);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GanderGb.ResumeLayout(false);
            this.GanderGb.PerformLayout();
            this.SchoolGb.ResumeLayout(false);
            this.SchoolGb.PerformLayout();
            this.HobbiesGb.ResumeLayout(false);
            this.HobbiesGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.ListBox UserListLb;
        private System.Windows.Forms.Label UserListLbl;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.RadioButton HighRb;
        private System.Windows.Forms.RadioButton PrimaryRb;
        private System.Windows.Forms.RadioButton UniversityRb;
        private System.Windows.Forms.GroupBox GanderGb;
        private System.Windows.Forms.RadioButton ErkekRb;
        private System.Windows.Forms.RadioButton KadinRb;
        private System.Windows.Forms.GroupBox SchoolGb;
        private System.Windows.Forms.GroupBox HobbiesGb;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

