using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
