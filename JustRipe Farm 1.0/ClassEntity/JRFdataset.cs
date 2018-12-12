using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dataset need use this
using System.Data;
using MySql.Data.MySqlClient;


namespace JustRipeFarm
{
    class JRFdataset
    {
        private static JRFdataset table = null;
        

        public static JRFdataset Table
        {
            get
            {
                if (table == null)
                {
                    table = new JRFdataset();
                    Console.WriteLine("JRF: JRFdataset => singleton created");

                }
                return table;
            }

        }

        private JRFdataset()
        {

        }

        public DataSet getAllLabourer()
        {
            try
            {
                string table = JRF.dbName + ".employee";
                string selectQuery = "SELECT * from " + table + "; ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDbc.Instance.getConn());

                DataSet ds = new DataSet();
                adapter.Fill(ds);               
                                                
                return ds;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());
            }

            
            return new DataSet();
        }

        public DataSet getAllCrop()
        {
            try
            {
                string table = JRF.dbName + ".crop";
                string selectQuery = "SELECT * from " + table + "; ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDbc.Instance.getConn());

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());
            }


            return new DataSet();
        }

        public DataSet getAllOrders()
        {
            try
            {
                string table = JRF.dbName + ".orders";
                string selectQuery = "SELECT * from " + table + "; ";


                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDbc.Instance.getConn());

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());
            }


            return new DataSet();
        }

        public Order GetOrderFromID(int itemId)
        {
            Order ord = new Order();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "orders";
                string query = "SELECT * FROM "+tableName+" WHERE id = "+ itemId;
                
                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    ord.Id = itemId;
                    ord.Description = rdr.GetString("description");
                    ord.Product_id = rdr.GetInt32("product_id");
                    ord.Quantity_box = rdr.GetInt32("quantity_box");
                    ord.Weight = rdr.GetDouble("weight");
                    ord.PalletAllocation = rdr.GetInt32("palletAllocation");
                    ord.Customer_id = rdr.GetInt32("customer_id");
                    ord.Order_date = rdr.GetDateTime("order_date");
                    ord.Collection_date = rdr.GetDateTime("collection");
                    ord.Price = rdr.GetDouble("price");
                    ord.Status = rdr.GetString("status");
                    ord.Remark = rdr.GetString("remark");

                }
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

            }

            return ord;
        }

        public DataSet getAllEmployee()
        {
            try
            {
                string table = JRF.dbName + ".employee";
                string selectQuery = "SELECT * from " + table + "; ";


                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDbc.Instance.getConn());

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());
            }


            return new DataSet();
        }

        public DataSet getAllProduct()
        {
            try
            {
                string table = JRF.dbName + ".product";
                string selectQuery = "SELECT * from " + table + "; ";


                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDbc.Instance.getConn());

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());
            }


            return new DataSet();
        }
    }
}
