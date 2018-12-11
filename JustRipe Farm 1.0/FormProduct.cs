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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Name = nameText.Text;
            prod.Type = typeText.Text;
            prod.Quantity_box = Convert.ToInt32(quantityNumericUpDown.Value);
            prod.Weight = decimal.Parse(weightText.Text);
            prod.Box_id = Int32.Parse(boxIdText.Text);
            InsertSQL prodHnd = new InsertSQL();

            int addrecord = prodHnd.addNewProduct(prod);
            MessageBox.Show(addrecord + "Your record is added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
