using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject
{
    public class DBOrderInfoManager : IDBOrderInfoManagerPM
    {
        // sql
        public string GET_ORDER_INFOS_FOR_PRODUCT = "SELECT * FROM OrderInfo as o INNER JOIN Supplier as s on o.SupplierID = s.ID WHERE o.ProductBarcode = @ProductBarcode   LIMIT 50;";
        public string CREATE_ORDER_INFO = "INSERT INTO orderinfo (SupplierID, ProductBarcode, MinAmount, MaxAmount, Multiples, PurchasePrice) VALUES (@SupplierID, @Barcode, @MinAmount, @MaxAmount, @Multiples, @PurchasePrice);";
        public string UPDATE_ORDER_INFO = "UPDATE OrderInfo SET MinAmount = @MinAmount, MaxAmount = @MaxAmount, Multiples = @Multiples, PurchasePrice = @PurchasePrice WHERE ID = @ID;";
        public string DELETE_ORDER_INFO = "DELETE FROM OrderInfo WHERE ID = @ID;";

        public List<OrderInfo> GetOrderInfosForProduct(Product p)
        {
            List<OrderInfo> orderInfos = new List<OrderInfo>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_ORDER_INFOS_FOR_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ProductBarcode", p.Barcode);

                MySqlDataReader reader = cmd.ExecuteReader();

                OrderInfo orderInfo;
                Supplier supplier;

                while (reader.Read())
                {
                    int supplierID = reader.GetInt32(7);
                    string supplierName = reader.GetString(8);
                    string supplierCountry = reader.GetString(9);
                    int buildingNr = reader.GetInt32(10);
                    string postalCode = reader.GetString(11);
                    string email = reader.GetString(12);
                    string phoneNumber = reader.GetString(13);
                    string bankNumber = reader.GetString(14);
                    string productType = reader.GetString(15);

                    supplier = new Supplier(supplierID, supplierName, supplierCountry, buildingNr, postalCode, email, phoneNumber, bankNumber, productType);
                    
                    int orderInfoID = reader.GetInt32(0);
                    string barcode = reader.GetString(2);
                    int minAmount = reader.GetInt32(3);
                    int maxAmount = reader.GetInt32(4);
                    int multiples = reader.GetInt32(5);
                    double purchasePrice = reader.GetDouble(6);

                    orderInfo = new OrderInfo(orderInfoID, supplier, p, minAmount, maxAmount, multiples, purchasePrice);
                    orderInfos.Add(orderInfo);
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

            return orderInfos;
        }
        public bool CreateOrderInfo(OrderInfo oi)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_ORDER_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@SupplierID", oi.Supplier.ID);
                cmd.Parameters.AddWithValue("@Barcode", oi.Product.Barcode);
                cmd.Parameters.AddWithValue("@MinAmount", oi.MinAmount);
                cmd.Parameters.AddWithValue("@MaxAmount", oi.MaxAmount);
                cmd.Parameters.AddWithValue("@Multiples", oi.Multiples);
                cmd.Parameters.AddWithValue("@PurchasePrice", oi.PurchasePrice);

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
        public bool UpdateOrderInfo(OrderInfo oi)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_ORDER_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", oi.ID);

                cmd.Parameters.AddWithValue("@MinAmount", oi.MinAmount);
                cmd.Parameters.AddWithValue("@MaxAmount", oi.MaxAmount);
                cmd.Parameters.AddWithValue("@Multiples", oi.Multiples);
                cmd.Parameters.AddWithValue("@PurchasePrice", oi.PurchasePrice);

                int numUpdatedRows = cmd.ExecuteNonQuery();

                if (numUpdatedRows == 1)
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
        public bool DeleteOrderInfo(OrderInfo oi)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_ORDER_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", oi.ID);

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
    }
}
