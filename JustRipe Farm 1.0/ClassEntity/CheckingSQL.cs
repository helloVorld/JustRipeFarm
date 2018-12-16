using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm
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

        public MySqlDataReader getemployeeinfo(string user, string pass)
        {
            string query = "SELECT * FROM employee WHERE username ='" + user + "' AND password = '" + pass + "'" ;

            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlComm.ExecuteReader();

            return dr;
        }

        public MySqlDataReader getempname()
        {
            Boolean test = false;
            string query = "SELECT * FROM employee WHERE  admin ='" + test + "'";        
            MySqlCommand sqlCom = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            MySqlDataReader dr = sqlCom.ExecuteReader();
            return dr;
        }

        public MySqlDataReader getcropinfo()
        {
            string query = "SELECT * FROM crop ";
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
