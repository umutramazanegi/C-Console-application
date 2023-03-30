using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Dizisi");

            Console.Write("Kaç adet sayı istiyorsunuz?: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int ilkSayi = 0, ikinciSayi = 1, sonrakiSayi;

            Console.Write(ilkSayi + " " + ikinciSayi + " ");

            for (int i = 2; i < adet; i++)
            {
                sonrakiSayi = ilkSayi + ikinciSayi;
                Console.Write(sonrakiSayi + " ");
                ilkSayi = ikinciSayi;
                ikinciSayi = sonrakiSayi;
            }

            Console.ReadKey();
        }
    }
}
