using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm
{
    public sealed class JRP
    {
        // for general function 
        private static JRP fn = null;
        public static JRP Fn
        {
            get
            {
                if (fn == null)
                {
                    fn = new JRP();
                    
                }
                return fn;
            }

        }

        public void Logout(Form form)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            form.Close();
        }
    }
}
