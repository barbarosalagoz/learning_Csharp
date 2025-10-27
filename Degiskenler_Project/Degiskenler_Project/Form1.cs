using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, meslek;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            meslek = comboBox1.Text;

            if (checkBox1.Checked)
            {
                label5.Text = "Erkek";
            }
            else if (checkBox2.Checked)
            {
                label5.Text = "Kadın";
            }
            else
            {
                label5.Text = "";
            }

            listBox1.Items.Add(ad + " " + soyad + " " + meslek + " " + label5.Text);

        }
    }
}
