using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // if else yapısı

        // tek seçimli karar yapısı
        // koşul doğru ise çalışır
        // koşul yanlış ise çalışmaz


        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text =="ali") 
            //{
            //    label1.Text = "doğru";
            //}
            //else
            //{
            //    label1.Text = "yanlış";
            //}

            int sayi = Convert.ToInt32(textBox1.Text);
            //if (sayi == 5)
            //{
            //    label1.Text = "doğru";
            //}
            //else
            //{
            //    label1.Text = "yanlış";
            //}

            // if yapılarda yine değişken ile çalışma yapabiliyoruz
            // tek yapmamız gereken o anki şartların ne olduğunu iyice düşünüp ona göre cevap vermek

            //if (sayi % 2 == 0)
            //{
            //    label1.Text = "Çift";
            //}
            //else
            //{
            //    label1.Text = "Tek";
            //}

            // operatör karar yapısı

            if (sayi % 2 == 0 && sayi>=10)
            {
                label1.Text = "Çift ve 10'dan büyük veya eşit";
            }
            else
            {
                label1.Text = "Diğer durumlar";
            }

        }
    }
}
