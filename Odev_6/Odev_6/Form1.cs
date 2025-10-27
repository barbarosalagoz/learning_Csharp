using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, alan, cevre;
            kisakenar = Convert.ToInt16(textBox1.Text);
            uzunkenar = Convert.ToInt16(textBox2.Text);
            alan = kisakenar * uzunkenar;
            cevre = 2 * (kisakenar + uzunkenar);

            label4.Text = alan.ToString();
            label6.Text = cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yaricap, pi, alan, cevre;
            yaricap = Convert.ToInt16(textBox3.Text);
            pi = Convert.ToInt16(textBox4.Text);
            alan = pi * yaricap * yaricap;
            cevre = 2 * pi * yaricap;

            label10.Text = alan.ToString();
            label12.Text = cevre.ToString();

        }
    }
}
