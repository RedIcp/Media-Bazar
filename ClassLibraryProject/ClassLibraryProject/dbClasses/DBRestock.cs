using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
    public class DBRestock : IDBRestock
    {
        private string GET_ALL_SUPPLIERS = "SELECT * FROM supplier;";
        private string GET_ALL_PRODUCTS = "SELECT * FROM product WHERE Discontinued = 0;";
        private string GET_ALL_ORDER_INFOS = "SELECT * FROM orderinfo;";

        private string GET_ALL_RESTOCKS = "SELECT * FROM restock;";

        //employee
        private string ADD_RESTOCK_REQUEST = "INSERT INTO restock (ID, ProductBarcode, Amount, Status, OrderInfoID) VALUES (@ID, @Barcode, 0, 'Pending', 0);";
        private string RECEIVE_RESTOCK = "UPDATE restock SET Status = 'Fulfilled' WHERE ID = @ID;";
        private string CHANGE_AMOUNT = "UPDATE product SET AmountInDepot = @Amount WHERE Barcode = @Barcode;";

        //manager
        private string ORDER_RESTOCK = "UPDATE restock SET Status = 'Ordered', Amount = @Amount, OrderInfoID = @OrderID WHERE ID = @ID;";
        private string DELETE_RESTOCK_BY_ID = "DELETE FROM restock WHERE ID = @ID;";

        private List<Restock> restocks;
        private List<Product> products;
        private List<OrderInfo> orderInfos;
        private List<Supplier> suppliers;

        public List<Restock> GetRestockRequests()
        {
            return restocks;
        }

        public DBRestock()
        {
            restocks = new List<Restock>();
            products = new List<Product>();
            orderInfos = new List<OrderInfo>();
            suppliers = new List<Supplier>();

            GetAllProducts();
            GetAllSuppliers();
            GetAllOrderInfos();
            GetAllRestocks();
        }

        //product
        public Product GetProduct(string barcode)
        {
            foreach (Product product in products)
            {
                if (product.Barcode == barcode)
                {
                    return product;
                }
            }
            return null;
        }
        private void GetAllProducts() //Conn not closing
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
                conn.Close();
            }
        }

        //supplier
        private Supplier GetSupplier(int id)
        {
            foreach (Supplier supplier in suppliers)
            {
                if (supplier.ID == id)
                {
                    return supplier;
                }
            }
            return null;
        }
        private void GetAllSuppliers()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_SUPPLIERS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Supplier supplier;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string name = reader.GetString("Name");
                    string country = reader.GetString("Country");
                    int buildingNumber = reader.GetInt32("BuildingNumber");
                    string postalCode = reader.GetString("PostalCode");
                    string email = reader.GetString("Email");
                    string phoneNumber = reader.GetString("PhoneNumber");
                    string bankNumber = reader.GetString("BankNumber");
                    string productType = reader.GetString("ProductType");

                    supplier = new Supplier(id, name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber, productType);
                    suppliers.Add(supplier);
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

        //order info
        private OrderInfo GetOrderInfo(int id)
        {
            foreach (OrderInfo orderInfo in orderInfos)
            {
                if (orderInfo.ID == id)
                {
                    return orderInfo;
                }
            }
            return null;
        }
        private void GetAllOrderInfos()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ORDER_INFOS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                OrderInfo orderinfo;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    int supplierID = reader.GetInt32("SupplierID");
                    string barcode = reader.GetString("ProductBarcode");
                    int minAmount = reader.GetInt32("MinAmount");
                    int maxAmount = reader.GetInt32("MaxAmount");
                    int multiples = reader.GetInt32("Multiples");
                    double purchasePrice = reader.GetDouble("PurchasePrice");

                    if (GetSupplier(supplierID) != null && GetProduct(barcode) != null)
                    {
                        orderinfo = new OrderInfo(id, GetSupplier(supplierID), GetProduct(barcode), minAmount, maxAmount, multiples, purchasePrice);
                        orderInfos.Add(orderinfo);
                        GetProduct(barcode).OrderInfos.Add(orderinfo);
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

        //restock
        private void GetAllRestocks()
        {
            restocks.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_RESTOCKS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Restock restock;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string barcode = reader.GetString("ProductBarcode");
                    int amount = reader.GetInt32("Amount");
                    string status = reader.GetString("Status");
                    int orderID = reader.GetInt32("OrderInfoID");


                    if (GetProduct(barcode) != null)
                    {
                        if (GetOrderInfo(orderID) == null)
                        {
                            restock = new Restock(id, GetProduct(barcode));
                            restocks.Add(restock);
                        }
                        else
                        {
                            restock = new Restock(id, GetProduct(barcode), GetOrderInfo(orderID), amount, status);
                            restocks.Add(restock);
                        }
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

        //manager
        public bool DeleteRestock(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_RESTOCK_BY_ID;

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
        public bool OrderRestock(int id, OrderInfo orderInfo, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = ORDER_RESTOCK;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@OrderID", orderInfo.ID);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Restock restock in restocks)
                    {
                        if (restock.ID == id)
                        {
                            restock.Status = "Ordered";
                            restock.OrderInfo = orderInfo;
                            restock.AmountRequested = amount;
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

        //employee
        public bool RequestRestock(int id, Product product)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = ADD_RESTOCK_REQUEST;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Restock restock = new Restock(id, product);
                    restocks.Add(restock);
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
        public bool ReceiveRestock(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = RECEIVE_RESTOCK;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Restock restock in restocks)
                    {
                        if (restock.ID == id)
                        {
                            restock.Status = "Fulfilled";
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
        public bool ChangeAmount(Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CHANGE_AMOUNT;

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
