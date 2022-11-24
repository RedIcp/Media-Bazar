using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBProductManager: IDBProductManagerPM, IDBProductManagerSM
    {
        /* Product Manager*/
        public string CREATE_PRODUCT = "INSERT INTO Product (Name, Barcode, Type, SellingPrice, AmountInDepot, AmountInStore, Discontinued) VALUES (@Name, @Barcode, @Type, @SellingPrice, @AmountInDepot, @AmountInStore, @IsDiscontinued);";
        public string READ_PRODUCTS_PM = "SELECT * FROM Product LIMIT 50;";
        public string UPDATE_PRODUCT_PM = "UPDATE Product SET Name = @Name, Barcode = @Barcode, Type = @Type WHERE ProductID = @ProductID;";

        /* Sales Manager */
        public string READ_PRODUCTS_SM = "SELECT * FROM Product WHERE Discontinued = @Discontinued LIMIT 50;";
        public string READ_NEW_PRODUCTS_SM = "SELECT * FROM Product WHERE SellingPrice = @SellingPrice AND Discontinued = @Discontinued LIMIT 50;";
        public string UPDATE_PRODUCT_SM = "UPDATE Product SET SellingPrice = @SellingPrice, Discontinued = @Discontinued WHERE ProductID = @ProductID;";

        /* All */
        public string SEARCH_PRODUCT_PM = "SELECT * FROM Product WHERE Name LIKE @Search OR Barcode LIKE @Search LIMIT 50;";
        public string GET_PRODUCT_BY_ID = "SELECT * FROM Product WHERE ProductID = @ProductID;";

        public static string GET_ALL_PRODUCT = "SELECT ProductID, Name, Barcode, Type, price, AmountInDepot, SellingPrice FROM Product WHERE Name LIKE '@value%' ORDER BY ProductID;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE ProductID = @ProductID;";

        public static string DISCONTINUE_PRODUCT_BY_ID = "UPDATE Product SET IsDiscontinued = @IsDiscontinued  WHERE ProductID = @ProductID";

        /* Esther Start */

        /* Product Manager */
        public bool CreateProduct(Product p)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Name", p.ProductName);
                cmd.Parameters.AddWithValue("@Barcode", p.Barcode);
                cmd.Parameters.AddWithValue("@Type", p.ProductType);
                cmd.Parameters.AddWithValue("@SellingPrice", p.SellingPrice);
                cmd.Parameters.AddWithValue("@AmountInDepot", p.AmountInDepot);
                cmd.Parameters.AddWithValue("@AmountInStore", p.AmountInStore);
                cmd.Parameters.AddWithValue("@IsDiscontinued", p.IsDiscontinued);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return false;
        }

        public List<Product> ReadProductsPM()
        {
            List<Product> products = new List<Product>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_PRODUCTS_PM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    products.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return products;
        }

        public bool UpdateProductPM(Product p)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_PRODUCT_PM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ProductID", p.ProductID);

                cmd.Parameters.AddWithValue("@Name", p.ProductName);
                cmd.Parameters.AddWithValue("@Barcode", p.Barcode);
                cmd.Parameters.AddWithValue("@Type", p.ProductType);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if(numCreatedRows == 1)
                {
                    return true;
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return false;
        }

        public List<Product> SearchProducts(string search)
        {
            List<Product> products = new List<Product>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = SEARCH_PRODUCT_PM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    products.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return products;
        }
        public Product GetProductByID(int productID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_PRODUCT_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ProductID", productID);

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    return product;
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }
        /* Sales Manager Start*/
        public List<Product> ReadProductsSM()
        {
            List<Product> products = new List<Product>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_PRODUCTS_SM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Discontinued", false);

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    products.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return products;
        }
        public List<Product> ReadNewProductsSM()
        {
            List<Product> products = new List<Product>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_NEW_PRODUCTS_SM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@SellingPrice", 0);
                cmd.Parameters.AddWithValue("@Discontinued", false);

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    products.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return products;
        }
        public bool UpdateProductSM(Product p)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_PRODUCT_SM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ProductID", p.ProductID);

                cmd.Parameters.AddWithValue("@SellingPrice", p.SellingPrice);
                cmd.Parameters.AddWithValue("@Discontinued", p.IsDiscontinued);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return false;
        }
        /* Sales Manager End */

        /* Esther End */

        //MohammadStart
        public static string GET_PRODUCTS = "SELECT * FROM product";

        public List<Product> RemoteProducts { get; set; }

        public void GetProduct()
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_PRODUCTS;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                Product product;
                while (reader.Read())
                {
                    int productID = reader.GetInt32("ProductID");
                    string barcode = reader.GetString("Barcode");
                    string name = reader.GetString("Name");
                    string productType = reader.GetString("Type");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");
                    int sellingPrice = reader.GetInt32("Price");
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, name, productType, barcode, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    if (!product.IsDiscontinued)
                    {
                        RemoteProducts.Add(product);
                        Products.Add(product);
                    }
                }

            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        //MohammadEnd
        public List<Product> Products { get; set; }

        public DBProductManager()
        {
            Products = new List<Product>();
            RemoteProducts = new List<Product>();
        }
    }
}
