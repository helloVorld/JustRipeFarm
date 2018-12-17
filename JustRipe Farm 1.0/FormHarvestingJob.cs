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
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<SowingJob> sowingLists;
        List<HarvestingJob> harvestLists;
        List<Employee> employeeList;
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
                    if (String.IsNullOrEmpty(cbSoj.Text))
                    {
                        if (String.IsNullOrEmpty(cbFarm.Text))
                        {
                            if (String.IsNullOrEmpty(cbCrop.Text))
                            {
                                if (String.IsNullOrEmpty(cbVehicle.Text))
                                {
                                    if (String.IsNullOrEmpty(numericUpDown1.Text))
                                    {
                                        if (String.IsNullOrEmpty(numericUpDown2.Text))
                                        {
                                            if (String.IsNullOrEmpty(cbEmployee.Text))
                                            {
                                                if (String.IsNullOrEmpty(dtpStart.Text))
                                                {
                                                    if (String.IsNullOrEmpty(dtpEnd.Text))
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
                    //checkAssignJobandAdd();
                    addHarvestingJob();
                }
            }
        }

        private void addHarvestingJob()
        {
            HarvestingJob hj = new HarvestingJob();
            hj.Description = textBox1.Text;
            hj.SowingJob_id = Convert.ToInt32(cbSoj.Text);
            string idStr = cbFarm.Text.Split('.')[0];
            hj.Farm_id = int.Parse(idStr);
            string idStr1 = cbCrop.Text.Split('.')[0];
            hj.Crop_id = int.Parse(idStr1);
            string idStr2 = cbVehicle.Text.Split('.')[0];
            hj.Vehicle_id = int.Parse(idStr2);
            hj.Est_quantity = int.Parse(numericUpDown1.Text);
            hj.Harvested_quantity = int.Parse(numericUpDown2.Text);
            string idStr3 = cbEmployee.Text.Split('.')[0];
            hj.Employee_id = int.Parse(idStr3);
            hj.Date_start = Convert.ToDateTime(dtpStart1.Value);
            hj.Date_end = Convert.ToDateTime(dtpEnd.Value);

            InsertSQL hdl = new InsertSQL();
            hdl.addNewHarvestingJob(hj);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void updateHarvestingJob()
        {
            HarvestingJob hj = new HarvestingJob();
            hj.Description = textBox1.Text;
            hj.SowingJob_id = Convert.ToInt32(cbSoj.Text);
            string idStr = cbFarm.Text.Split('.')[0];
            hj.Farm_id = int.Parse(idStr);
            string idStr1 = cbCrop.Text.Split('.')[0];
            hj.Crop_id = int.Parse(idStr1);
            string idStr2 = cbVehicle.Text.Split('.')[0];
            hj.Vehicle_id = int.Parse(idStr2);
            hj.Est_quantity = int.Parse(numericUpDown1.Text);
            hj.Harvested_quantity = int.Parse(numericUpDown2.Text);
            string idStr3 = cbEmployee.Text.Split('.')[0];
            hj.Employee_id = int.Parse(idStr3);
            hj.Date_start = Convert.ToDateTime(dtpStart1.Value);
            hj.Date_end = Convert.ToDateTime(dtpEnd.Value);

            UpdateSQL hdl = new UpdateSQL();
            hdl.updateHarvestingJob(hj);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void FormHarvestingJob_Load(object sender, EventArgs e)
        {
            InsertSQL crop = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = hj1.Description;
                cbSoj.Text = hj1.SowingJob_id.ToString();
                cbFarm.Text = hj1.Farm_id.ToString();
                cbCrop.Text = hj1.Crop_id.ToString();
                cbVehicle.Text = hj1.Vehicle_id.ToString();
                numericUpDown1.Text = hj1.Est_quantity.ToString();
                numericUpDown2.Text = hj1.Harvested_quantity.ToString();
                cbEmployee.Text = hj1.Employee_id.ToString();
                dtpStart1.Text = hj1.Date_start.ToString();
                dtpEnd.Text = hj1.Date_end.ToString();


                TestSQL ts = new TestSQL();
                cropLists = ts.GetCropList();
                employeeList = ts.GetEmployeeList();
                farmLists = ts.GetFarmList();
                vehicleList = ts.GetVehicleList();
                sowingLists = ts.GetSowingJobList();

                SowingJob sj11 = new SowingJob();

                foreach (SowingJob sow in sowingLists)
                {

                    cbCrop.Items.Add(sow.Id);

                }

                foreach (Crop crop1 in cropLists)
                {

                    string showText = crop1.Id + ". " + crop1.Name;
                    cbCrop.Items.Add(showText);

                }

                foreach (Vehicle vehicle in vehicleList)
                {

                    string showText = vehicle.Id + ". " + vehicle.Name;
                    cbVehicle.Items.Add(showText);

                }

                foreach (Employee employee in employeeList)
                {
                    if (employee.Admin == false)
                    {
                        string showText = employee.Id + ". " + employee.Username;
                        cbEmployee.Items.Add(showText);
                    }

                }

                foreach (Farm farm in farmLists)
                {
                    string showText = farm.Id + ". " + farm.Description;
                    cbFarm.Items.Add(showText);
                    //cbFarm.Items.Add(farm.Id);
                    //cbFarm.Items.Add(farm.Description);
                }
            }
        }

            public void checkAssignJobandAdd()
            {
                
                TestSQL ts = new TestSQL();
                cropLists = ts.GetCropList();
                employeeList = ts.GetEmployeeList();
                farmLists = ts.GetFarmList();
                vehicleList = ts.GetVehicleList();
                harvestLists = ts.GetHarvestingJobList();

                DateTime start_date = Convert.ToDateTime("12/12/2018");
                DateTime end_date = Convert.ToDateTime("12/12/2018");
                DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
                int duration = 0; int todayduration = 0;
                foreach (Employee employee in employeeList)
                {
                    foreach (HarvestingJob harvest in harvestLists)
                    {
                        start_date = Convert.ToDateTime(harvest.Date_start.ToString());
                        end_date = Convert.ToDateTime(harvest.Date_end.ToString());
                        duration = Convert.ToInt32((end_date - start_date).TotalDays);
                        todayduration = Convert.ToInt32((currentDate - start_date).TotalDays);
                        if (duration < todayduration)
                        {
                            cbEmployee.Items.Add(employee.Id.ToString());
                            //add();
                            MessageBox.Show("yes");
                        }
                        else
                        {
                            MessageBox.Show("no");
                        }
                    }
                }
            }
    }
}
