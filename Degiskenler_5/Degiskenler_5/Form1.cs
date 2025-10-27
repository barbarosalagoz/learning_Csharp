using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 4;
            toplam = sayi1 + sayi2;

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = toplam.ToString();
        }
    }
}
