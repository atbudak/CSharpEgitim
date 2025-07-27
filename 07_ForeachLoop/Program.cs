using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach(1;2;3;4)

            // 1:Değişken Türü
            // 2:Değişken Adı
            // 3:In
            // 4:Liste, Koleksiyon, Dizi


            // Example 1

            //string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Fatma" };

            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            // Example 2

            //int[] sayilar = { 1, 2, 3, 4, 5 };

            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}   

            // Example 3

            //int[] numbers = {58, 12, 45, 78, 23, 67, 89};

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"{number} is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is odd.");
            //    }
            //}

            // Example 4

            //int[] numbers = { 58, 12, 45, 78, 23, 67, 89 };
            //int sum = 0;

            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine($"The sum of the numbers is: {sum}");

            // Example 5

            //List<int> numbers = new List<int> { 58, 12, 45, 78, 23, 67, 89 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // Example 6

            //string word = "Merhaba";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}


            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("Sınav Sistemine Hoş Geldiniz!");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Sınıfınızdaki Öğrenci Sayısını Giriniz: ");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciListesi = new string[ogrenciSayisi];
            double[] ortalamaListesi = new double[ogrenciSayisi];


            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write($"Öğrenci {i + 1} Adını Giriniz: ");
                string ogrenciAdi = Console.ReadLine();
                ogrenciListesi[i] = ogrenciAdi;

                double toplamNot = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Öğrenci {ogrenciAdi} için {j + 1}. Notu Giriniz: ");
                    double notDegeri = Convert.ToDouble(Console.ReadLine());
                    toplamNot += notDegeri;
                }
                ortalamaListesi[i] = toplamNot / 3; // Her öğrencinin not ortalamasını hesapla
                Console.WriteLine();

            }

            // Öğrencilerin ortalaması ve geçme durumu
            Console.WriteLine();
            Console.WriteLine("Öğrenci Not Ortalamaları ve Geçme Durumları:");
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"{ogrenciListesi[i]} - Not Ortalaması: {ortalamaListesi[i]} - {(ortalamaListesi[i] >= 60 ? "Geçti" : "Kaldı")}");
            }

            #endregion


            Console.Read();

        }
    }
}
