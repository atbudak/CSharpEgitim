using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine($"For Döngüsü: {i}");
            //}

            //for (int i = 0; i < 56; i += 3)
            //{
            //    Console.WriteLine($"For Döngüsü: {i}");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapısı

            // Example: 1

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 10 == 0)
            //        Console.WriteLine($"Sayı: {i}");
            //}

            // Example: 2

            //int totalvalue = 0;

            //for (int i = 0; i <= 150; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine($"Toplam Değer: {totalvalue}");

            // Example: 3

            //int totalvalue = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalvalue++;
            //        Console.WriteLine($"7'nin Katı Olan Sayı: {i}");
            //    }
            //}

            //Console.WriteLine($"7'nin Katı Olan Sayıların Adedi: {totalvalue}");

            // Example: 4

            //int bakteri = 1, saat = 24;

            //for (int i = 1; i <= saat; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine($"Bakteri Sayısı: {bakteri}");
            //}

            #endregion

            #region While Döngüsü

            // Example: 1

            //int i = 0;

            //while (i < 6)
            //{
            //    Console.WriteLine($"While Döngüsü: {i}");
            //    i++;
            //}

            // Example: 2

            //int i = 0;
            //int sum = 0;

            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sum += i;
            //        Console.WriteLine($"7'nin Katı Olan Sayı: {i}");
            //    }
            //    i++;
            //}

            //Console.WriteLine($"7'nin Katı Olan Sayıların Toplamı: {sum}");


            #endregion

            #region Örnek Soru

            // Klavyeden girilien 3 basamaklı bir sayının basamaklarının toplamını hesaplayınız.

            int sayi, basamak1, basamak2, basamak3, toplam;
            Console.Write("3 Basamaklı Bir Sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            basamak1 = sayi / 100; // Yüzler Basamağı
            basamak2 = (sayi / 10) % 10; // Onlar Basamağı
            basamak3 = sayi % 10; // Birler Basamağı
            toplam = basamak1 + basamak2 + basamak3;
            Console.WriteLine($"Basamakların Toplamı: {toplam}");

            #endregion 

            Console.Read();

        }
    }
}
