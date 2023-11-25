using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComboBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(ProductNameTxt.Text))
            {
                ProductListLb.Items.Add(ProductNameTxt.Text);
                ProductNameTxt.Clear();
                ProductNameTxt.Focus();
            }
            else
            {
                MessageBox.Show("Product Name Add Error",
                                "Add Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            ProductListLb.Items.Clear();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            ProductListLb.Items.Remove(ProductListLb.SelectedItem);
        }

        private void MoveProductBtn_Click(object sender, EventArgs e)
        {
            MoveProductListCb.Items.Add(ProductListLb.SelectedItem.ToString());
            MoveProductListCb.SelectedItem = ProductListLb.SelectedItem.ToString();
            ProductListLb.Items.Remove(ProductListLb.SelectedItem);

        }
        int i = 0;
        int j= 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            sayiLbl.Text = i.ToString();
            if (i == 10)
            {
                timer1.Stop();
                i = 0;
                sayiLbl.Text = i.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            sayi2Lbl.Text = j.ToString();
        }

        //private void ProductListLb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(ProductListLb.SelectedItem.ToString());
        //}

    }
}
