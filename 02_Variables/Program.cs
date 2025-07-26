using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler

            //double elmaFiyati = 35.5;
            //double armutFiyati = 25.75;
            //double muzFiyati = 15.99;
            //double soganFiyati = 10.5;
            //double patatesFiyati = 12.25;

            //Console.WriteLine("**** Meyve ve Sebze Fiyatları ****");
            //Console.WriteLine();
            //Console.WriteLine("Elma Birim Fiyatı: " + elmaFiyati + " TL");
            //Console.WriteLine("Armut Birim Fiyatı: " + armutFiyati + " TL");
            //Console.WriteLine("Muz Birim Fiyatı: " + muzFiyati + " TL");
            //Console.WriteLine("Soğan Birim Fiyatı: " + soganFiyati + " TL");
            //Console.WriteLine("Patates Birim Fiyatı: " + patatesFiyati + " TL");

            //double elmaGram, armutGram, muzGram, soganGram, patatesGram;

            //elmaGram = 1.252;
            //armutGram = 1.125;
            //muzGram = 0.775;
            //soganGram = 2.121;
            //patatesGram = 3.581;

            //double elmaFiyatiKg = elmaFiyati * elmaGram;
            //double armutFiyatiKg = armutFiyati * armutGram;
            //double muzFiyatiKg = muzFiyati * muzGram;
            //double soganFiyatiKg = soganFiyati * soganGram;
            //double patatesFiyatiKg = patatesFiyati * patatesGram;

            //double toplamTutar = elmaFiyatiKg + armutFiyatiKg + muzFiyatiKg + soganFiyatiKg + patatesFiyatiKg;

            //Console.WriteLine($"\nAlınan Ürün : Elma - Brim Fiyatı: {elmaFiyati} - Gramaj: {elmaGram} \nToplam Tutar: {elmaFiyatiKg:F2}");
            //Console.WriteLine($"\nAlınan Ürün : Armut - Brim Fiyatı: {armutFiyati} - Gramaj: {armutGram} \nToplam Tutar: {armutFiyatiKg:F2}");
            //Console.WriteLine($"\nAlınan Ürün : Muz - Brim Fiyatı: {muzFiyati} - Gramaj: {muzGram} \nToplam Tutar: {muzFiyatiKg:F2}");
            //Console.WriteLine($"\nAlınan Ürün : Soğan - Brim Fiyatı: {soganFiyati} - Gramaj: {soganGram} \nToplam Tutar: {soganFiyatiKg:F2}");
            //Console.WriteLine($"\nAlınan Ürün : Patates - Brim Fiyatı: {patatesFiyati} - Gramaj: {patatesGram} \nToplam Tutar: {patatesFiyatiKg:F2}");

            //Console.WriteLine($"\nToplam Tutar: {toplamTutar:F2} TL");

            #endregion

            #region Char Degiskenler

            // char değerleri ring gibi tek karakterli veri tipidir. Değerleri tek tırnak içinde tanımlanır. Değişenler tek karakterli veri tutar.
            //char harf1 = 'A';
            //Console.WriteLine("Harf 1: " + harf1);

            #endregion

            #region Klavyeden String Veri Girişleri

            //Console.WriteLine("**** Hava Yolları Yolcu Bilgileri ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerPhone, passengerEmail, passengerCity, passengerDistrict;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Telefonu: ");
            //passengerPhone = Console.ReadLine();

            //Console.Write("Yolcu E-posta: ");
            //passengerEmail = Console.ReadLine();

            //Console.Write("Yolcu Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("*****************************************");
            //Console.WriteLine("Yolcu Bilgileri:");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Telefon: " + passengerPhone);
            //Console.WriteLine("E-posta: " + passengerEmail);
            //Console.WriteLine("Adres: " + passengerDistrict + "/" + passengerCity);

            #endregion

            #region Klavyeden Tam Sayı Veri Girişleri ve Dönüşümler

            //int shoePrice, shirtPrice, pantsPrice, jacketPrice;

            //shoePrice = 3250;
            //shirtPrice = 500;
            //pantsPrice = 750;
            //jacketPrice = 1500;

            //int shoeCount = 0, shirtCount = 0, pantsCount = 0, jacketCount = 0, totalPrice = 0;

            //try
            //{
            //    Console.Write("Ayakkabı Adedi: ");
            //    shoeCount = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Gömlek Adedi: ");
            //    shirtCount = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Pantolon Adedi: ");
            //    pantsCount = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Ceket Adedi: ");
            //    jacketCount = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            //    Console.ReadLine();
            //    return; // Programı sonlandır
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Lütfen daha küçük bir sayı giriniz.");
            //    Console.ReadLine();
            //    return; // Programı sonlandır
            //}


            //totalPrice = (shoeCount * shoePrice) + (shirtCount * shirtPrice) + (pantsCount * pantsPrice) + (jacketCount * jacketPrice);

            //Console.WriteLine("**** Alışveriş Özeti ****");
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");




            #endregion

            #region Klavyeden Ondalıklı Sayı Veri Girişleri ve Dönüşümler

            //double examScore1, examScore2, examScore3;

            //double averageScore;

            //Console.WriteLine("**** Öğrenci Not Hesaplama ****");
            //Console.WriteLine();

            //Console.Write("1. Sınav Notu: ");
            //examScore1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sınav Notu: ");
            //examScore2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("3. Sınav Notu: ");
            //examScore3 = Convert.ToDouble(Console.ReadLine());

            //averageScore = (examScore1 + examScore2 + examScore3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("**** Not Bilgileri ****");
            //Console.WriteLine($"Sınav Notu Ortalaması: {averageScore:F2}");

            #endregion

            #region Klavyeden Karakter Veri Girişleri

            char gender;
            Console.WriteLine("**** Cinsiyet Bilgisi ****");
            Console.Write("Cinsiyet (E/K): ");
            gender = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine($"Seçilen Cinsiyet : {gender}");

            #endregion

            Console.Read();

        }
    }
}
