using System;
using System.Windows.Forms;

namespace Arac_Kullanimlari_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1 + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " " +
                               maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}
