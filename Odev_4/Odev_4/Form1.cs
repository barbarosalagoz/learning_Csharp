using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısakenar,uzunkenar, alan, cevre;
            kısakenar = 10;
            uzunkenar = 20;
            alan = kısakenar * uzunkenar;
            cevre = 2 * (kısakenar + uzunkenar);

            label1.Text = "Alan: " + alan.ToString() + " Çevre: " + cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int birinci_not,ikinci_not,ucuncu_not,ortalama;
            birinci_not = 50;
            ikinci_not = 60;
            ucuncu_not = 70;
            ortalama = (birinci_not + ikinci_not + ucuncu_not) / 3;

            label2.Text = birinci_not.ToString();
            label3.Text = ikinci_not.ToString();
            label4.Text = ucuncu_not.ToString();
            label5.Text = "Ortalama: " + ortalama.ToString();
        }
    }
}
