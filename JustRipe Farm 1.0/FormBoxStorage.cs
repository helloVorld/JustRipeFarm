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
    public partial class FormBoxStorage : Form
    {

        public string state = "";
        public BoxStorage bs1;

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

        private void updateBoxStorage()
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

            UpdateSQL add = new UpdateSQL();
            int editrecord = add.updateBoxStorage(bs1);
            MessageBox.Show(" Your seccusful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void FormBoxStorage_Load(object sender, EventArgs e)
        {
            InsertSQL bs = new InsertSQL();
            //productLists = order1.GetPorductList();

            if (state == "Edit")
            {
                InsertSQL boxStorage = new InsertSQL();
                //productLists = order1.GetPorductList();

                if (state == "Edit")
                {
                    bs1.Add_date = Convert.ToDateTime(dateTimePicker1.Text);
                    textBox1.Text = bs1.StoringJob_id.ToString();
                    textBox2.Text = bs1.Product_id.ToString();
                    textBox3.Text = bs1.Box_id.ToString();
                    textBox4.Text = bs1.NettWeight.ToString();
                    textBox5.Text = bs1.Storeroom_id.ToString();
                    dateTimePicker1.Value = bs1.Add_date;
                    dateTimePicker2.Value = bs1.Best_before;
                    dateTimePicker3.Value = bs1.Out_date;
                    textBox6.Text = bs1.Order_id.ToString();

                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                updateBoxStorage();
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    if (String.IsNullOrEmpty(textBox2.Text))
                    {
                        if (String.IsNullOrEmpty(textBox3.Text))
                        {
                            if (String.IsNullOrEmpty(textBox4.Text))
                            {
                                if (String.IsNullOrEmpty(textBox5.Text))
                                {
                                    if (String.IsNullOrEmpty(textBox6.Text))
                                    {
                                        if (String.IsNullOrEmpty(dateTimePicker1.Text))
                                        {
                                            if (String.IsNullOrEmpty(dateTimePicker2.Text))
                                            { 
                                                if (String.IsNullOrEmpty(dateTimePicker3.Text))
                                                {
                                                    MessageBox.Show("please fill up all the box");
                                                }
                                            MessageBox.Show("please fill up all the box");
                                            }
                                            MessageBox.Show("please fill up all the box");
                                        }
                                        MessageBox.Show("please fill up all the box");
                                    }
                                    MessageBox.Show("please fill up all the box");
                                }
                                MessageBox.Show("please fill up all the box");
                            }
                            MessageBox.Show("please fill up all the box");
                        }
                        MessageBox.Show("please fill up all the box");
                    }
                    MessageBox.Show("please fill up all the box");
                }
                else
                {
                    addBoxStorage();
                }
            }
        }
    }
}
