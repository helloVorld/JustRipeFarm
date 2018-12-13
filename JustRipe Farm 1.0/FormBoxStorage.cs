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
    public partial class FormBoxStorage : Form
    {
        public FormBoxStorage()
        {
            InitializeComponent();
        }

        private void CheckBoxStorage(int storingJob_id, int product_id, int box_id, double nettWeight, int storeroom_id, DateTime add_date, DateTime best_before, DateTime out_date, int order_id)
        {

            bool ck1 = String.IsNullOrEmpty(storingJob_id.ToString());
            bool ck2 = String.IsNullOrEmpty(product_id.ToString());
            bool ck3 = String.IsNullOrEmpty(box_id.ToString());
            bool ck4 = String.IsNullOrEmpty(nettWeight.ToString());
            bool ck5 = String.IsNullOrEmpty(storeroom_id.ToString());
            bool ck6 = String.IsNullOrEmpty(add_date.ToString());
            bool ck7 = String.IsNullOrEmpty(best_before.ToString());
            bool ck8 = String.IsNullOrEmpty(out_date.ToString());
            bool ck9 = String.IsNullOrEmpty(order_id.ToString());

            if (ck1 == true && ck2 == true && ck3 == ck1 && ck4 == true && ck5 == true && ck6 == true && ck7 == true && ck8 == true && ck9 == true)
            {
                //InsertSQL boxStoreHnd = new InsertSQL();
                //int addrecord = boxStoreHnd.addNewCustomer(box);
                //MessageBox.Show(addrecord + " Your record is added");
            }
            else
            {
                ErrorMsg.UpdateOptionNoSelect();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
