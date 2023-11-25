using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormExample
{
    public partial class Form1 : Form
    {
        Label label;
        Button newButton;
        Button AddTextButton;
        TextBox NameTxt;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = "erhankaya";
            string password = "123";

            if(username == UserNameTxt.Text && password == PasswordTxt.Text)
            {
                MessageBox.Show("Merhaba " + username, 
                                "Giriş Başarılı",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                createElement();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi",
                                "Hatalı Giriş",
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
            }
        }
        public void createElement()
        {
            label = new Label();

            label.Name = "NewLabel";
            label.Text = "Sistem Açılıyor....";
            label.ForeColor = Color.Green;
            label.Location = new Point(190, 260);

            this.Controls.Add(label);

            newButton=new Button();
            newButton.Name = "NewButton";
            newButton.Text = "Sistemi Aç";
            newButton.Location = new Point(190, 290);
            newButton.Size = new Size(150, 30);
            newButton.Click += NewButton_Click;

            this.Controls.Add(newButton);

            UserNameLbl.Visible = false;
            UserNameTxt.Visible = false;
            PasswordTxt.Visible = false;
            PasswordLbl.Visible = false;
            LoginBtn.Visible = false;



            AddTextButton=new Button();
            AddTextButton.Name = "AddTextButton";
            AddTextButton.Text = "Add Name";
            AddTextButton.Location = new Point(570, 320);
            AddTextButton.Click += AddTextButton_Click;
            this.Controls.Add(AddTextButton);

            NameTxt = new TextBox();
            NameTxt.Name = "NameTxt";
            NameTxt.Location = new Point(650, 320);
            this.Controls.Add(NameTxt);

            isimlerRtb.Enabled = false;
        }
        private void AddTextButton_Click(object sender, EventArgs e)
        {
            isimlerRtb.Text += NameTxt.Text + "\n";
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            label.Text = "Merhaba Ben Geldim :)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = "Merhaba";
        }
    }
}
