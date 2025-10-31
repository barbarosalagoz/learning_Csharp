namespace Constructor_Yapılar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);

            Console.Read();
        }
    }
}
