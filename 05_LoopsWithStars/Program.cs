using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yıldızlarla Dik Üçgen

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Ters Dik Üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Dik ve Ters Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Baklava Dilimi

            //// üst kısım
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //        Console.Write("*");
            //    }

            //    for (int k = 1; k <= i - 1; k++)
            //    {
            //        Console.Write(" ");
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            //// alt kısım
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //        Console.Write("*");
            //    }
            //    for (int k = 4; k >= i + 1; k--)
            //    {
            //        Console.Write(" ");
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Pramid Üçgen

            //int n = 5; // Yıldızların en yüksek satırı

            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdır
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdır
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    // Yeni satıra geç
            //    Console.WriteLine();
            //}
            #endregion

            #region İçi Boş Piramit
            int rows = 5; // Piramitin satır sayısı
            for (int i = 1; i <= rows; i++)
            {
                // Boşlukları yazdır
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızları yazdır
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    if (k == 1 || k == (2 * i - 1) || i == rows)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                // Yeni satıra geç
                Console.WriteLine();
            }
            #endregion


            Console.Read();

        }
    }
}
