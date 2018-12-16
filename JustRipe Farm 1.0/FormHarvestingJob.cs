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
    public partial class FormHarvestingJob : Form
    {
        public string state = "";
        public HarvestingJob hj1;
        public FormHarvestingJob()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                updateHarvestingJob();
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
                                    if (String.IsNullOrEmpty(numericUpDown1.Text))
                                    {
                                        if (String.IsNullOrEmpty(numericUpDown2.Text))
                                        {
                                            if (String.IsNullOrEmpty(textBox6.Text))
                                            {
                                                if (String.IsNullOrEmpty(dateTimePicker1.Text))
                                                {
                                                    if (String.IsNullOrEmpty(dtpTimeStart.Text))
                                                    {
                                                        if (String.IsNullOrEmpty(dtpTimeEnd.Text))
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
                    MessageBox.Show("Please fill up the box");
                }
                else
                {
                    addHarvestingJob();
                }
            }
        }

        private void addHarvestingJob()
        {
            HarvestingJob hj = new HarvestingJob();
            hj.Description = textBox1.Text;
            hj.SowingJob_id = Convert.ToInt32(textBox2.Text);
            hj.Farm_id = int.Parse(textBox3.Text);
            hj.Crop_id = int.Parse(textBox4.Text);
            hj.Vehicle_id = int.Parse(textBox5.Text);
            hj.Est_quantity = int.Parse(numericUpDown1.Text);
            hj.Harvested_quantity = int.Parse(numericUpDown2.Text);
            hj.Employee_id = int.Parse(textBox6.Text);
            hj.Date = Convert.ToDateTime(dateTimePicker1.Text);
            hj.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            hj.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            InsertSQL hdl = new InsertSQL();
            hdl.addNewHarvestingJob(hj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void updateHarvestingJob()
        {
            HarvestingJob hj = new HarvestingJob();
            hj.Description = textBox1.Text;
            hj.SowingJob_id = Convert.ToInt32(textBox2.Text);
            hj.Farm_id = int.Parse(textBox3.Text);
            hj.Crop_id = int.Parse(textBox4.Text);
            hj.Vehicle_id = int.Parse(textBox5.Text);
            hj.Est_quantity = int.Parse(numericUpDown1.Text);
            hj.Harvested_quantity = int.Parse(numericUpDown2.Text);
            hj.Employee_id = int.Parse(textBox6.Text);
            hj.Date = this.dateTimePicker1.Value;
            hj.Time_start = this.dtpTimeStart.Value;
            hj.Time_end = this.dtpTimeEnd.Value;

            UpdateSQL hdl = new UpdateSQL();
            hdl.updateHarvestingJob(hj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void FormHarvestingJob_Load(object sender, EventArgs e)
        {
            InsertSQL crop = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = hj1.Description;
                textBox2.Text = hj1.SowingJob_id.ToString();
                textBox3.Text = hj1.Farm_id.ToString();
                textBox4.Text = hj1.Crop_id.ToString();
                textBox5.Text = hj1.Vehicle_id.ToString();
                numericUpDown1.Text = hj1.Est_quantity.ToString();
                numericUpDown2.Text = hj1.Harvested_quantity.ToString();
                textBox6.Text = hj1.Employee_id.ToString();
                dateTimePicker1.Text = hj1.Date.ToString();
                dtpTimeStart.Text = hj1.Time_start.ToString();
                dtpTimeEnd.Text = hj1.Time_end.ToString();
            }
        }
    }
}
