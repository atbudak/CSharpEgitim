using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if-else

            // Example 1

            //Console.WriteLine("Enter a password(must be at least 8 characters long, contain uppercase and lowercase letter, and one digit.):");
            //string password = Console.ReadLine();
            //if (password.Length < 8)
            //{
            //    Console.WriteLine("Password is too short. It must be at least 8 characters long.");
            //}
            //else if (!password.Any(char.IsUpper))
            //{
            //    Console.WriteLine("Password must contain at least one uppercase letter.");
            //}
            //else if (!password.Any(char.IsLower))
            //{
            //    Console.WriteLine("Password must contain at least one lowercase letter.");
            //}
            //else if (!password.Any(char.IsDigit))
            //{
            //    Console.WriteLine("Password must contain at least one digit.");
            //}
            //else
            //{
            //    Console.WriteLine("Password is valid.");
            //}


            // Example 2

            //Console.WriteLine("Enter a number:");
            //int x = Convert.ToInt32(Console.ReadLine());

            //if (x > 0)
            //    Console.WriteLine("Pozitif");
            //else
            //    Console.WriteLine("Negatif"); 

            // Example 3

            //Console.WriteLine("Enter a your age:");
            //int age = int.Parse(Console.ReadLine());
            //string durum = (age >= 18) ? "Yetişkin" : "Çocuk";
            //Console.WriteLine($"Yaşınız: {age}, Durumunuz: {durum}");


            #endregion

            #region Mod Yapıları

            // Example 1

            //Console.WriteLine("Enter a number 1:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number 2:");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine($"The result of {number1} % {number2} is: {result}");

            // Example 2

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //string result = (number % 2 == 0) ? "Çift sayıdır." : "Tek sayıdır.";
            //Console.WriteLine(result);

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;

            //Console.WriteLine("Enter your team (B, F, G):");
            //team = Convert.ToChar(Console.ReadLine());

            //if (team== 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else
            //{
            //    Console.WriteLine("Bilinmeyen takım.");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** Restaurant Menu ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1. Pizza");
            //Console.WriteLine("2. Hamburger");
            //Console.WriteLine("3. Kumpir");
            //Console.WriteLine("4. Tatlılar");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //Console.Write("Lütfen sipariş vermek istediğiniz menü numarasını giriniz: ");

            //int menuNumber = Convert.ToInt32(Console.ReadLine());

            //if (menuNumber == 1)
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizza Menüsü-----------");
            //    Console.WriteLine("1. Margherita Pizza - 30 TL");
            //    Console.WriteLine("2. Pepperoni Pizza - 35 TL");
            //    Console.WriteLine("3. Vejetaryen Pizza - 32 TL");
            //    Console.WriteLine("----------------------------------");
            //    Console.WriteLine();
            //}
            //else if (menuNumber == 2)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Hamburger Menüsü-----------");
            //    Console.WriteLine("1. Cheeseburger - 25 TL");
            //    Console.WriteLine("2. Double Burger - 30 TL");
            //    Console.WriteLine("3. Veggie Burger - 28 TL");
            //    Console.WriteLine("---------------------------------------");
            //    Console.WriteLine();
            //}
            //else if (menuNumber == 3)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Kumpir Menüsü-----------");
            //    Console.WriteLine("1. Kumpir - 20 TL");
            //    Console.WriteLine("2. Kumpir (Sade) - 18 TL");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine();
            //}
            //else if (menuNumber == 4)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar Menüsü-----------");
            //    Console.WriteLine("1. Baklava - 15 TL");
            //    Console.WriteLine("2. Sütlaç - 10 TL");
            //    Console.WriteLine("3. Profiterol - 12 TL");
            //    Console.WriteLine("-------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz menü numarası. Lütfen 1-4 arasında bir numara giriniz.");
            //    Console.ReadLine();
            //    return; // Programı sonlandır
            //}

            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen ayın numarasını giriniz (1-12):");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;


            //    default: Console.WriteLine("Geçersiz ay numarası. Lütfen 1-12 arasında bir numara giriniz."); break;
            //}

            #endregion


            #region Hesap Makinesi Uygulaması

            int sayi1, sayi2;
            char islem;
            Console.WriteLine("Hesap Makinesi Uygulamasına Hoş Geldiniz!");
            Console.WriteLine();
            Console.Write("Lütfen ilk sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz(+,-,*,/):");
            islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
                    break;
                case '-':
                    Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
                    break;
                case '*':
                    Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
                    break;
                case '/':
                    if (sayi2 != 0)
                        Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
                    else
                        Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
                    break;
                default:
                    break;
            }

            #endregion

            Console.ReadLine();
        }
    }
}
