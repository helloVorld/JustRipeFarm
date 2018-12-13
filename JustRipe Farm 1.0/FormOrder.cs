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
            
            
            if (state == "Edit")
            {
                UpdateOrder();
            }
            else
            {
                AddOrder();
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                descriptionText.Text = ord.Description;
                productIdText.Text = ord.Product_id.ToString();
                quantityBoxText.Text = ord.Quantity_box.ToString();
                weightText.Text = ord.Weight.ToString();
                palletAllocationText.Text = ord.PalletAllocation.ToString();
                customerIdText.Text = ord.Customer_id.ToString();
                orderDatedateTimePicker.Value = ord.Order_date;
                collectionDateTimePicker.Value = ord.Collection_date;
                priceText.Text = ord.Price.ToString();
                statusText.Text = ord.Status;
            }
            testDataPassedtoHere();
        }

        public void UpdateOrder()
        {
            Order ordi = new Order();
            ordi.Id = ord.Id;
            ordi.Description = descriptionText.Text;
            ordi.Product_id = Int32.Parse(productIdText.Text);
            ordi.Quantity_box = Int32.Parse(quantityBoxText.Text);
            ordi.Weight = Int32.Parse(weightText.Text);
            ordi.PalletAllocation = int.Parse(palletAllocationText.Text);
            ordi.Customer_id = int.Parse(customerIdText.Text);
            ordi.Order_date = this.orderDatedateTimePicker.Value;
            ordi.Collection_date = this.collectionDateTimePicker.Value;
            ordi.Price = double.Parse(priceText.Text);
            ordi.Status = statusText.Text;
            ordi.Remark = remarkText.Text;

            UpdateSQL ordHnd = new UpdateSQL();
            int changerecord = ordHnd.UpdateOrder(ordi);
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
