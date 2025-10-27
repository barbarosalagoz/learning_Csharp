using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Karar_Yapilari_Pratik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;

            kitapadet = Convert.ToInt32(textBox1.Text);

            if(kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text = toplam.ToString() + " TL";
            }

            if(kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam.ToString() + " TL";
            }

            if(kitapadet >= 41 && kitapadet <= 60)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam.ToString() + " TL";
            }
        }
    }
}
