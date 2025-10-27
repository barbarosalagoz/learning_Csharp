using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = TxtAd.Text;
            soyad = TxtSoyad.Text;

            int sinav1,sinav2, ortalama;
            sinav1 = Convert.ToInt16(TxtSinav1.Text);
            sinav2 = Convert.ToInt16(TxtSinav2.Text);
            ortalama = (sinav1 + sinav2) / 2;
            TxtOrt.Text = ortalama.ToString();


            listBox1.Items.Add("Ad: " + ad + " " + " Soyad: " + soyad + " 1. Sınav Notu: " + sinav1 + " " + " 2.Sınav Notu: " + sinav2 + " " + " Ortalama: " + ortalama);

            if (ortalama >= 50)
            {
                MessageBox.Show("Tebrikler, dersten geçtiniz. Notunuz: " + ortalama);
            }
            else
            {
                MessageBox.Show("Maalesef dersten kaldınız. Notunuz: " + ortalama);
            }


        }
    }
}
