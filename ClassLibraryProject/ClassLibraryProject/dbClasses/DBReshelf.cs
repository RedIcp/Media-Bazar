using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBReshelf: IDBReshelf
    {
        private string GET_ALL_PRODUCTS = "SELECT * FROM product WHERE Discontinued = 0;";

        private string GET_ALL_RESHELVES = "SELECT * FROM reshelf;";

        //depot
        private string COMPLETE_RESHELF = "UPDATE reshelf SET Status = 'Fulfilled'  WHERE ID = @ID;";
        private string DELETE_RESHELF = "DELETE FROM reshelf WHERE ID = @ID;";
        private string CHANGE_AMOUNT_DEPOT = "UPDATE product SET AmountInDepot = @Amount WHERE Barcode = @Barcode;";
        private string CHANGE_AMOUNT_STORE = "UPDATE product SET AmountInStore = @Amount WHERE Barcode = @Barcode;";

        //sales
        private string REQUEST_RESHELF = "INSERT INTO reshelf (ID, ProductBarcode, Amount, Status) VALUES (@ID, @Barcode, @Amount, 'Pending');";

        private List<Reshelf> reshelves;
        private List<Product> products;

        public List<Reshelf> GetReshelfRequests()
        {
            return reshelves;
        }

        public DBReshelf()
        {
            reshelves = new List<Reshelf>();
            products = new List<Product>();

            GetAllProducts();
            GetAllReshelves();
        }
        
        private void GetAllReshelves()
        {
            reshelves.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_RESHELVES;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Reshelf reshelf;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string barcode = reader.GetString("ProductBarcode");
                    int amount = reader.GetInt32("Amount");
                    string status = reader.GetString("Status");

                    if (GetProduct(barcode) != null)
                    {
                        reshelf = new Reshelf(id, GetProduct(barcode), amount, status);
                        reshelves.Add(reshelf);
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

        //sales
        public Product GetProduct(string barcode)
        {
            foreach(Product product in products)
            {
                if(product.Barcode == barcode)
                {
                    return product;
                }
            }
            return null;
        }
        private void GetAllProducts()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_PRODUCTS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ProductID");
                    string barcode = reader.GetString("Barcode");
                    string name = reader.GetString("Name");
                    string type = reader.GetString("Type");
                    double sellingPrice = reader.GetDouble("SellingPrice");
                    int amountDepot = reader.GetInt32("AmountInDepot");
                    int amountStore = reader.GetInt32("AmountInStore");

                    product = new Product(id, name, barcode, type, sellingPrice, amountDepot, amountStore, false);
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
        }
        public bool RequestReshelf(int id, Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = REQUEST_RESHELF;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Reshelf reshelf = new Reshelf(id, product, amount);
                    reshelves.Add(reshelf);
                    return true;
                }
                return false;
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

        //depot
        public bool DeleteReshelf(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_RESHELF;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    return true;
                }
                return false;
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
        public bool CompleteReshelf(int id)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = COMPLETE_RESHELF;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Reshelf reshelf in reshelves)
                    {
                        if (reshelf.ID == id)
                        {
                            reshelf.Status = "Fulfilled";
                        }
                    }
                    return true;
                }
                return false;
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
        public bool ChangeAmountDepot(Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CHANGE_AMOUNT_DEPOT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    product.AmountInDepot = amount;
                    return true;
                }
                return false;
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
        public bool ChangeAmountStore(Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CHANGE_AMOUNT_STORE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    product.AmountInDepot = amount;
                    return true;
                }
                return false;
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
    }
}
