using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Barbaros Emre";
            textBox2.Text = "Alagöz";
            textBox3.Text = "36";
            textBox4.Text = "Gayrimenkul Danışmanı";
            textBox5.Text = "500000₺";

            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
        }
    }
}
