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

        private void addBoxStorage()
        {
            BoxStorage bs1 = new BoxStorage();
            bs1.StoringJob_id = int.Parse(textBox1.Text);
            bs1.Product_id = int.Parse(textBox2.Text);
            bs1.Box_id = int.Parse(textBox3.Text);
            bs1.NettWeight = double.Parse(textBox4.Text);
            bs1.Storeroom_id = int.Parse(textBox5.Text);
            bs1.Add_date = Convert.ToDateTime(dateTimePicker1.Text);
            bs1.Best_before = Convert.ToDateTime(dateTimePicker2.Text);
            bs1.Out_date = Convert.ToDateTime(dateTimePicker3.Text);
            bs1.Order_id = int.Parse(textBox6.Text);

            InsertSQL add = new InsertSQL();
            int editrecord = add.addNewBoxStorage(bs1);
            MessageBox.Show(" Your seccusful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
