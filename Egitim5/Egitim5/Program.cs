using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Egitim5
{
    //dosyaların listelenmesi ve belirli bir dosya tipinin sayısının bulunması
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dosya Listeleme ve Sayma");

            Console.Write("Listelenecek dosya dizini yolu: ");
            string dizinYolu = Console.ReadLine();

            Console.Write("Sayılacak dosya uzantısı: ");
            string dosyaUzantisi = Console.ReadLine();

            string[] dosyaListesi = Directory.GetFiles(dizinYolu, "*." + dosyaUzantisi);

            Console.WriteLine("\n" + dizinYolu + " dizinindeki " + dosyaUzantisi + " dosyaları:");

            foreach (string dosya in dosyaListesi)
            {
                Console.WriteLine(Path.GetFileName(dosya));
            }

            Console.WriteLine("\nToplam " + dosyaListesi.Length + " adet " + dosyaUzantisi + " dosyası bulundu.");

            Console.ReadKey();
        }
    }
}
