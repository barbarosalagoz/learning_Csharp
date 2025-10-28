using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Çarpan(int s1, int s2, int s3)
        {
            textBox1.Text = s1.ToString();
            textBox2.Text = s2.ToString();
            textBox3.Text = s3.ToString();

            int s4 = s1 * s2 * s3;
            return s4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Çarpan(8,9,10).ToString();
        }
    }
}
