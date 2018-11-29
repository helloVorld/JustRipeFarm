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

        public static List<string> getMenuButtonName()
        {
            List<string> menuList = new List<string>();
            menuList.Add("Home");
            menuList.Add("Orders");
            menuList.Add("Products");
            menuList.Add("Operation");
            menuList.Add("Farm");
            menuList.Add("Employee");
            menuList.Add("Customer");
            menuList.Add("Store");
            menuList.Add("Inventory");

            return menuList;
        }

        
    }
}
