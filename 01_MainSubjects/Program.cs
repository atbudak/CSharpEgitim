using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari
            //Console.Write("Merhaba, Dünya!");
            //Console.WriteLine(" Bu, C# dilinde yazılmış bir programdır.");

            //Console.WriteLine("**** Yemek katagorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1. Kahvaltılık");
            //Console.WriteLine("2. Çorba");
            //Console.WriteLine("3. Salata");
            //Console.WriteLine("4. Et yemekleri");
            //Console.WriteLine("5. Sebze yemekleri");
            //Console.WriteLine("6. Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek katagorileri ****");

            #endregion

            #region StringDegiskenler

            ////string name;
            ////name = "Ahmet";
            ////Console.WriteLine("Merhaba, " + name + "!");

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Veli";
            //customerPhone = "+90 500 123 12 12";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("Müşteri Bilgileri:");
            //Console.WriteLine();
            //Console.WriteLine("*****************************************");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);            
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("*****************************************");


            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 123 11 22";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine();
            //Console.WriteLine("*****************************************");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("*****************************************");



            #endregion

            #region Int Degiskenler

            //int number1 = 10;
            //Console.WriteLine("number1: " + number1);

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 300;
            int lemonadePrice = 40;
            Console.WriteLine("**** Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Su: " + waterPrice + " TL");
            Console.WriteLine("Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 1;
            int waterCount = 2;
            int friesCount = 3;
            int pizzaCount = 1;
            int lemonadeCount = 2;

            int totalPrice = hamburgerCount*hamburgerPrice + 
                cokeCount*cokePrice + 
                waterCount*waterPrice + 
                friesCount*friesPrice +
                pizzaCount*pizzaPrice +
                lemonadeCount*lemonadePrice;

            Console.WriteLine("Hesap Ücreti: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}


