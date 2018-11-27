using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace JustRipeFarm
{

    public sealed class MysqlDbc
    {
        private static MysqlDbc instance = null;
        private static MySqlConnection conn;

        public static MysqlDbc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MysqlDbc();
                    Console.WriteLine("JRF: MysqlDbc => singleton created");

                }
                return instance;
            }

        }

        private MysqlDbc()
        {

        }


        public bool connect()
        {
            string connStr = "server=" + JRF.dbServer
                            + ";user=" + JRF.dbUser
                            + ";database=" + JRF.dbName
                            + ";port=3306;password=" + JRF.dbPassword;

            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("JRF: MysqlDbc => Connection to MySql established.");
                //Perform database operations
            }

            catch (Exception ex)
            {
                Console.WriteLine("JRF: MysqlDbc => "+ex.ToString());
                //return ex.Message;
                return false;
            }

            return true;
        }


        public MySqlConnection getConn()
        {
            return conn;
        }

        //public DataSet Load()
        //{
        //    //string details = "SELECT * FROM demojustripedb.labourer";
        //    string table = JRF.dbName + ".labourer";
        //    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM "+table, conn);

        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);
        //    //adapter.Fill(ds,"labourer");

        //    return ds;
        //}

        public DataSet getAllLabourer()
        {
            string table = JRF.dbName + ".labourer";
            string selectQuery = "SELECT * from "+table+"; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);               // method 1 
            //adapter.Fill(ds,"labourer");  // method 2

            return ds;
        }


        //public List<string> checkMySqlTable()
        //{
        //    List<string> Tablenames = new List<string>();


        //    string query = "show tables from demojustripedb";
        //    MySqlCommand command = new MySqlCommand(query, conn);
        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Tablenames.Add(reader.GetString(0));
        //    }

        //    reader.Close();

        //    return Tablenames;
        //}
    }



}

