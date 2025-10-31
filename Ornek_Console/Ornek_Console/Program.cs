namespace Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya!");

            //string kelime;
            //kelime = "29 Ekim";
            //Console.WriteLine(kelime);


            //int sayi = 5;
            //Console.Write(sayi);


            //Console.Read();


            //ks.kisilistesi("Azem Yücedağ");
            //ks.kisilistesi("Barbaros ALAGÖZ");

            //string ads;
            //Console.Write("isim girin:");
            //ads = Console.ReadLine();
            //ks.kisilistesi(ads);

            //Kisiler ks = new Kisiler();
            //string adsoyad, meslek;
            //int yas;
            
            //Console.WriteLine("isim girin: ");
            //adsoyad = Console.ReadLine();

            //Console.WriteLine("meslek girin: ");
            //meslek = Console.ReadLine();

            //Console.WriteLine("yaş girin: ");
            //yas = int.Parse(Console.ReadLine());

            //ks.kisilistesi(adsoyad, meslek, yas);

            // üstteki kısım ödevdi

            // ger

            islem isl = new islem();
            isl.topla(7,6);
            isl.topla(9, 5);
            isl.kare(4);

            Console.Read();

        }
    }
}
