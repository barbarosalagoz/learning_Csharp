using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Ornek
{
    internal class Araba : ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string Marka;

        // kapsülleme örneği - class içerisinde kapsülleme - encapsulation
        // kapsülleme bilinçsiz kullanmayı önleyen private class ları public hale getiren ve kullanılmasını sağlayan bir yapıdır

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }

            // Math kütüphanesi mutlak değer alma işlemi yapar
            // Böylelikle negatif değer girilse bile pozitif olarak kaydedilir

        }

        public string MARKASI
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }

        // kalıtım ise bir sınıf içindeki verileri bir arada kullanılmak istenmezse iki class yaratıp kalıtım yardımıyla toparlayabiliriz.
        // Buna da inheritance deniyor.
    }
}
