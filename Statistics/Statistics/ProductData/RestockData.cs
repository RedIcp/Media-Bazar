using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Statistics.ProductData
{
    class RestockData
    {
        private static string RESTOCK_AMOUNT = "SELECT Name, COUNT(product.ProductID) FROM `product` INNER JOIN restock ON product.barcode = restock.ProductBarcode GROUP BY product.barcode;";
        private static string RESTOCK_PRODUCT_AMOUNT = "SELECT Name, sum(restock.Amount) FROM `product` INNER JOIN restock ON product.barcode = restock.ProductBarcode GROUP BY product.barcode  HAVING sum(restock.Amount) > 1;";
       
        public ProductsData[] RestockAmount()
        {
            List<ProductsData> products = new List<ProductsData>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = RESTOCK_AMOUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ProductsData productsData;

                while (reader.Read())
                {
                    productsData = new ProductsData(reader[0].ToString(), Convert.ToInt32(reader[1]));
                    products.Add(productsData);
                }

                return products.ToArray();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return products.ToArray();
        }

        public ProductsData[] RestockProductAmount()
        {

            List<ProductsData> products = new List<ProductsData>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = RESTOCK_PRODUCT_AMOUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ProductsData productsData;

                while (reader.Read())
                {

                    productsData = new ProductsData(reader[0].ToString(), Convert.ToInt32(reader[1]));
                    products.Add(productsData);

                }

                return products.ToArray();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return products.ToArray();
        }
    }
}
