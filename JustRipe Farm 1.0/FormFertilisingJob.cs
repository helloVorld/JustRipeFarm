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
            if (state == "Edit")
            {
                updateFertiliser();
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
                                            if (String.IsNullOrEmpty(textBox8.Text))
                                            {
                                                if (String.IsNullOrEmpty(dateTimePicker1.Text))
                                                {
                                                    if (String.IsNullOrEmpty(dateTimePicker2.Text))
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
                                MessageBox.Show("Please fill up all the box");
                            }
                            MessageBox.Show("please fill up all the box");
                        }
                        MessageBox.Show("please fill up all the box");
                    }
                    MessageBox.Show("please fill up all the box");
                }
                else
                {
                    addFertiliser();
                }
            }
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
            fj.Date_start = this.dateTimePicker1.Value;
            fj.Date_end = this.dateTimePicker2.Value;

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
            fj.Date_start = this.dateTimePicker1.Value;
            fj.Date_end = this.dateTimePicker2.Value;

            UpdateSQL edit = new UpdateSQL();
            int editrecord = edit.updateFertilisingJob(fj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void FormFertilisingJob_Load(object sender, EventArgs e)
        {
            InsertSQL FertilisingJob = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = jb1.Description;
                textBox2.Text = jb1.Fertiliser_id.ToString();
                textBox3.Text = jb1.Quantity_kg.ToString();
                textBox4.Text = jb1.SowingJob_id.ToString();
                textBox5.Text = jb1.Farm_id.ToString();
                textBox6.Text = jb1.Crop_id.ToString();
                textBox7.Text = jb1.Vehicle_id.ToString();
                textBox8.Text = jb1.Employee_id.ToString();
                dateTimePicker1.Text = jb1.Date_start.ToString();
                dateTimePicker2.Text = jb1.Date_end.ToString();
            }
        }
    }
}
