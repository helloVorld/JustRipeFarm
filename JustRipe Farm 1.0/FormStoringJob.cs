using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using JustRipeFarm.ClassEntity;

namespace JustRipeFarm
{
    public partial class FormStoringJob : Form
    {
        public FormStoringJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckStoringJob(string description, int harvest_id, int crop_id, int box_id, int quantity, int vehicle_id, 
                                        int employee_id, DateTime date, DateTime time_start, DateTime time_end)
        {
            bool ck1 = String.IsNullOrEmpty(description);
            bool ck2 = String.IsNullOrEmpty(harvest_id.ToString());
            bool ck3 = String.IsNullOrEmpty(crop_id.ToString());
            bool ck4 = String.IsNullOrEmpty(box_id.ToString());
            bool ck5 = String.IsNullOrEmpty(quantity.ToString());
            bool ck6 = String.IsNullOrEmpty(vehicle_id.ToString());
            bool ck7 = String.IsNullOrEmpty(employee_id.ToString());
            bool ck8 = String.IsNullOrEmpty(date.ToString());
            bool ck9 = String.IsNullOrEmpty(time_start.ToString());
            bool ck10 = String.IsNullOrEmpty(time_end.ToString());

            if (ck1 && ck2 && ck3 && ck4 && ck5 && ck6 && ck7 && ck8 && ck9 && ck10 == true)
            {
                StoringJob sj = new StoringJob();
                sj.Description = textBox1.Text;
                sj.Harvest_id = Convert.ToInt32(textBox2.Text);
                sj.Crop_id = Convert.ToInt32(textBox3.Text);
                sj.Box_id = Convert.ToInt32(textBox4.Text);
                sj.Quantity = Convert.ToInt32(textBox5.Text);
                sj.Vehicle_id = Convert.ToInt32(textBox6.Text);
                sj.Employee_id = Convert.ToInt32(textBox7.Text);
                sj.Date = Convert.ToDateTime(dateTimePicker1.Text);
                sj.Time_start = Convert.ToDateTime(dateTimePicker2.Text);
                sj.Time_end = Convert.ToDateTime(dateTimePicker3.Text);

                InsertSQL addHnd = new InsertSQL();
                int addrecord = addHnd.addNewStoringJob(sj);
                MessageBox.Show(addrecord + " Your record is added");
            }
            else
            {
                ErrorMsg.UpdateOptionNoSelect();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            CheckStoringJob(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text),
                        Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker3.Text));
        }
    }
}
