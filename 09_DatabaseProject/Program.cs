using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.Net

            Console.WriteLine("C# Tabanlı Ürün Kategori Listesi");
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("1. Kateriler");
            Console.WriteLine("2. Ürünler");
            Console.WriteLine("3. Siparişler");
            Console.WriteLine("4. Çıkış");
            Console.WriteLine("=================================");

            int tableNumber;
            Console.Write("Lütfen getirmek istediğini tablo numarasını giriniz: ");
            tableNumber = Convert.ToInt32(Console.ReadLine());

            string tableValue = string.Empty;

            switch (tableNumber)
            {
                case 1:
                    tableValue = "TBL_CATEGORY";
                    break;
                case 2:
                    tableValue = "TBL_PRODUCT";
                    break;
                case 3:
                    tableValue = "TBL_ORDER";
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz tablo numarası. Lütfen 1-4 arasında bir sayı giriniz.");
                    return;
            }

            Console.WriteLine("Seçilen Tablo: " + tableValue);

            string conStr = "Data Source=localhost;Initial Catalog=EgitimKampiDB;Integrated Security=True";
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                //Console.WriteLine("Bağlandı. SQL Server versiyonu: " + connection.ServerVersion);
                SqlCommand command = new SqlCommand($"SELECT * FROM {tableValue};", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL hata: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Geçersiz işlem: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen hata: " + ex.Message);
            }


            if (dataTable.Rows.Count == 0)
            {
                Console.WriteLine("Tablo boş.");
                return;
            }
            else
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (tableValue == "TBL_CATEGORY")
                    {
                        Console.Write("Kategori ID: " + row["CategoryID"] + " " + "Kategori Adı: " + row["CategoryName"]);
                        Console.WriteLine();
                    }
                    else if (tableValue == "TBL_PRODUCT")
                    {
                        Console.WriteLine($"Ürün ID: {row["ProductID"]} Ürün Adı: {row["ProductName"]} Ürün Fiyatı: {row["ProductPrice"]} Ürün Mevcut mu: {((bool)row["ProductStatus"] ? "Mevcut." : "Mevcut Değil.")}");
                        Console.WriteLine();
                    }
                    else if (tableValue == "TBL_ORDER")
                    {
                        Console.WriteLine("Sipariş ID: " + row["OrderID"]);
                        Console.WriteLine();
                    }
                }


                Console.Read();
            }
        }
    }
}