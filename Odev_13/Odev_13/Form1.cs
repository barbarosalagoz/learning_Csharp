using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Toplam(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            int s4 = Convert.ToInt16(textBox2.Text);
            textBox3.Text = Toplam(s,s4).ToString();
        }
    }
}
