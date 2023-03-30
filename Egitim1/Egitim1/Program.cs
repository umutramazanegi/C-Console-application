using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim1
{
    internal class Program
    {
        /*iki tarih girerek aralarındaki yil, ay ve gün farki
        Bu ornekte, kullanicilara iki tarih girmesi icin istekte bulunulur ve DateTime.Parse()
yontemi kullanilarak girilen tarihler DateTime turune donusturulur.
Daha sonra TimeSpan sinifi kullanilarak iki tarih arasindaki fark
hesaplanir ve sonuclar konsola yazdirilir.
Konsol uygulamalari, kullanicilara metin tabanli bir arayuz sunar ve veri girisi icin Console.ReadLine()
yontemi kullanilir. Yukaridaki ornek, kullanicinin giris yapmasi ve konsol uygulamalari olusturmasi icin
temel bir baslangic noktasi saglar. Umut Ramazan Eği
         */
        static void Main(string[] args)
        {
            Console.WriteLine("İki tarih arasındaki farkı hesaplamak için ilk tarihi girin (örn: 15.03.2022): ");
            DateTime tarih1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("İki tarih arasındaki farkı hesaplamak için ikinci tarihi girin (örn: 30.03.2023): ");
            DateTime tarih2 = DateTime.Parse(Console.ReadLine());

            TimeSpan fark = tarih2 - tarih1;

            int yilFarki = fark.Days / 365;
            int ayFarki = (fark.Days % 365) / 30;
            int gunFarki = (fark.Days % 365) % 30;

            Console.WriteLine("Yıl Farkı: " + yilFarki);
            Console.WriteLine("Ay Farkı: " + ayFarki);
            Console.WriteLine("Gün Farkı: " + gunFarki);
            Console.ReadLine();
        }
    }
}
