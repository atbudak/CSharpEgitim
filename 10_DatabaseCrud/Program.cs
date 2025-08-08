using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CRUD -> Create, Read, Update, Delete

            Console.WriteLine("**** Menu Sipariş İşlem Paneli ****");
            Console.WriteLine();

            #region kategori ekleme
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Eklemek istediğiniz kategori adını giriniz:");
            //string kategoriAdi = Console.ReadLine();
            //Console.WriteLine("------------------------");

            //string conStr = "Server=localhost;Database=EgitimKampiDB;Trusted_Connection=True;";
            //string sqlQuery = "INSERT INTO TBL_CATEGORY (CategoryName) VALUES (@CategoryName)";

            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    connection.Open();
            //    Console.WriteLine("Bağlandı. SQL Server versiyonu: " + connection.ServerVersion);

            //    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            //    {
            //        command.Parameters.AddWithValue("@CategoryName", kategoriAdi);
            //        int result = command.ExecuteNonQuery();
            //        if (result > 0)
            //        {
            //            Console.WriteLine("Kategori başarıyla eklendi.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kategori eklenemedi.");
            //        }
            //    }             
            //}

            #endregion

            #region ürün ekleme

            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //try
            //{
            //    Console.WriteLine("------------------------");
            //    Console.Write("Eklemek istediğiniz ürün adını giriniz:");
            //    productName = Console.ReadLine();
            //    Console.Write("Eklemek istediğiniz ürün fiyatını giriniz:");
            //    productPrice = Convert.ToDecimal(Console.ReadLine());
            //    Console.Write("Eklemek istediğiniz hali hazırda mevcut mu:  (Mevcut(m)/Mevcut Değil(md)):");
            //    string input = Console.ReadLine().ToLower();
            //    if (input == "m" || input == "mevcut")
            //        productStatus = true;
            //    else if (input == "md" || input == "mevcut değil")
            //        productStatus = false;
            //    else
            //    {
            //        Console.WriteLine("Lütfen 'm', 'mevcut' veya 'md', 'mevcut değil' değerlerinden birini giriniz.");
            //        return;
            //    }
            //    Console.WriteLine("------------------------");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Hatalı giriş: " + ex.Message);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
            //    return;
            //}

            //string conStr = "Server=localhost;Database=EgitimKampiDB;Trusted_Connection=True;";
            //string sqlQuery = "INSERT INTO TBL_PRODUCT (ProductName, ProductPrice, ProductStatus) VALUES (@ProductName, @ProductPrice, @ProductStatus)";

            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    connection.Open();
            //    //Console.WriteLine("Bağlandı. SQL Server versiyonu: " + connection.ServerVersion);
            //    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            //    {
            //        command.Parameters.AddWithValue("@ProductName", productName);
            //        command.Parameters.AddWithValue("@ProductPrice", productPrice);
            //        command.Parameters.AddWithValue("@ProductStatus", productStatus);
            //        int result = command.ExecuteNonQuery();
            //        if (result > 0)
            //        {
            //            Console.WriteLine("Ürün başarıyla eklendi.");
            //            Console.WriteLine($"Ürün Adı: {productName}, Ürün Fiyatı: {productPrice}, Ürün Durumu: {(productStatus ? "Mevcut" : "Mevcut Değil")}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ürün eklenemedi.");
            //        }
            //    }
            //}

            #endregion

            #region ürün listeleme

            //string conStr = "Server=localhost;Database=EgitimKampiDB;Trusted_Connection=True;";
            //string sqlQuery = "SELECT * FROM TBL_PRODUCT";
            //DataTable dataTable = new DataTable();

            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    connection.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            //    adapter.Fill(dataTable);
            //}
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (DataColumn column in dataTable.Columns)
            //    {
            //        Console.Write($"{column.ColumnName}: {row[column]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ürün silme

            //Console.Write("Silinecek ürünün ID'sini giriniz:");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //string conStr = "Server=localhost;Database=EgitimKampiDB;Trusted_Connection=True;";
            //string sqlQuery = "DELETE FROM TBL_PRODUCT WHERE ProductID = @ProductID";

            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    connection.Open();
            //    //Console.WriteLine("Bağlandı. SQL Server versiyonu: " + connection.ServerVersion);
            //    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            //    {
            //        command.Parameters.AddWithValue("@ProductID", productId);
            //        int result = command.ExecuteNonQuery();
            //        if (result > 0)
            //        {
            //            Console.WriteLine("Ürün başarıyla silindi.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Silinecek ürün bulunamadı.");
            //        }
            //    }
            //}

            #endregion

            #region ürün güncelleme

            string conStr = "Server=localhost;Database=EgitimKampiDB;Trusted_Connection=True;";
            string sqlQuery = "UPDATE TBL_PRODUCT SET ProductName = @ProductName, ProductPrice = @ProductPrice, ProductStatus = @ProductStatus WHERE ProductID = @ProductID";

            Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                //Console.WriteLine("Bağlandı. SQL Server versiyonu: " + connection.ServerVersion);

                try
                {
                    Console.Write("Güncellenecek ürün adını giriniz: ");
                    string productName = Console.ReadLine();
                    Console.Write("Güncellenecek ürün fiyatını giriniz: ");
                    decimal productPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Güncenecek ürün hali hazırda mevcut mu:  (Mevcut(m)/Mevcut Değil(md)): ");
                    string input = Console.ReadLine().ToLower();
                    bool productStatus = (input == "md" || input == "mevcut değil") ? false : true;

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@ProductPrice", productPrice);
                        command.Parameters.AddWithValue("@ProductStatus", productStatus);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Ürün başarıyla güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Güncellenecek ürün bulunamadı.");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Hatalı giriş: " + ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
                    return;
                }
            }

            #endregion


            Console.Read();
        }
    }
}
