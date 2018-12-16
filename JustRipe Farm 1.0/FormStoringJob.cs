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
    public partial class FormStoringJob : Form
    {
        public string state = "";
        public StoringJob sj;

        public FormStoringJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addStoringJob()
        {
            StoringJob sj = new StoringJob();
            sj.Description = textBox1.Text;
            sj.Harvest_id = int.Parse(textBox2.Text);
            sj.Crop_id = int.Parse(textBox3.Text);
            sj.Box_id = int.Parse(textBox4.Text);
            sj.Quantity = int.Parse(textBox5.Text);
            sj.Vehicle_id = int.Parse(textBox6.Text);
            sj.Employee_id = int.Parse(textBox7.Text);
            sj.Date_start = Convert.ToDateTime(dateTimePicker1.Text);
            sj.Date_end = Convert.ToDateTime(dateTimePicker2.Text);

            InsertSQL addHnd = new InsertSQL();
            int addrecord = addHnd.addNewStoringJob(sj);
            MessageBox.Show(addrecord + " Your record is added");
            this.Close();
        }

        private void updateStoringJob()
        {
            StoringJob sj = new StoringJob();
            sj.Description = textBox1.Text;
            sj.Harvest_id = int.Parse(textBox2.Text);
            sj.Crop_id = int.Parse(textBox3.Text);
            sj.Box_id = int.Parse(textBox4.Text);
            sj.Quantity = int.Parse(textBox5.Text);
            sj.Vehicle_id = int.Parse(textBox6.Text);
            sj.Employee_id = int.Parse(textBox7.Text);
            sj.Date_start = Convert.ToDateTime(dateTimePicker1.Text);
            sj.Date_end = Convert.ToDateTime(dateTimePicker2.Text);

            UpdateSQL update = new UpdateSQL();
            update.updateStoringJob(sj);
            MessageBox.Show(" Your record is added");
            this.Close();
        }

        private void FormStoringJob_Load(object sender, EventArgs e)
        {
            InsertSQL StoringJob = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = sj.Description;
                textBox2.Text = sj.Harvest_id.ToString();
                textBox3.Text = sj.Crop_id.ToString();
                textBox4.Text = sj.Box_id.ToString();
                textBox5.Text = sj.Quantity.ToString();
                textBox6.Text = sj.Vehicle_id.ToString();
                textBox7.Text = sj.Employee_id.ToString();
                dateTimePicker1.Value = sj.Date_start;
                dateTimePicker2.Value = sj.Date_end;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            addStoringJob();

            if (state == "Edit")
            {
                updateStoringJob();
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
                                        if (String.IsNullOrEmpty(textBox7.Text))
                                        {
                                            if (String.IsNullOrEmpty(dateTimePicker1.Text))
                                            {
                                                if (String.IsNullOrEmpty(dateTimePicker2.Text))
                                                {
                                                    MessageBox.Show("Please fill up the box");
                                                }
                                                MessageBox.Show("Please fill up the box");
                                            }
                                            MessageBox.Show("Please fill up the box");
                                        }
                                        MessageBox.Show("Please fill up the box");
                                    }
                                    MessageBox.Show("Please fill up the box");
                                }
                                MessageBox.Show("Please fill up the box");
                            }
                            MessageBox.Show("Please fill up the box");
                        }
                        MessageBox.Show("Please fill up the box");
                    }
                    MessageBox.Show("Please fill up the box");
                }
                else
                {
                    addStoringJob();
                }
            }
        }       
    }
}
