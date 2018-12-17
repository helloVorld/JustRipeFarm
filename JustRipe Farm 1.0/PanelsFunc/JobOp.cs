using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using JustRipeFarm.ClassEntity;

namespace JustRipeFarm
{
    public class JobOp
    {
        public static int GetJobCountFor(bool isToday, string tableName)
        {
            string condition = isToday ? "=" : ">";
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyyMMdd");
            List<int> datesRead = new List<int>();
            MySqlDataReader rdr = null;
            try
            {

                
                string query = "SELECT * FROM `"+ tableName + "` WHERE " + tableName + ".date "+ condition + " CURRENT_DATE";
                
                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();
                Console.WriteLine("get job => read in "+date);
                while (rdr.Read())
                {
                    int id = rdr.GetInt32("id");
                    
                    DateTime dd = rdr.GetDateTime("date");
                    Console.WriteLine("get job => " + id + " => " + dd);
                    datesRead.Add(id);
                }
                Console.WriteLine("get job => read out");
                return datesRead.Count();
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
            return 0;
        }

        public static int GetJobCountFor(bool isToday, string tableName, int employeeID)
        {
            string condition = isToday ? "=" : ">";
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyyMMdd");
            List<int> datesRead = new List<int>();
            MySqlDataReader rdr = null;
            try
            {


                string query = "SELECT * FROM `" + tableName + "` WHERE " + tableName + ".date " + condition + " CURRENT_DATE AND "+tableName+".employee_id = "+employeeID;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();
                Console.WriteLine("get job => read in " + date);
                while (rdr.Read())
                {
                    int id = rdr.GetInt32("id");

                    DateTime dd = rdr.GetDateTime("date");
                    Console.WriteLine("get job => " + id + " => " + dd);
                    datesRead.Add(id);
                }
                Console.WriteLine("get job => read out");
                return datesRead.Count();
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
            return 0;
        }

        public static List<string> getOrderList()
        {
            Order order = new Order();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "orders";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    order.Description = rdr.GetString("description");
                    flist.Add(order.Description);
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

            return flist;
        }

        public static List<string> getProductList()
        {
            Product prod = new Product();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "product";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    prod.Name = rdr.GetString("name");
                    flist.Add(prod.Name);
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

            return flist;
        }

        public static List<string> getSowingJobList()
        {
            SowingJob sowing = new SowingJob();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "sowingjob";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    sowing.Description = rdr.GetString("description");
                    flist.Add(sowing.Description);
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

            return flist;
        }

        public static List<string> getHarvestingJobList()
        {
            HarvestingJob harvesting = new HarvestingJob();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "harvestingjob";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    harvesting.Description = rdr.GetString("description");
                    flist.Add(harvesting.Description);
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

            return flist;
        }

        public static List<string> getStoringJobList()
        {
            StoringJob storing = new StoringJob();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "storingjob";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    storing.Description = rdr.GetString("description");
                    flist.Add(storing.Description);
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

            return flist;
        }

        public static List<string> getFertilisingList()
        {
            FertilisingJob fertilising = new FertilisingJob();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "fertilisingjob";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    fertilising.Description = rdr.GetString("description");
                    flist.Add(fertilising.Description);
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

            return flist;
        }

        public static List<string> getPesticideJobList()
        {
            PesticideJob pest = new PesticideJob();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "pesticidejob";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    pest.Description = rdr.GetString("description");
                    flist.Add(pest.Description);
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

            return flist;
        }

        public static List<string> getFarmList()
        {
            Farm farm = new Farm();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "farm";
                string query = "SELECT * FROM " + tableName ;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    farm.Description = rdr.GetString("description");
                    flist.Add(farm.Description);
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

            return flist;
        }

        public static List<string> getEmployeeList()
        {
            Employee employee = new Employee();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "employee";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    employee.First_name = rdr.GetString("first_name");
                    flist.Add(employee.First_name);
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

            return flist;
        }

        public static List<string> getCustomerList()
        {
            Customer customer = new Customer();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "customer";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    customer.Name = rdr.GetString("name");
                    flist.Add(customer.Name);
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

            return flist;
        }

        public static List<string> getStoreroomList()
        {
            Storeroom storeroom = new Storeroom();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "storeroom";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    storeroom.Description = rdr.GetString("description");
                    flist.Add(storeroom.Description);
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

            return flist;
        }

        public static List<string> getVehicleList()
        {
            Vehicle vehicle = new Vehicle();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "vehicle";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    vehicle.Name = rdr.GetString("name");
                    flist.Add(vehicle.Name);
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

            return flist;
        }

        public static List<string> getCropList()
        {
            Crop crop = new Crop();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "crop";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    crop.Name = rdr.GetString("name");
                    flist.Add(crop.Name);
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

            return flist;
        }

        public static List<string> getFertiliserList()
        {
            Fertiliser fertiliser = new Fertiliser();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "fertiliser";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    fertiliser.Name = rdr.GetString("name");
                    flist.Add(fertiliser.Name);
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

            return flist;
        }

        public static List<string> getPesticideList()
        {
            Pesticide pesticide = new Pesticide();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "pesticide";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    pesticide.Name = rdr.GetString("name");
                    flist.Add(pesticide.Name);
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

            return flist;
        }

        public static List<string> getBoxList()
        {
            Box box = new Box();
            List<string> flist = new List<string>();
            MySqlDataReader rdr = null;
            try
            {
                string tableName = "box";
                string query = "SELECT * FROM " + tableName;

                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    box.Name = rdr.GetString("name");
                    flist.Add(box.Name);
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

            return flist;
        }


        public static int GetAllJobCountFor(bool isToday,int employeeID)
        {

            int jobs = GetJobCountFor(isToday, "sowingjob", employeeID);
            jobs += GetJobCountFor(isToday, "harvestingjob", employeeID);
            jobs += GetJobCountFor(isToday, "storingjob", employeeID);
            jobs += GetJobCountFor(isToday, "fertilisingjob", employeeID);
            jobs += GetJobCountFor(isToday, "pesticidejob", employeeID);
            
            return jobs;
        }

        public static int GetAllJobCountFor(bool isToday)
        {

            int jobs = GetJobCountFor(isToday, "sowingjob");
            jobs += GetJobCountFor(isToday, "harvestingjob");
            jobs += GetJobCountFor(isToday, "storingjob");
            jobs += GetJobCountFor(isToday, "fertilisingjob");
            jobs += GetJobCountFor(isToday, "pesticidejob");

            return jobs;
        }

        public static int GetOrderCountFor(string tableName)
        {
            
            List<int> ids = new List<int>();
            MySqlDataReader rdr = null;
            try
            {


                string query = "SELECT * FROM `" + tableName + "` WHERE " + tableName + ".status <> 'Completed'";
                Console.WriteLine("get order => read in");
                MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    int id = rdr.GetInt32("id");

                    Console.WriteLine("get order => " + id + " <= ");
                    ids.Add(id);
                }
                Console.WriteLine("get order => read out");
                return ids.Count();
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
            return 0;
        }

        public static int updateFieldStr(String tableName, int rowId, string field, string updateItem)
        {
            Console.WriteLine("updateFieldStr in");
            MySqlCommand sqlComm = new MySqlCommand("UPDATE " +tableName+" SET "+field+" = "+updateItem+" WHERE id = "+rowId+" ", MysqlDbc.Instance.getConn());
            
            Console.WriteLine("updateFieldStr out");

            return sqlComm.ExecuteNonQuery();
        }

        public static int UpdateOrder(int rowId,string status)
        {
            string query = "UPDATE orders SET status = @status " +
                                   "WHERE id = " + rowId;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = status;
            
            return sqlComm.ExecuteNonQuery();
        }



    }
}
