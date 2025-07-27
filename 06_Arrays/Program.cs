using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Example 1

            //string[] colours = new string[5];
            //colours[0] = "Red";
            //colours[1] = "Green";
            //colours[2] = "Blue";
            //colours[3] = "Yellow";
            //colours[4] = "Black";
            //Console.WriteLine("Colours:");

            //Console.WriteLine(colours[2]);

            // Example 2

            //string[] cities = new string[5];
            //cities[0] = "Istanbul";
            //cities[1] = "Ankara";
            //cities[2] = "Izmir";
            //cities[3] = "Bursa";
            //cities[4] = "Antalya";

            //Console.WriteLine("Cities:" + cities[4]);

            // Example 3

            //int[] numbers = new int[5];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;

            //Console.WriteLine("Numbers:" + numbers[4]);

            // Example 4

            //string[] cities = new string[5] { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya" };

            //Console.WriteLine("Cities: " + cities[4]);



            #endregion

            #region Dizideki Tüm elemanları yazdırma

            // Example 1

            //string[] colours = new string[5] { "Red", "Green", "Blue", "Yellow", "Black" };

            //for (int i = 0; i < colours.Length; i++)
            //{
            //    Console.WriteLine(colours[i]);
            //}

            // Example 2

            //int[] numbers = { 10, 27, 301, 450, 530, 879, 1795 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            // Example 3

            //char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

            //for (int i = 0; i < letters.Length; i++)
            //{
            //    Console.WriteLine(letters[i]);
            //}

            // Example 4

            //int[] myArray= { 46, 12, 78, 34, 56, 89, 23, 67, 90 };

            //int maxNumber = myArray[0];
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine("En büyük sayı: " + maxNumber);

            #endregion

            #region Dizi Metotları

            // Example 5

            //string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };

            //Console.WriteLine(names.Length); // Dizinin uzunluğunu yazdırır

            // Example 6

            //int[] numbers = {56, 12, 78, 342, 516, 29, 73, 7, 9};

            //Array.Sort(numbers); // Diziyi sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); // Sıralanmış diziyi yazdırır
            //}

            // Example 7

            //int[] numbers = { 56, 12, 78, 342, 516, 29, 73, 7, 9 };

            //Array.Reverse(numbers); // Diziyi ters çevirir
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); // Ters çevrilmiş diziyi yazdırır
            //}

            // Example 8

            //string[] customers = { "Alice", "Bob", "Charlie", "David", "Eve" };

            //int index = Array.IndexOf(customers, "Charlie"); // "Charlie" öğesinin dizideki indeksini bulur
            //if (index != -1)
            //{
            //    Console.WriteLine("Charlie öğesi dizide bulundu. İndeksi: " + index);
            //}
            //else
            //{
            //    Console.WriteLine("Charlie öğesi dizide bulunamadı.");
            //}

            // Example 9

            //int[] numbers = { 56, 12, 78, 342, 516, 29, 73, 7, 9 };

            //Console.WriteLine("Dizinin maximum değeri: " + numbers.Max() + " Dizinin minimum değeri: " + numbers.Min()); 


            #endregion

            #region Kullanıcıdan Dizi Oluşturma

            // Example 10

            //string[] isimler = new string[5];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. ismi giriniz: ");
            //    isimler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Girilen isimler:");
            //Console.WriteLine();

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. isim: {isimler[i]}");
            //}

            // Example 11

            //int[] sayilar = { 67, 12, 78, 342, 516, 29, 73, 7, 9 };
            //int sum = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sum += sayilar[i];
            //}

            //Console.WriteLine("Dizinin toplamı: " + sum);

            // Example 12

            int[] weirdnumbers = { 6, 111, 75, 426, 151, 290, 7, 789, 92 };

            Console.WriteLine("Tek sayılar:");
            Console.WriteLine();
            for (int i = 0; i < weirdnumbers.Length; i++)
            {
                if (weirdnumbers[i] % 2 != 0)
                {
                    Console.WriteLine(weirdnumbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Çift sayılar:");
            Console.WriteLine();
            for (int i = 0; i < weirdnumbers.Length; i++)
            {
                if (weirdnumbers[i] % 2 == 0)
                {
                    Console.WriteLine(weirdnumbers[i]);
                }
            }



            #endregion

            Console.Read();
        }
    }
}
