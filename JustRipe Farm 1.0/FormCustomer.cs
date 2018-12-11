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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Name = nameText.Text;
            cust.Email = emailText.Text;
            cust.Phone = phoneText.Text;
            cust.Remark = remarkText.Text;

            InsertSQL custHnd = new InsertSQL();
            int addrecord = custHnd.addNewCustomer(cust);
            MessageBox.Show(addrecord + "Your record is added");
        }
    }
}
