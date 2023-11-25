namespace DigitalClockExample
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
            this.dcLbl = new System.Windows.Forms.Label();
            this.saatLbl = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.localSaatLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dcLbl
            // 
            this.dcLbl.AutoSize = true;
            this.dcLbl.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcLbl.ForeColor = System.Drawing.Color.Cyan;
            this.dcLbl.Location = new System.Drawing.Point(180, 51);
            this.dcLbl.Name = "dcLbl";
            this.dcLbl.Size = new System.Drawing.Size(459, 71);
            this.dcLbl.TabIndex = 0;
            this.dcLbl.Text = "DIGITAL CLOCK";
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saatLbl.Location = new System.Drawing.Point(216, 188);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(104, 71);
            this.saatLbl.TabIndex = 1;
            this.saatLbl.Text = "00";
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dakikaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dakikaLbl.Location = new System.Drawing.Point(355, 188);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(104, 71);
            this.dakikaLbl.TabIndex = 2;
            this.dakikaLbl.Text = "00";
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saniyeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saniyeLbl.Location = new System.Drawing.Point(487, 188);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(104, 71);
            this.saniyeLbl.TabIndex = 3;
            this.saniyeLbl.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // localSaatLbl
            // 
            this.localSaatLbl.AutoSize = true;
            this.localSaatLbl.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localSaatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.localSaatLbl.Location = new System.Drawing.Point(272, 301);
            this.localSaatLbl.Name = "localSaatLbl";
            this.localSaatLbl.Size = new System.Drawing.Size(284, 71);
            this.localSaatLbl.TabIndex = 4;
            this.localSaatLbl.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.localSaatLbl);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.dakikaLbl);
            this.Controls.Add(this.saatLbl);
            this.Controls.Add(this.dcLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dcLbl;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label localSaatLbl;
    }
}

