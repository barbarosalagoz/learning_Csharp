using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int ay = Convert.ToInt32(textBox1.Text);

            //switch (ay)
            //{
            //    case 1: label2.Text = "Ocak"; break;
            //    case 2: label2.Text = "Şubat"; break;
            //    case 3: label2.Text = "Mart"; break;
            //    case 4: label2.Text = "Nisan"; break;
            //    case 5: label2.Text = "Mayıs"; break;
            //    case 6: label2.Text = "Haziran"; break;
            //    case 7: label2.Text = "Temmuz"; break;
            //    case 8: label2.Text = "Ağustos"; break;
            //    case 9: label2.Text = "Eylül"; break;
            //    case 10: label2.Text = "Ekim"; break;
            //    case 11: label2.Text = "Kasım"; break;
            //    case 12: label2.Text = "Aralık"; break;
            //    default: label2.Text = "Hatalı Ay"; break;
            //}

            // bu aylarla ilgili int kapsayan bir şeydi; şimdi mevsimlerle ilgili kod yazıcaz

            //string mevsim = textBox1.Text;

            //switch (mevsim)
            //{
            //    case "yaz": label2.Text = "haziran temmuz ağustos";
            //        break;
            //    case "sonbahar": label2.Text = "eylül ekim kasım";
            //        break;
            //    case "kış": label2.Text = "aralık ocak şubar";
            //        break;
            //    case "ilkbahar": label2.Text = "mart nisan mayıs";
            //        break;
            //    default: label2.Text = "Hatalı Mevsim!";
            //        break;
            //}

            // şimdi ise iki farklı sayı verilen rakama göre aritmetik işlem sonucunu verecek iki farklı textboc üzerinden

            int sayi1, sayi2, toplama, cikarma, carpma, bolme;
            sayi1 = Convert.ToInt16(Sayi1.Text);
            sayi2 = Convert.ToInt16(Sayi2.Text);

            toplama = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;

            string girilen_deger = comboBox1.Text; // ComboBox'taki seçilen veya yazılan değer

            switch (girilen_deger)
            {
                case "Topla":
                    label2.Text = toplama.ToString();
                    break;

                case "Çıkar":
                    label2.Text = cikarma.ToString();
                    break;

                case "Çarp":
                    label2.Text = carpma.ToString();
                    break;

                case "Böl":
                    label2.Text = bolme.ToString();
                    break;

                default:
                    label2.Text = "Geçersiz işlem!";
                    break;
            }
        }
    }
}
