using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustRipeFarm.ClassEntity;

namespace JustRipeFarm
{
    public partial class FormBox : Form
    {
        public FormBox()
        {
            InitializeComponent();
        }

        private void CheckBox(string name, double width, double height, double length, double max_weight, int quantity, string status)
        {

            bool ck1 = String.IsNullOrEmpty(name);
            bool ck2 = String.IsNullOrEmpty(width.ToString());
            bool ck3 = String.IsNullOrEmpty(height.ToString());
            bool ck4 = String.IsNullOrEmpty(length.ToString());
            bool ck5 = String.IsNullOrEmpty(max_weight.ToString());
            bool ck6 = String.IsNullOrEmpty(quantity.ToString());
            bool ck7 = String.IsNullOrEmpty(status);

            if (ck1 == true && ck2 == true && ck3 == ck1 && ck4 == true && ck5 == true && ck6 == true && ck7 == true)
            {
                //InsertSQL boxHnd = new InsertSQL();
                //int addrecord = boxHnd.addNewCustomer(box);
                //MessageBox.Show(addrecord + " Your record is added");
            }
            else
            {
                ErrorMsg.UpdateOptionNoSelect();
            }
        }
    }
}
