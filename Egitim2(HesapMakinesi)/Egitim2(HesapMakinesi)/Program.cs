using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim2_HesapMakinesi_
{
    internal class Program
    {
        /*Basit bir hesap makinesi uygulaması */
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nToplama işlemi: " + (sayi1 + sayi2));
            Console.WriteLine("Çıkarma işlemi: " + (sayi1 - sayi2));
            Console.WriteLine("Çarpma işlemi: " + (sayi1 * sayi2));
            Console.WriteLine("Bölme işlemi: " + (sayi1 / sayi2));

            Console.ReadKey();
        }
    }
}
