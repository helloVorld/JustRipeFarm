using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace JustRipeFarm
{
    
    public class DbConnecter
    {
        MySqlConnection conn;

        public string connect()
        {
            string connStr = "server=localhost;user=dbcli;database=demojustripedb;port=3306;password=dbcli123";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                //Perform database operations
            }

            catch(Exception ex)
            {
                return ex.ToString();
            }

            return "Done";
        }

        public DataSet Load()
        {
            //string details = "SELECT * FROM demojustripedb.labourer";
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM demojustripedb.labourer", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            //adapter.Fill(ds,"labourer");

            return ds;
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
    }

        
 
}

