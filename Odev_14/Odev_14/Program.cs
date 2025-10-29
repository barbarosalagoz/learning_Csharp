namespace Odev_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dortislem drt = new dortislem();
            drt.topla(20, 10);
            drt.cikar(20, 10);
            drt.carp(20, 10);
            drt.bol(20, 10);

            Console.Read();
        }
    }
}
