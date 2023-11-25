using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAddUserExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string fullName=NameTxt.Text+" "+
                            SurnameTxt.Text+" - "+
                            (ErkekRb.Checked?ErkekRb.Text:KadinRb.Text);

            foreach (var rb in SchoolGb.Controls.OfType<RadioButton>())
            {
                if(rb.Checked)
                {
                    fullName +=" - "+ rb.Text;
                }
            }

            fullName += " - Hobbies: ";
            foreach (var cb in HobbiesGb.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    fullName +=" - "+ cb.Text;
                }
            }

            UserListLb.Items.Add(fullName);
        }
    }
}
