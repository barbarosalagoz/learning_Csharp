using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class islem
    {
        public int topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Sonuç: " + s3);
            return s3;
        }

        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;

        }
    }
}
