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
            pj.Date = Convert.ToDateTime(dateTimePicker1.Text);
            pj.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            pj.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

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
            pj.Date = Convert.ToDateTime(dateTimePicker1.Text);
            pj.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            pj.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            UpdateSQL hdl = new UpdateSQL();
            hdl.updatePesticideJob(pj);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            addPesticideJob();
            //updatePesticideJob();
        }
    }
}
