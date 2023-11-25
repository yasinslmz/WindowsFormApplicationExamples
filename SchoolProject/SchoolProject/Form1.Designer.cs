namespace SchoolProject
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
            this.StudentDgv = new System.Windows.Forms.DataGridView();
            this.AddUserGb = new System.Windows.Forms.GroupBox();
            this.UpdateUserGb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusCb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassesCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.UpdateUserBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UClassesCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UStatusCb = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UAgeNud = new System.Windows.Forms.NumericUpDown();
            this.UsurnameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectedIdLbl = new System.Windows.Forms.Label();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDgv)).BeginInit();
            this.AddUserGb.SuspendLayout();
            this.UpdateUserGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UAgeNud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentDgv
            // 
            this.StudentDgv.AllowUserToAddRows = false;
            this.StudentDgv.AllowUserToDeleteRows = false;
            this.StudentDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDgv.Location = new System.Drawing.Point(380, 47);
            this.StudentDgv.Name = "StudentDgv";
            this.StudentDgv.ReadOnly = true;
            this.StudentDgv.RowHeadersWidth = 62;
            this.StudentDgv.RowTemplate.Height = 28;
            this.StudentDgv.Size = new System.Drawing.Size(990, 665);
            this.StudentDgv.TabIndex = 0;
            this.StudentDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDgv_CellDoubleClick);
            // 
            // AddUserGb
            // 
            this.AddUserGb.Controls.Add(this.AddUserBtn);
            this.AddUserGb.Controls.Add(this.label5);
            this.AddUserGb.Controls.Add(this.ClassesCb);
            this.AddUserGb.Controls.Add(this.label4);
            this.AddUserGb.Controls.Add(this.StatusCb);
            this.AddUserGb.Controls.Add(this.label3);
            this.AddUserGb.Controls.Add(this.AgeNud);
            this.AddUserGb.Controls.Add(this.SurnameTxt);
            this.AddUserGb.Controls.Add(this.label2);
            this.AddUserGb.Controls.Add(this.NameTxt);
            this.AddUserGb.Controls.Add(this.label1);
            this.AddUserGb.Location = new System.Drawing.Point(27, 47);
            this.AddUserGb.Name = "AddUserGb";
            this.AddUserGb.Size = new System.Drawing.Size(319, 245);
            this.AddUserGb.TabIndex = 1;
            this.AddUserGb.TabStop = false;
            this.AddUserGb.Text = "Add User";
            // 
            // UpdateUserGb
            // 
            this.UpdateUserGb.Controls.Add(this.UpdateUserBtn);
            this.UpdateUserGb.Controls.Add(this.label6);
            this.UpdateUserGb.Controls.Add(this.UClassesCb);
            this.UpdateUserGb.Controls.Add(this.label7);
            this.UpdateUserGb.Controls.Add(this.UStatusCb);
            this.UpdateUserGb.Controls.Add(this.label8);
            this.UpdateUserGb.Controls.Add(this.UAgeNud);
            this.UpdateUserGb.Controls.Add(this.UsurnameTxt);
            this.UpdateUserGb.Controls.Add(this.label9);
            this.UpdateUserGb.Controls.Add(this.UNameTxt);
            this.UpdateUserGb.Controls.Add(this.label10);
            this.UpdateUserGb.Location = new System.Drawing.Point(27, 314);
            this.UpdateUserGb.Name = "UpdateUserGb";
            this.UpdateUserGb.Size = new System.Drawing.Size(319, 245);
            this.UpdateUserGb.TabIndex = 2;
            this.UpdateUserGb.TabStop = false;
            this.UpdateUserGb.Text = "Update User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(10, 64);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 26);
            this.NameTxt.TabIndex = 1;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(10, 132);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(100, 26);
            this.SurnameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // AgeNud
            // 
            this.AgeNud.Location = new System.Drawing.Point(10, 194);
            this.AgeNud.Name = "AgeNud";
            this.AgeNud.Size = new System.Drawing.Size(100, 26);
            this.AgeNud.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // StatusCb
            // 
            this.StatusCb.AutoSize = true;
            this.StatusCb.Location = new System.Drawing.Point(159, 65);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(95, 24);
            this.StatusCb.TabIndex = 6;
            this.StatusCb.Text = "IsStatus";
            this.StatusCb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // ClassesCb
            // 
            this.ClassesCb.FormattingEnabled = true;
            this.ClassesCb.Location = new System.Drawing.Point(159, 132);
            this.ClassesCb.Name = "ClassesCb";
            this.ClassesCb.Size = new System.Drawing.Size(121, 28);
            this.ClassesCb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Classes";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(159, 183);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(121, 37);
            this.AddUserBtn.TabIndex = 10;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UpdateUserBtn
            // 
            this.UpdateUserBtn.Location = new System.Drawing.Point(175, 175);
            this.UpdateUserBtn.Name = "UpdateUserBtn";
            this.UpdateUserBtn.Size = new System.Drawing.Size(121, 37);
            this.UpdateUserBtn.TabIndex = 21;
            this.UpdateUserBtn.Text = "Update User";
            this.UpdateUserBtn.UseVisualStyleBackColor = true;
            this.UpdateUserBtn.Click += new System.EventHandler(this.UpdateUserBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Classes";
            // 
            // UClassesCb
            // 
            this.UClassesCb.FormattingEnabled = true;
            this.UClassesCb.Location = new System.Drawing.Point(175, 124);
            this.UClassesCb.Name = "UClassesCb";
            this.UClassesCb.Size = new System.Drawing.Size(121, 28);
            this.UClassesCb.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status";
            // 
            // UStatusCb
            // 
            this.UStatusCb.AutoSize = true;
            this.UStatusCb.Location = new System.Drawing.Point(175, 57);
            this.UStatusCb.Name = "UStatusCb";
            this.UStatusCb.Size = new System.Drawing.Size(95, 24);
            this.UStatusCb.TabIndex = 17;
            this.UStatusCb.Text = "IsStatus";
            this.UStatusCb.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Age";
            // 
            // UAgeNud
            // 
            this.UAgeNud.Location = new System.Drawing.Point(26, 186);
            this.UAgeNud.Name = "UAgeNud";
            this.UAgeNud.Size = new System.Drawing.Size(100, 26);
            this.UAgeNud.TabIndex = 15;
            // 
            // UsurnameTxt
            // 
            this.UsurnameTxt.Location = new System.Drawing.Point(26, 124);
            this.UsurnameTxt.Name = "UsurnameTxt";
            this.UsurnameTxt.Size = new System.Drawing.Size(100, 26);
            this.UsurnameTxt.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Surname";
            // 
            // UNameTxt
            // 
            this.UNameTxt.Location = new System.Drawing.Point(26, 56);
            this.UNameTxt.Name = "UNameTxt";
            this.UNameTxt.Size = new System.Drawing.Size(100, 26);
            this.UNameTxt.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteUserBtn);
            this.groupBox1.Controls.Add(this.SelectedIdLbl);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(27, 566);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete User";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Selected User: ";
            // 
            // SelectedIdLbl
            // 
            this.SelectedIdLbl.AutoSize = true;
            this.SelectedIdLbl.Location = new System.Drawing.Point(126, 44);
            this.SelectedIdLbl.Name = "SelectedIdLbl";
            this.SelectedIdLbl.Size = new System.Drawing.Size(18, 20);
            this.SelectedIdLbl.TabIndex = 1;
            this.SelectedIdLbl.Text = "0";
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteUserBtn.Location = new System.Drawing.Point(17, 91);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(279, 44);
            this.DeleteUserBtn.TabIndex = 2;
            this.DeleteUserBtn.Text = "Delete User";
            this.DeleteUserBtn.UseVisualStyleBackColor = false;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateUserGb);
            this.Controls.Add(this.AddUserGb);
            this.Controls.Add(this.StudentDgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDgv)).EndInit();
            this.AddUserGb.ResumeLayout(false);
            this.AddUserGb.PerformLayout();
            this.UpdateUserGb.ResumeLayout(false);
            this.UpdateUserGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UAgeNud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDgv;
        private System.Windows.Forms.GroupBox AddUserGb;
        private System.Windows.Forms.GroupBox UpdateUserGb;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClassesCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox StatusCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AgeNud;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateUserBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox UClassesCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox UStatusCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown UAgeNud;
        private System.Windows.Forms.TextBox UsurnameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UNameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Label SelectedIdLbl;
        private System.Windows.Forms.Label label11;
    }
}

