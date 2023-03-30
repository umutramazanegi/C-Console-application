using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Egitim8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Sözlük Uygulaması");

            Dictionary<string, string> sozluk = new Dictionary<string, string>();

            // Sözlük dosyasını oku ve sözlük nesnesine ekle
            string dosyaYolu = "sozluk.txt";
            StreamReader reader = new StreamReader(dosyaYolu);

            string satir;
            while ((satir = reader.ReadLine()) != null)
            {
                string[] kelimeVeAnlami = satir.Split('\t');
                sozluk.Add(kelimeVeAnlami[0], kelimeVeAnlami[1]);
            }

            reader.Close();

            while (true)
            {
                Console.Write("\nBir veya daha fazla kelime giriniz (kelimeleri virgülle ayırın, çıkmak için 'exit' yazın): ");
                string kelimeListesi = Console.ReadLine();

                if (kelimeListesi == "exit")
                {
                    break;
                }

                string[] kelimeler = kelimeListesi.Split(',');

                foreach (string kelime in kelimeler)
                {
                    Console.WriteLine("\n" + kelime + ":");

                    // Kelimenin anlamını göster
                    if (sozluk.ContainsKey(kelime.Trim()))
                    {
                        Console.WriteLine(sozluk[kelime.Trim()]);
                    }
                    else
                    {
                        Console.WriteLine(kelime.Trim() + " sözlükte bulunamadı.");
                    }
                }
            }

            Console.WriteLine("\nProgramdan çıkılıyor. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
