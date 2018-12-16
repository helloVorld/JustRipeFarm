using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dataset need use this
using System.Data;
using MySql.Data.MySqlClient;
using JustRipeFarm.ClassEntity;

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

        public DataSet getAllBoxSorage()
        {
            try
            {
                string table = JRF.dbName + ".boxstorage";
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

        public DataSet getAllStoringJobStorage()
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

        public Product GetProductFromID(int itemId)
        {
            Product p1 = new Product();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "product";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    p1.Id = itemId;
                    p1.Name = rdr.GetString("name");
                    p1.Type = rdr.GetString("type");
                    p1.Quantity_box = rdr.GetInt32("quantity_box");
                    p1.Weight = rdr.GetDecimal("weight");
                    p1.Box_id = rdr.GetInt32("box_id");
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

            return p1;
        }

        public Farm GetFarmFromID(int itemId)
        {
            Farm far = new Farm();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "farm";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    far.Id = itemId;
                    far.Description = rdr.GetString("description");
                    far.Area = rdr.GetInt32("area");
                    far.Utilize_area = rdr.GetInt32("utilize_area");
                    

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

            return far;
        }

        public Crop GetCropFromID(int itemId)
        {
            Crop c1 = new Crop();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "crop";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    c1.Id = itemId;
                    c1.Name = rdr.GetString("name");
                    c1.Type = rdr.GetString("type");
                    c1.Quantity_plot = rdr.GetInt32("quantity_plot");
                    c1.Remark = rdr.GetString("remark");

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

            return c1;
        }

        public Box GetBoxFromID(int itemId)
        {
            Box b1 = new Box();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "box";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    b1.Id = itemId;
                    b1.Name = rdr.GetString("name");
                    b1.Width = rdr.GetDouble("width");
                    b1.Height = rdr.GetDouble("height");
                    b1.Length = rdr.GetDouble("length");
                    b1.Max_weight = rdr.GetDouble("max_weight");
                    b1.Quantity = rdr.GetInt32("quantity");
                    b1.Status = rdr.GetString("status");
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

            return b1;
        }

        public BoxStorage GetBoxStorageFromID(int itemId)
        {
            BoxStorage bs1 = new BoxStorage();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "boxstorage";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    bs1.Id = itemId;
                    bs1.StoringJob_id = rdr.GetInt32("name");
                    bs1.Product_id = rdr.GetInt32("product_id");
                    bs1.Box_id = rdr.GetInt32("box_id");
                    bs1.NettWeight = rdr.GetDouble("nettWeight");
                    bs1.Storeroom_id = rdr.GetInt32("storeroom_id");
                    bs1.Add_date = rdr.GetDateTime("add_date");
                    bs1.Best_before = rdr.GetDateTime("best_before");
                    bs1.Out_date = rdr.GetDateTime("out_date");
                    bs1.Order_id = rdr.GetInt32("order_id");
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

            return bs1;
        }

        public Employee GetEmployeeFromID(int itemId)
        {
            Employee e1 = new Employee();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "employee";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    e1.Id = itemId;
                    e1.First_name = rdr.GetString("first_name");
                    e1.Last_name = rdr.GetString("last_name");
                    e1.Username = rdr.GetString("username");
                    e1.Password = rdr.GetString("password");
                    e1.Dob = rdr.GetDateTime("dob");
                    e1.Mobile = rdr.GetString("mobile");
                    e1.Email = rdr.GetString("email");
                    e1.Admin = rdr.GetBoolean("admin");
                    e1.Status = rdr.GetString("status");
                    e1.Remark = rdr.GetString("remark");

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

            return e1;
        }

        public Fertiliser GetFertiliserFromID(int itemId)
        {
            Fertiliser fer = new Fertiliser();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "fertiliser";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    fer.Id = itemId;
                    fer.Name = rdr.GetString("descriptionst_name");
                    fer.Quantity_kg = rdr.GetInt32("area");
                    fer.Remark = rdr.GetString("utilize_area");
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

            return fer;
        }

        public FertilisingJob GetFertilisingJobFromID(int itemId)
        {
            FertilisingJob fer = new FertilisingJob();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "fertilisingjob";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    fer.Id = itemId;
                    fer.Description = rdr.GetString("description");
                    fer.Fertiliser_id = rdr.GetInt32("fertiliser_id");
                    fer.Quantity_kg = rdr.GetInt32("quantity_kg");
                    fer.SowingJob_id = rdr.GetInt32("sowingJob_id");
                    fer.Crop_id = rdr.GetInt32("farm_id");
                    fer.Vehicle_id = rdr.GetInt32("vehicle_id");
                    fer.Employee_id = rdr.GetInt32("employee_id");
                    fer.Date_start = rdr.GetDateTime("date_start");
                    fer.Date_end = rdr.GetDateTime("date_end");
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

            return fer;
        }

        public HarvestingJob GetHarvestingJobFromID(int itemId)
        {
            HarvestingJob hj = new HarvestingJob();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "harvestingJob";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    hj.Id = itemId;
                    hj.Description = rdr.GetString("description");
                    hj.SowingJob_id = rdr.GetInt32("sowingJob_id");
                    hj.Farm_id = rdr.GetInt32("farm_id");
                    hj.Crop_id = rdr.GetInt32("crop_id");
                    hj.Vehicle_id = rdr.GetInt32("vehicle_id");
                    hj.Est_quantity = rdr.GetInt32("est_quantity");
                    hj.Harvested_quantity = rdr.GetInt32("harvested_quantity");
                    hj.Employee_id = rdr.GetInt32("employee_id");
                    hj.Date_start = rdr.GetDateTime("date_start");
                    hj.Date_end = rdr.GetDateTime("date_end");
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

            return hj;
        }

        public Pesticide GetPesticideFromID(int itemId)
        {
            Pesticide p1 = new Pesticide();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "pesticide";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    p1.Id = itemId;
                    p1.Name = rdr.GetString("name");
                    p1.Quantity_kg = rdr.GetInt32("quantity_kg");
                    p1.Remark = rdr.GetString("remark");
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

            return p1;
        }

        public PesticideJob GetPesticideJobFromID(int itemId)
        {
            PesticideJob p1 = new PesticideJob();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "pesticiejob";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    p1.Id = itemId;
                    p1.Description = rdr.GetString("description");
                    p1.Pesticide_id = rdr.GetInt32("pesticide_id");
                    p1.Quantity_kg = rdr.GetInt32("quantity_kg");
                    p1.SowingJob_id = rdr.GetInt32("sowingJob_id");
                    p1.Farm_id = rdr.GetInt32("farm_id");
                    p1.Crop_id = rdr.GetInt32("crop_id");
                    p1.Vehicle_id = rdr.GetInt32("vehicle_id");
                    p1.Employee_id = rdr.GetInt32("employee_id");
                    p1.Date_start = rdr.GetDateTime("date_start");
                    p1.Date_end = rdr.GetDateTime("date_end");
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

            return p1;
        }

        public SowingJob GetSowingJobFromID(int itemId)
        {
            SowingJob sj1 = new SowingJob();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "sowingjob";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    sj1.Id = itemId;
                    sj1.Description = rdr.GetString("description");
                    sj1.Crop_id = rdr.GetInt32("crop_id");
                    sj1.Quantity_prop = rdr.GetInt32("quantity_prop");
                    sj1.Farm_id = rdr.GetInt32("farm_id");
                    sj1.Used_area = rdr.GetString("used_area");
                    sj1.Vehicle_id = rdr.GetInt32("vehicle_id");
                    sj1.Employee_id = rdr.GetInt32("employee_id");
                    sj1.Date_start = rdr.GetDateTime("date_start");
                    sj1.Date_end = rdr.GetDateTime("date_end");
                    //sj1.Time_start = rdr.GetDateTime("time_start");
                    //sj1.Time_end = rdr.GetDateTime("time_end");
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

            return sj1;
        }

        public Storeroom GetStoreroomFromID(int itemId)
        {
            Storeroom ss1 = new Storeroom();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "storeroom";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ss1.Id = itemId;
                    ss1.Description = rdr.GetString("description");
                    ss1.StoringQty = rdr.GetInt32("storingQty");
                    ss1.Temperature = rdr.GetInt32("temperature");
                    ss1.Availability = rdr.GetBoolean("availability");
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

            return ss1;
        }

        public StoringJob GetStoringJobFromID(int itemId)
        {
            StoringJob ss1 = new StoringJob();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "storingjob";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ss1.Id = itemId;
                    ss1.Description = rdr.GetString("description");
                    ss1.Harvest_id = rdr.GetInt32("harvest_id");
                    ss1.Crop_id = rdr.GetInt32("crop_id");
                    ss1.Box_id = rdr.GetInt32("box_id");
                    ss1.Quantity = rdr.GetInt32("quantity");
                    ss1.Vehicle_id = rdr.GetInt32("vehicle_id");
                    ss1.Employee_id = rdr.GetInt32("employee_id");
                    ss1.Date_start = rdr.GetDateTime("date_start");
                    ss1.Date_end = rdr.GetDateTime("date_end");
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

            return ss1;
        }

        public Vehicle GetVehicleFromID(int itemId)
        {
            Vehicle v1 = new Vehicle();

            MySqlDataReader rdr = null;
            try
            {
                string tableName = "vehicle";
                string query = "SELECT * FROM " + tableName + " WHERE id = " + itemId;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    v1.Id = itemId;
                    v1.Name = rdr.GetString("name");
                    v1.Serial_number = rdr.GetString("serial_number");
                    v1.Buy_date = rdr.GetDateTime("buy_date");
                    v1.Last_service_date = rdr.GetDateTime("last_service_date");
                    v1.Remark = rdr.GetString("remark");
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

            return v1;
        }
    }
}
