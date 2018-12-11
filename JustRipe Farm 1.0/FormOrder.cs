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
    public partial class FormOrder : Form
    {
        public string state = "";
        public FormOrder()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.Description = descriptionText.Text;
            ord.Product_id = Int32.Parse(productIdText.Text);
            ord.Quantity_box = Int32.Parse(quantityBoxText.Text);
            ord.Weight = Int32.Parse(weightText.Text);
            ord.PalletAllocation = palletAllocationText.Text;
            ord.Customer_id = customerIdText.Text;
            ord.Order_date = this.orderDatedateTimePicker.Value;
            ord.Collection_date = this.collectionDateTimePicker.Value;
            ord.Price = decimal.Parse(priceText.Text);
            ord.Status = statusText.Text;
            ord.Remark = remarkText.Text;

            InsertSQL ordHnd = new InsertSQL();
            int addrecord = ordHnd.addNewOrder(ord);
            MessageBox.Show(addrecord + "Your record is added");
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            //if (state != "")
            //{
            //    lblState.Text = state;
            //}
        }
    }
}
