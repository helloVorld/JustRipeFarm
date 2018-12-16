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
    public partial class FormSowingJob : Form
    {
        // prepare variable for storing list<class>
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<SowingJob> sowingJob;
        List<Employee> employeeList;
        public string state = "";
        public SowingJob sowj;

        public FormSowingJob()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                update();
            }
            else
            {
                if (String.IsNullOrEmpty(tbDescription.Text))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(cbCrop.Text)))
                    {
                        if (String.IsNullOrEmpty(Convert.ToString(nUDQty.Text)))
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(cbFarm.Text)))
                            {
                                if (String.IsNullOrEmpty(Convert.ToString(nUDArea.Text)))
                                {
                                    if (String.IsNullOrEmpty(Convert.ToString(cbVehicle.Text)))
                                    {
                                        if (String.IsNullOrEmpty(Convert.ToString(cbEmployee.Text)))
                                        {
                                            if (String.IsNullOrEmpty(Convert.ToString(dtpDate.Text)))
                                            {
                                                if (String.IsNullOrEmpty(Convert.ToString(dtpDateEnd.Text)))
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
                else
                {
                    checkAsignJobandAdd();
                }
            }
        }
        public void add()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = Int32.Parse(cbCrop.Text);
            s1.Quantity_prop = Int32.Parse(nUDQty.Text);
            s1.Farm_id = Int32.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = Int32.Parse(cbVehicle.Text);
            s1.Employee_id = Int32.Parse(cbEmployee.Text);
            s1.Date_start = this.dtpDate.Value;
            s1.Date_end = this.dtpDateEnd.Value;
            //s1.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            //s1.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewSowingJob(s1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        public void update()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = int.Parse(cbCrop.Text);
            s1.Quantity_prop = int.Parse(nUDQty.Text);
            s1.Farm_id = int.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = int.Parse(cbVehicle.Text);
            s1.Employee_id = int.Parse(cbEmployee.Text);
            s1.Date_start = this.dtpDate.Value;
            s1.Date_end = this.dtpDateEnd.Value;
            //s1.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            //.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            UpdateSQL add = new UpdateSQL();
            int addrecord = add.UpdateSowingJob(s1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSowingJob_Load(object sender, EventArgs e)
        {
            InsertSQL sowing = new InsertSQL();
            //productLists = order1.GetPorductList();

            if (state == "Edit")
            {
                tbDescription.Text = sowj.Description;
                cbCrop.Text = sowj.Crop_id.ToString();
                nUDQty.Text = sowj.Quantity_prop.ToString();
                cbFarm.Text = sowj.Farm_id.ToString();
                nUDArea.Text = sowj.Used_area.ToString();
                cbVehicle.Text = sowj.Vehicle_id.ToString();
                cbEmployee.Text = sowj.Employee_id.ToString();
                dtpDate.Value = sowj.Date_start;
                dtpDateEnd.Value = sowj.Date_end;
            }
            // when form loads, get all fields data from mysql
            // then store to a bunch of list<class>
            // then all combo boxes gets data from the list<class>

            // mysql :
            // 1. get crop list from crop table
            // 2. get farm list from farm table
            // 3. get vehicle list from vehicle table
            // 4. get employee list from employee table

            // combo box
            // 5. load crop list to combo box 
            // 6. load farm list to combo box 
            // 7. load vehicle list to combo box 
            // 8. load employee list to combo box 

            // 1. 
            //TestSQL ts = new TestSQL();
            //cropLists = ts.GetCropList();
            //employeeList = ts.GetEmployeeList();
            //farmLists = ts.GetFarmList();
            //vehicleList = ts.GetVehicleList();
            //SowingJob sj11 = new SowingJob();

            // 5.
            //    foreach (Crop crop in cropLists)
            //    {
            //        //cbCrop.Items.Add(crop.Name);

            //        string tableName = "sowingjob";
            //        string query = "SELECT id FROM " + tableName + " WHERE name = " + crop.Name;
            //        MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());

            //        cbCrop.Items.Add(crop.Id + ". " + crop.Name);

            //    }

            //    foreach (Vehicle vehicle in vehicleList)
            //    {

            //        cbVehicle.Items.Add(vehicle.Id.ToString() + ". " + vehicle.Name);


            //    }

            //    foreach (Employee employee in employeeList)
            //    {
            //        if (employee.Admin == false)
            //        {

            //            cbEmployee.Items.Add(employee.Id.ToString() + ". " + employee.Username);

            //        }

            //    }

            //    foreach (Farm farm in farmLists)
            //    {

            //        cbFarm.Items.Add(farm.Id.ToString() + ". " + farm.Description);

            //    }
        }
        public void checkAsignJobandAdd()
        {
            string tableName = "sowingJob";
            string query = "SELECT * FROM " + tableName;

            SowingJob sj2 = new SowingJob();
            
            bool active =Convert.ToBoolean(sj2.Employee_id);
            dtpDate.Value = sj2.Date_start;
            dtpDateEnd.Value = sj2.Date_end;
            //DateTime currentTime = DateTime.Today;
           
            

            TimeSpan ts = dtpDateEnd.Value - dtpDate.Value;

            int days = ts.Days;

            if (days <= 0)
            {
                if (sj2.Employee_id == 1)
                {
                    MessageBox.Show("cannoot assign!!");
                    active = true;
                }
                else
                    add();
            }
            else
            {
                MessageBox.Show("You cannot assign Job anymore!!");
            }
        }

        private void nUDQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCrop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
