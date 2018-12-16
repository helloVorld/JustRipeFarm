using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace JustRipeFarm.ClassEntity
{
    public class Login
    {

        public string Username { get; set; }
        public string Password { get; set; }

        CheckingSQL cs = new CheckingSQL();
        Employee e1 = new Employee();

        public Login(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;  
        }
        
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }


        internal bool IsLoggedIn(string user, string pass)
        {
            if ((user == "") || (pass == " "))
            {
                MessageBox.Show("Enter the username and password!");
                return false;
            }
            else
            {
                if ((user != Username) || (pass != Password))
                {
                    MessageBox.Show("Enter the correct username and password!");
                    ClearTexts(user, pass);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Employee checkUserLogin()
        {
            Employee em = new Employee();
            MySqlDataReader rdr = null;
            try
            {
                string sql = "SELECT * FROM employee WHERE username = '" + Username + "' AND password = '" + Password + "'";
                MySqlCommand cmd = new MySqlCommand(sql, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    em.Id = rdr.GetInt32("id");
                    em.First_name = rdr.GetString("first_name");
                    em.Last_name = rdr.GetString("last_name");
                    em.Username = rdr.GetString("username");
                    em.Password = rdr.GetString("password");
                    em.Dob = rdr.GetDateTime("dob");
                    em.Mobile = rdr.GetString("mobile");
                    em.Email = rdr.GetString("email");
                    em.Admin = rdr.GetBoolean("admin");
                    em.Status = rdr.GetString("status");
                    em.Remark = rdr.GetString("remark");
                    
                    
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
            return em;
        }

    }
}
