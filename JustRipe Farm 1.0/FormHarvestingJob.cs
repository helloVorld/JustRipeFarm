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
            addHarvestingJob();
            updateHarvestingJob();
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
            hj.Date = Convert.ToDateTime(dateTimePicker1.Text);
            hj.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            hj.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            UpdateSQL hdl = new UpdateSQL();
            hdl.updateHarvestingJob(hj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }
    }
}
