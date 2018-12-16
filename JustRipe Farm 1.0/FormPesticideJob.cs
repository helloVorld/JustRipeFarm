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
    public partial class FormPesticideJob : Form
    {
        public string state = "";
        public PesticideJob pjj1;
        public FormPesticideJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPesticideJob()
        {
            PesticideJob pj = new PesticideJob();
            pj.Description = textBox1.Text;
            pj.Pesticide_id = Convert.ToInt32(textBox2.Text);
            pj.Quantity_kg = int.Parse(textBox3.Text);
            pj.SowingJob_id = int.Parse(textBox4.Text);
            pj.Farm_id = int.Parse(textBox5.Text);
            pj.Crop_id = int.Parse(textBox6.Text);
            pj.Vehicle_id = int.Parse(textBox7.Text);
            pj.Employee_id = int.Parse(textBox8.Text);
            pj.Date_start = Convert.ToDateTime(dateTimePicker1.Text);
            pj.Date_end = Convert.ToDateTime(dateTimePicker2.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewPesticideJob(pj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void updatePesticideJob()
        {
            PesticideJob pj = new PesticideJob();
            pj.Description = textBox1.Text;
            pj.Pesticide_id = Convert.ToInt32(textBox2.Text);
            pj.Quantity_kg = int.Parse(textBox3.Text);
            pj.SowingJob_id = int.Parse(textBox4.Text);
            pj.Farm_id = int.Parse(textBox5.Text);
            pj.Crop_id = int.Parse(textBox6.Text);
            pj.Vehicle_id = int.Parse(textBox7.Text);
            pj.Employee_id = int.Parse(textBox8.Text);
            pj.Date_start = Convert.ToDateTime(dateTimePicker1.Text);
            pj.Date_end = Convert.ToDateTime(dateTimePicker2.Text);

            UpdateSQL hdl = new UpdateSQL();
            hdl.updatePesticideJob(pj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                updatePesticideJob();
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
                                                    if (String.IsNullOrEmpty(dateTimePicker1.Text))
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
                    MessageBox.Show("Please fill up the box");
                }
                else
                {
                    addPesticideJob();
                }
            }
            
        }

        private void FormPesticideJob_Load(object sender, EventArgs e)
        {
            InsertSQL pesticideJob = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = pjj1.Description;
                textBox2.Text = pjj1.Pesticide_id.ToString();
                textBox3.Text = pjj1.Quantity_kg.ToString();
                textBox4.Text = pjj1.SowingJob_id.ToString();
                textBox5.Text = pjj1.Farm_id.ToString();
                textBox6.Text = pjj1.Crop_id.ToString();
                textBox7.Text = pjj1.Vehicle_id.ToString();
                textBox8.Text = pjj1.Employee_id.ToString();
                dateTimePicker1.Value = pjj1.Date_start;
                dateTimePicker2.Value = pjj1.Date_end;
            }
        }
    }
}
