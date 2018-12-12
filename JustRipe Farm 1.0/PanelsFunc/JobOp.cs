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

    }
}
