using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace JustRipeFarm
{
    
    public sealed class DbConnector
    {
        private static DbConnector instance = null;
        private static MySqlConnection conn;

        public static DbConnector Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnector();
                    Console.WriteLine("JRF: DbConnector => singleton created");

                }
                return instance;
            }
            
        }

        private DbConnector()
        {
            
        }

      
        public string connect()
        {
            string connStr = "server=localhost;user=dbcli;database=demojustripedb;port=3306;password=dbcli123";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("JRF: DbConnector => Connection to MySql opened.");
                //Perform database operations
            }

            catch(Exception ex)
            {
                return ex.ToString();
                //return ex.Message;
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

        public List<string> checkMySqlTable()
        {
            List<string> Tablenames = new List<string>();

            
            string query = "show tables from demojustripedb";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                Tablenames.Add(reader.GetString(0));
            }

            reader.Close();
                
            return Tablenames;
        }
    }

        
 
}

