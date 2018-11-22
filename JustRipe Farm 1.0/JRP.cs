using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm
{
    public class JRP
    {
        
        public static void Logout(Form form)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            form.Close();
        }
    }
}
