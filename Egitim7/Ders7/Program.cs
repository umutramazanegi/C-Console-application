using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime Ters Çevirici");

            Console.Write("Cümleyi giriniz: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');

            Console.WriteLine("\nKelime harfleri ters çevrilmiş hali:");

            foreach (string kelime in kelimeler)
            {
                char[] karakterDizisi = kelime.ToCharArray();
                Array.Reverse(karakterDizisi);
                Console.Write(new string(karakterDizisi) + " ");
            }

            Console.ReadKey();
        }
    }
}
