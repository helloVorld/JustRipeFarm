using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm
{
    public class JRF
    {
        public static string dbServer = "localhost";
        public static string dbUser = "jrfadmin";
        public static string dbName = "justripefarmdb";
        public static string dbPassword = "jrf123";

        public static void Logout(Form form)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            form.Close();
        }
    }
}
