using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace JustRipeFarm
{
    public class LabourerHandler
    {
        public int addNewLabourer(MySqlConnection conn, Labourer labourer)
        {
            string sql = "INSERT INTO labourer (name, age, gender) " + "VALUES ('"+ labourer.Name + "',"+ labourer.Age + "  , '" + labourer.Gender +"')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public DataSet getAllLabourer()
        {

            string selectQuery = "SELECT * from demojustripedb.labourer; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MysqlDb.Instance.getConn());

            DataSet ds = new DataSet();
            adapter.Fill(ds);               // method 1 
            //adapter.Fill(ds,"labourer");  // method 2

            return ds;
        }
    }
}
