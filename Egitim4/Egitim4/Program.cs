using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin Ters Çevirici");

            Console.Write("Metni giriniz: ");
            string metin = Console.ReadLine();

            char[] karakterDizisi = metin.ToCharArray();
            Array.Reverse(karakterDizisi);

            Console.WriteLine("\nTers çevrilmiş metin: " + new string(karakterDizisi));

            Console.ReadKey();
        }
    }
}
