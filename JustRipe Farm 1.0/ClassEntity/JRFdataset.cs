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
    }
}
