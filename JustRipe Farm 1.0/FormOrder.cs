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
using MySql.Data.MySqlClient;

namespace JustRipeFarm
{
    public partial class FormOrder : Form
    {
        List<Product> productLists;
        List<Customer> customerLists;

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
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(comboBox1.Text)))
                    {
                        if (String.IsNullOrEmpty(Convert.ToString(textBox2.Text)))
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(textBox3.Text)))
                            {
                                if (String.IsNullOrEmpty(Convert.ToString(textBox4.Text)))
                                {
                                    if (String.IsNullOrEmpty(Convert.ToString(comboBox2.Text)))
                                    {
                                        if (String.IsNullOrEmpty(Convert.ToString(dateTimePicker1.Text)))
                                        {
                                            if (String.IsNullOrEmpty(Convert.ToString(dateTimePicker2.Text)))
                                            {
                                                if (String.IsNullOrEmpty(Convert.ToString(textBox5.Text)))
                                                {
                                                    if (String.IsNullOrEmpty(Convert.ToString(textBox6.Text)))
                                                    {
                                                        if (String.IsNullOrEmpty(Convert.ToString(textBox7.Text)))
                                                        {
                                                            MessageBox.Show("Please fill up all the box");
                                                        }
                                                        MessageBox.Show("Please fill up all the box");
                                                    }
                                                    MessageBox.Show("Please fill up all the box");
                                                }
                                               MessageBox.Show("Please fill up all the box");
                                            }
                                            MessageBox.Show("Please fill up all the box");
                                        }
                                        MessageBox.Show("Please fill up all the box");
                                    }
                                    MessageBox.Show("Please fill up all the box");
                                }
                                MessageBox.Show("Please fill up all the box");
                            }
                            MessageBox.Show("Please fill up all the box");
                        }
                        MessageBox.Show("Please fill up all the box");
                    }
                    MessageBox.Show("Please fill up all the box");
                }
                else
                {
                    AddOrder();
                }
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            InsertSQL order1= new InsertSQL();
            //productLists = order1.GetPorductList();

            if (state == "Edit")
            {
                textBox1.Text = ord.Description;
                comboBox1.Text = ord.Product_id.ToString();
                textBox2.Text = ord.Quantity_box.ToString();
                textBox3.Text = ord.Weight.ToString();
                textBox4.Text = ord.PalletAllocation.ToString();
                comboBox2.Text = ord.Customer_id.ToString();
                dateTimePicker1.Value = ord.Order_date;
                dateTimePicker2.Value = ord.Collection_date;
                textBox5.Text = ord.Price.ToString();
                textBox6.Text = ord.Status;
                textBox7.Text = ord.Remark;
            }
        }

        public void UpdateOrder()
        {
            Order ordi = new Order();
            ordi.Id = ord.Id;
            ordi.Description = textBox1.Text;
            ordi.Product_id = Int32.Parse(comboBox1.Text);
            ordi.Quantity_box = Int32.Parse(textBox2.Text);
            ordi.Weight = Double.Parse(textBox3.Text);
            ordi.PalletAllocation = int.Parse(textBox4.Text);
            ordi.Customer_id = int.Parse(comboBox2.Text);
            ordi.Order_date = this.dateTimePicker2.Value;
            ordi.Collection_date = this.dateTimePicker2.Value;
            ordi.Price = double.Parse(textBox5.Text);
            ordi.Status = textBox6.Text;
            ordi.Remark = textBox7.Text;


            UpdateSQL ordHnd = new UpdateSQL();
            int changerecord = ordHnd.UpdateOrder(ordi);
            MessageBox.Show(changerecord + " Your record is added");
            this.Close();
        }

        public void AddOrder()
        {
            Order ord = new Order();

            ord.Description = textBox1.Text;
            ord.Product_id = Int32.Parse(comboBox1.Text);
            ord.Quantity_box = Int32.Parse(textBox2.Text);
            ord.Weight = Int32.Parse(textBox3.Text);
            ord.PalletAllocation = int.Parse(textBox4.Text);
            ord.Customer_id = int.Parse(comboBox2.Text);
            ord.Order_date = this.dateTimePicker1.Value;
            ord.Collection_date = this.dateTimePicker2.Value;
            ord.Price = double.Parse(textBox5.Text);
            ord.Status = textBox6.Text;
            ord.Remark = textBox7.Text;


            InsertSQL ordHnd = new InsertSQL();
            int addrecord = ordHnd.addNewOrder(ord);
            MessageBox.Show(addrecord + "Your record is added");
            this.Close();
        }

        //public List<Crop> GetCropList()
        //{
        //    List<Crop> cropLists = new List<Crop>();
        //    MySqlDataReader rdr = null;
        //    try
        //    {
        //        string stm = "SELECT * FROM crop";
        //        MySqlCommand cmd = new MySqlCommand(stm, MysqlDbc.Instance.getConn());
        //        rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            Crop cr = new Crop();
        //            cr.Id = rdr.GetInt32("id");
        //            cr.Name = rdr.GetString("name");
        //            cr.Type = rdr.GetString("type");
        //            cr.Quantity_plot = rdr.GetInt32("quantity_plot");
        //            cr.Remark = rdr.GetString("remark");

        //            Console.WriteLine("crop => " + cr);
        //            cropLists.Add(cr);
        //        }

        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine("Error: {0}", ex.ToString());

        //    }
        //    finally
        //    {
        //        if (rdr != null)
        //        {
        //            rdr.Close();
        //        }

        //    }

        //    return cropLists;
        //}

        public void testDataPassedtoHere()
        {
            // can delete later
            //if (state == "Edit")
            //{
            //    Console.WriteLine("Order Details =>");
            //    Console.WriteLine(ord.Customer_id);
            //    Console.WriteLine(ord.Description);
            //    Console.WriteLine(ord.PalletAllocation);
            //    Console.WriteLine(ord.Order_date);
            //    Console.WriteLine(ord.Collection_date);
            //    Console.WriteLine("order details end");
            //}
            
        }
    }
}
