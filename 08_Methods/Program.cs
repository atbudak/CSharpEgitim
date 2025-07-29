using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar

            //()
            //Geriye deger donmeyen metotlar
            //customer --> Listele, ekle, sil, guncelle
            //void Metodlar

            // Examle 1
            //void CustomerList()
            //{
            //    Console.WriteLine("Hasam");
            //    Console.WriteLine("Mehmet");
            //    Console.WriteLine("Ali");
            //}

            //CustomerList();

            // Example 2
            //void sum(int a, int b)
            //{
            //    Console.WriteLine(a + b);
            //}

            //sum(5, 10);

            // Example 3
            //void customerList(string name, string surname)
            //{
            //    Console.WriteLine("Name: " + name);
            //    Console.WriteLine("Surname: " + surname);
            //}
            //customerList("Hasan", "Yılmaz");

            #endregion

            #region Geriye Değer Döndüren Metodlar

            // Example 1
            //string customerName()
            //{
            //    return "Hasan Yılmaz";
            //}
            //customerName();

            // Example 2
            //string studentCard()
            //{
            //    string name = "Hasan Yılmaz";
            //    string studentNumber = "123456";

            //    return name + " - " + studentNumber;
            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Deger Döndüren String Parametreli Metodlar

            //string customerCard(string name, string surname, string studentNumber)
            //{
            //    string cardInfo = "Name: " + name + ", Surname: " + surname + ", Student Number: " + studentNumber;
            //    return cardInfo;
            //}

            //Console.Write("Müisteri Adı: ");
            //string customerName = Console.ReadLine();
            //Console.Write("Müisteri Soyadı: ");
            //string customerSurname = Console.ReadLine();
            //Console.Write("Müisteri Numarası: ");
            //string customerNumber = Console.ReadLine();
            //Console.WriteLine(customerCard(customerName, customerSurname, customerNumber));

            #endregion

            #region Geriye Deger Döndüren Int Parametreli Metodlar

            //int sum(int a, int b)
            //{
            //    return a + b;
            //}   

            //Console.Write("Birinci Sayı: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci Sayı: ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Toplam: " + sum(firstNumber, secondNumber));

            #endregion

            #region Örnek Metod

            //string studentResult(string name, string surname, int exam1, int exam2)
            //{
            //    double average = (exam1 + exam2) / 2.0;
            //    string result = average >= 50 ? "Geçti" : "Kaldı";
            //    return $"Öğrenci: {name} {surname}, Not Ortalaması: {average}, Sonuç: {result}";
            //}


            //Console.WriteLine(studentResult("Ali", "Çınar", 76, 55));
            //Console.WriteLine(studentResult("Ayşe", "Demir", 45, 60));
            //Console.WriteLine(studentResult("Mehmet", "Yılmaz", 80, 10));

            #endregion

            #region out-ref Metodlar

            // Example 1
            //int ageInMonths(ref int age)
            //{
            //    // age parametresini referans olarak alır ve ay cinsinden yaşını hesaplar
            //    return age * 12;
            //}

            //Console.Write("Yaşınızı giriniz: ");
            //int result = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Yaşınız: {ageInMonths(ref result)} aydır.");

            // Example 2
            //void IlkDegeriUret(out int deger)
            //{
            //    deger = 42; // out parametreler mutlaka atanmalıdır!
            //}

            //// Kullanım
            //int sonuc;
            //IlkDegeriUret(out sonuc);
            //Console.WriteLine(sonuc); // Çıktı: 42

            // Example 3

            //void Degistir(ref int a, ref int b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}

            //// Kullanım
            //int sayi1 = 5, sayi2 = 10;
            //Degistir(ref sayi1, ref sayi2);
            //Console.WriteLine($"sayi1: {sayi1}, sayi2: {sayi2}"); // Çıktı: 10, 5

            // Example 4

            //bool KullaniciGetir(string kullaniciAdi, out string email)
            //{
            //    if (kullaniciAdi == "ahmetbudak")
            //    {
            //        email = "ahmet@ornek.com";
            //        return true;
            //    }
            //    email = null;
            //    return false;
            //}

            //// Kullanım
            //if (KullaniciGetir("ahmetbudak", out string eposta))
            //{
            //    Console.WriteLine("Kullanıcı bulundu: " + eposta);
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı bulunamadı.");
            //}

            //Değişkenin hem giriş hem çıkış olması gerekiyorsa   ref
            //Değeri sadece metot içinde üretip döndüreceksen	    out
            //Try - parse, kullanıcı doğrulama gibi senaryolarda	out
            //Swap(yer değiştirme) gibi işlemlerde                ref

            // Yeni C# sürümlerinde ref/out yerine tuple da kullanılabilir -->

            (string email, bool bulundu) KullaniciGetir(string kullaniciAdi)
            {
                if (kullaniciAdi == "ahmetbudak")
                    return ("ahmet@ornek.com", true);
                return (null, false);
            }

            var (eposta, bulunduMu) = KullaniciGetir("ahmetbudak");

            if (bulunduMu)
            {
                Console.WriteLine("Kullanıcı bulundu: " + eposta);
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı.");
            }


            #endregion

            Console.Read();

        }
    }
}
