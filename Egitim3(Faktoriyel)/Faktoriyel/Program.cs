using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    internal class Program
    {
        //faktoriyel
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyel Hesaplayıcı");

            Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("\n" + sayi + "! = " + faktoriyel);

            Console.ReadKey();
        }
    }
}
