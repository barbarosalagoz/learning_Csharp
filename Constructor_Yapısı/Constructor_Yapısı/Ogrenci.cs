using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapısı
{
    internal class Ogrenci
    {
        //public Ogrenci()
        //{
        //    //Console.WriteLine("Ad: Baran");
        //    //Console.WriteLine("Soyad: Yücedağ");
        //    //Console.WriteLine("Meslek: Öğretmen");


        //}

        public Ogrenci(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("\n--- Öğrenci Bilgileri ---");
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Soyad: {soyad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"Meslek: {meslek}");
        }
    }
}
