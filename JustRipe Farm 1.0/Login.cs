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
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;

            }
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                    else if (Password != pass)
                    {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        public int checkUserLogin()
        {
            MySqlDataReader rdr = null;
            try
            {
                string sql = "SELECT * FROM employee WHERE username = '" + Username + "' AND password = '" + Password + "'";
                MySqlCommand cmd = new MySqlCommand(sql, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    //cr.Id = rdr.GetInt32("id");
                    //cr.Name = rdr.GetString("name");
                    //cr.Type = rdr.GetString("type");
                    //cr.Quantity_plot = rdr.GetInt32("quantity_plot");
                    //cr.Remark = rdr.GetString("remark");
                    Console.WriteLine("login => " );
                    //Console.WriteLine("login => " + rdr.GetInt32("admin"));
                    //cropLists.Add(cr);
                    return rdr.GetInt32("admin");
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
            return 99;
        }

    }
}
