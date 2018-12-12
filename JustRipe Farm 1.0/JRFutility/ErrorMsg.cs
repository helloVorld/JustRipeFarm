using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm
{
    public class ErrorMsg
    {
        public static void PlsSelectRow()
        {
            MessageBox.Show("Please select a row");
        }

        public static void UpdateOptionNoSelect()
        {
            MessageBox.Show("Please select an option.");
        }

        public static void UpdateOptionInvalid()
        {
            MessageBox.Show("Invalid option.");
        }

        public static void WrongIntInput()
        {
            MessageBox.Show("Invalid number input.");
        }
    }
}
