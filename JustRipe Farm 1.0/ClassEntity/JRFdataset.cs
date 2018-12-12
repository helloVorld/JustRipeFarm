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

        public DataSet getAllFertiliser()
        {
            try
            {
                string table = JRF.dbName + ".fertiliser";
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

        public DataSet getAllPesticide()
        {
            try
            {
                string table = JRF.dbName + ".pesticide";
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

        public DataSet getAllBox()
        {
            try
            {
                string table = JRF.dbName + ".box";
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

        public DataSet getAllSowing()
        {
            try
            {
                string table = JRF.dbName + ".sowingjob";
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

        public DataSet getAllHarvesting()
        {
            try
            {
                string table = JRF.dbName + ".harvestingjob";
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

        public DataSet getAllStorage()
        {
            try
            {
                string table = JRF.dbName + ".storingjob";
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

        public DataSet getAllFertilising()
        {
            try
            {
                string table = JRF.dbName + ".fertilisingjob";
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


        public DataSet getAllPests()
        {
            try
            {
                string table = JRF.dbName + ".pesticidejob";
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

        public DataSet getAllFarm()
        {
            try
            {
                string table = JRF.dbName + ".farm";
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

        public DataSet getAllCustomer()
        {
            try
            {
                string table = JRF.dbName + ".customer";
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

        public DataSet getAllStoreroom()
        {
            try
            {
                string table = JRF.dbName + ".storeroom";
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

        public DataSet getAllVehicle()
        {
            try
            {
                string table = JRF.dbName + ".vehicle";
                string selectQuery = "SELECT * from " + table + "; ";

                Console.WriteLine("Hello gg");
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDbc.Instance.getConn());

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());
            }
            Console.WriteLine("Hello gg2");

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
        
        /// 
        /// Select item from ID
        /// 

        public Order GetOrderFromID(int itemId)
        {
            Order ord = new Order();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "orders";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

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

        public Customer GetCustoemrFromID(int itemId)
        {
            Customer cus = new Customer();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "customer";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cus.Id = itemId;
                    cus.Name = rdr.GetString("name");
                    cus.Email = rdr.GetString("email");
                    cus.Phone = rdr.GetString("phone");
                    cus.Remark = rdr.GetString("remark");

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

            return cus;
        }

        public Customer GetProductFromID(int itemId)
        {
            Customer cus = new Customer();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "product";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cus.Id = itemId;
                    cus.Name = rdr.GetString("name");
                    cus.Email = rdr.GetString("email");
                    cus.Phone = rdr.GetString("phone");
                    cus.Remark = rdr.GetString("remark");

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

            return cus;
        }
    }
}
