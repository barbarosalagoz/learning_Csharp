namespace Constructor_Yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, job;
            int yas;
            //Console.Write("Ad - Kulüp: ");
            //blg = Console.ReadLine();

            Console.Write("Ad: ");
            name = Console.ReadLine();

            Console.Write("Soyad: ");
            surname = Console.ReadLine();

            Console.Write("Meslek: ");
            job = Console.ReadLine();

            Console.Write("Yaş: ");
            yas = Convert.ToInt32(Console.ReadLine());

            Ogrenci ogr = new Ogrenci(name, surname, yas, job);

        }
    }
}
