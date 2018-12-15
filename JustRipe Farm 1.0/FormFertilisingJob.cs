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
    public partial class FormFertilisingJob : Form
    {
        public string state = "";
        public FertilisingJob jb1;
        public FormFertilisingJob()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
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
                                        if (String.IsNullOrEmpty(textBox8.Text))
                                        {
                                            if (String.IsNullOrEmpty(dateTimePicker1.Text))
                                            {
                                                if (String.IsNullOrEmpty(dtpTimeStart.Text))
                                                {
                                                    if (String.IsNullOrEmpty(dtpTimeEnd.Text))
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
                            MessageBox.Show("Please fill up all the box");
                        }
                        MessageBox.Show("please fill up all the box");
                    }
                    MessageBox.Show("please fill up all the box");
                }
                MessageBox.Show("please fill up all the box");
            }
            else
                addFertiliser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFertiliser()
        {
            FertilisingJob fj = new FertilisingJob();
            fj.Description = textBox1.Text;
            fj.Fertiliser_id = Convert.ToInt32(textBox2.Text);
            fj.Quantity_kg = int.Parse(textBox3.Text);
            fj.SowingJob_id = int.Parse(textBox4.Text);
            fj.Farm_id = int.Parse(textBox5.Text);
            fj.Crop_id = int.Parse(textBox6.Text);
            fj.Vehicle_id = int.Parse(textBox7.Text);
            fj.Employee_id = int.Parse(textBox8.Text);
            fj.Date = Convert.ToDateTime(dateTimePicker1.Text);
            fj.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            fj.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewFertilisingJob(fj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void updateFertiliser()
        {
            FertilisingJob fj = new FertilisingJob();
            fj.Description = textBox1.Text;
            fj.Fertiliser_id = Convert.ToInt32(textBox2.Text);
            fj.Quantity_kg = int.Parse(textBox3.Text);
            fj.SowingJob_id = int.Parse(textBox4.Text);
            fj.Farm_id = int.Parse(textBox5.Text);
            fj.Crop_id = int.Parse(textBox6.Text);
            fj.Vehicle_id = int.Parse(textBox7.Text);
            fj.Employee_id = int.Parse(textBox8.Text);
            fj.Date = Convert.ToDateTime(dateTimePicker1.Text);
            fj.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            fj.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            UpdateSQL edit = new UpdateSQL();
            int editrecord = edit.updateFertilisingJob(fj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }
    }
}
