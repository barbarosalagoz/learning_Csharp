using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Project_Sinema_Bufe_Satis_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // global alan
        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            int misir,bilet,su,cay,toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = (misir * 4) + (su * 1) + (cay * 2) + (bilet * 8);
            LblToplam.Text = toplam.ToString() + "₺";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + "₺";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";

            TxtMisir.Focus();

        }
    }
}
