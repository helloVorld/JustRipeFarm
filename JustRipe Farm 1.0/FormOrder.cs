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
        public Order ord;
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
            //AddOrder();
            UpdateOrder();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            //if (state != "")
            //{
            //    lblState.Text = state;
            //}
        }

        public void UpdateOrder()
        {
            Order ord = new Order();
            ord.Id = 1;
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

            UpdateSQL ordHnd = new UpdateSQL();
            int changerecord = ordHnd.UpdateOrder(ord);
            MessageBox.Show(changerecord + " Your record is added");
        }

        public void AddOrder()
        {
            Order ord = new Order();
            
            ord.Description = descriptionText.Text;
            ord.Product_id = Int32.Parse(productIdText.Text);
            ord.Quantity_box = Int32.Parse(quantityBoxText.Text);
            ord.Weight = Int32.Parse(weightText.Text);
            ord.PalletAllocation = int.Parse(palletAllocationText.Text);
            ord.Customer_id = int.Parse(customerIdText.Text);
            ord.Order_date = this.orderDatedateTimePicker.Value;
            ord.Collection_date = this.collectionDateTimePicker.Value;
            ord.Price = double.Parse(priceText.Text);
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
            testDataPassedtoHere();
        }

        public void testDataPassedtoHere()
        {
            // can delete later
            if (state == "Edit")
            {
                Console.WriteLine("Order Details =>");
                Console.WriteLine(ord.Customer_id);
                Console.WriteLine(ord.Description);
                Console.WriteLine(ord.PalletAllocation);
                Console.WriteLine(ord.Order_date);
                Console.WriteLine(ord.Collection_date);
                Console.WriteLine("order details end");
            }
            
        }
    }
}
