using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double sayi;
            //sayi = 4.25;
            //label1.Text = sayi.ToString();

            double s1,s2,s3,ortalama;
            s1 = 60;
            s2 = 70;
            s3 = 79;
            ortalama = (s1 + s2 + s3) / 3;

            label1.Text = "Ortalama: " + ortalama.ToString("0.00");

            // double veri tipi ondalıklı sayılar için kullanılır.
            // Ondalıklı sayılar virgül veya nokta ile yazılabilir.
            // Ancak C# dilinde ondalık ayıracı olarak nokta kullanılır.
            // Virgül kullanılırsa derleme hatası oluşur.
            // Örnek: double sayi = 4,25; // Hatalı
            // Doğru kullanım: double sayi = 4.25;
            // double veri tipi 8 byte (64 bit) yer kaplar.
            // double veri tipi yaklaşık olarak ±5.0 × 10^−324 ile ±1.7 × 10^308 arasındaki değerleri alabilir.
            // double veri tipi ondalıklı sayılar için yüksek hassasiyet gerektiren durumlarda tercih edilir.
            // Ancak daha fazla bellek kullanır ve işlemler float veri tipine göre daha yavaştır.
            // Eğer daha az hassasiyet yeterliyse float veri tipi tercih edilebilir.
            // float veri tipi 4 byte (32 bit) yer kaplar ve yaklaşık olarak ±1.5 × 10^−45 ile ±3.4 × 10^38 arasındaki değerleri alabilir.
            // Örnek: float sayi = 4.25f; // 'f' eki float olduğunu belirtir.
            // double veri tipi genellikle finansal hesaplamalar, bilimsel veriler ve mühendislik uygulamalarında kullanılır.
            // double veri tipi ile çalışırken yuvarlama hatalarına dikkat edilmelidir.
            // Özellikle karşılaştırma işlemlerinde doğrudan eşitlik kontrolü yerine belirli bir tolerans aralığında kontrol yapmak daha güvenlidir.
            // to.String("0.00") ifadesi, sayının sadece iki ondalık basamağını göstermeyi sağlar.
        }
    }
}
