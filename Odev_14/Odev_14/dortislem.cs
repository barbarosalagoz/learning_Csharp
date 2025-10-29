using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Odev_14
{
    internal class dortislem
    {
        public int topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Sonuç: " + s3);
            return s3;
        }

        public int cikar(int s1, int s2)
        {
            int s4 = s1 - s2;
            Console.WriteLine("Sonuç: " + s4);
            return s4;
        }

        public int carp(int s1, int s2)
        {
            int s5 = s1 * s2;
            Console.WriteLine("Sonuç: " + s5);
            return s5;
        }

        public int bol(int s1, int s2)
        {
            int s6 = s1 / s2;
            Console.WriteLine("Sonuç: " + s6);
            return s6;
        }


    }
}
