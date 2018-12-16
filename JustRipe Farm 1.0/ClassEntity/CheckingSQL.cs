using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm.ClassEntity
{
    public class CheckingSQL
    {

        public MySqlDataReader getsowinginfo(string ename)
        {
            string checkId = "SELECT * FROM sowingjob WHERE employee_id ='" + ename + "'";

            MySqlCommand sqlComm = new MySqlCommand(checkId, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlComm.ExecuteReader();

            return dr;
        }

        //public MySqlDataReader getemployeeinfo(string user, string pass)
        //{
        //    string query = "SELECT * FROM employee WHERE username ='" + user + "' AND password = '" + pass + "'" ;

        //    MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
        //    MySqlDataReader dr = sqlComm.ExecuteReader();

        //    return dr;
        //}

        public MySqlDataReader getempname()
        {
            Boolean test = false;
            MySqlDataReader dr = null;
            try
            {
                string query = "SELECT * FROM employee WHERE  admin ='" + test + "'";
                MySqlCommand sqlCom = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
            }
            
            //dr= sqlCom.ExecuteReader();
            return getempname();
        }

        public MySqlDataReader getcropinfo()
        {
            string query = "SELECT * FROM crop ";
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlComm.ExecuteReader();
            return dr;
        }

        public MySqlDataReader getfarminfo()
        {
            string query = "SELECT * FROM farm ";
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlComm.ExecuteReader();
            return dr;
        }

        public MySqlDataReader getvehicleinfo()
        {
            string query = "SELECT * FROM vehicle ";
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlComm.ExecuteReader();
            return dr;
        }

        public MySqlDataReader getharvestinfo()
        {
            string query = "SELECT * FROM harvestingjob ";
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlComm.ExecuteReader();
            return dr;
        }
    }
}
//MySqlDataReader dr = csql.getcropinfo();
//while (dr.Read())
//{
//    cbCrop.Items.Add(dr[0].ToString());// get type of crop  
//    cbCrop.Items.Add(dr[1].ToString());
//}

//MySqlDataReader dr1 = csql.getempname();
//while (dr1.Read())
//{
//    cbCrop.Items.Add(dr[0].ToString());
//    cbCrop.Items.Add(dr[3].ToString());
//}

//MySqlDataReader dr2 = csql.getfarminfo();
//while (dr2.Read())
//{
//    cbCrop.Items.Add(dr[0].ToString());
//    cbCrop.Items.Add(dr[1].ToString());
//}

//MySqlDataReader dr3 = csql.getvehicleinfo();
//while (dr3.Read())
//{
//    cbCrop.Items.Add(dr[0].ToString());
//    cbCrop.Items.Add(dr[1].ToString());
//}