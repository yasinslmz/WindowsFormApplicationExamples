using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            if (saat == 24)
            {
                saat = 0;
            }
            saatLbl.Text=saat.ToString().Length<2?"0"+saat.ToString():saat.ToString();
            dakikaLbl.Text = dakika.ToString().Length < 2 ? "0" + dakika.ToString():dakika.ToString() ;
            saniyeLbl.Text = saniye.ToString().Length < 2 ? "0" + saniye.ToString() : saniye.ToString();



            string localSaat = DateTime.Now.ToString("HH:mm:ss");
            localSaatLbl.Text = localSaat;
        
        }
    }
}
