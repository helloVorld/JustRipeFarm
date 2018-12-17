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
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<SowingJob> sowingLists;
        List<HarvestingJob> harvestLists;
        List<Employee> employeeList;
        List<Fertiliser> fertiliserList;
        List<FertilisingJob> fertiliserLists;

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
                    if (String.IsNullOrEmpty(cbFertiliser.Text))
                    {
                        if (String.IsNullOrEmpty(textBox3.Text))
                        {
                            if (String.IsNullOrEmpty(cbSoj.Text))
                            {
                                if (String.IsNullOrEmpty(cbFarm.Text))
                                {
                                    if (String.IsNullOrEmpty(cbCrop.Text))
                                    {
                                        if (String.IsNullOrEmpty(cbVehicle.Text))
                                        {
                                            if (String.IsNullOrEmpty(cbEmployee.Text))
                                            {
                                                if (String.IsNullOrEmpty(dtpStart.Text))
                                                {
                                                    if (String.IsNullOrEmpty(dtpEnd.Text))
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

        public void checkAssignJobandAdd()
        {

            TestSQL ts = new TestSQL();
            cropLists = ts.GetCropList();
            employeeList = ts.GetEmployeeList();
            farmLists = ts.GetFarmList();
            vehicleList = ts.GetVehicleList();
            fertiliserLists = ts.GetFertilisingJobList();

            DateTime start_date = Convert.ToDateTime("12/12/2018");
            DateTime end_date = Convert.ToDateTime("12/12/2018");
            DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            int duration = 0; int todayduration = 0;
            foreach (Employee employee in employeeList)
            {
                foreach (FertilisingJob fertiliser in fertiliserLists)
                {
                    start_date = Convert.ToDateTime(fertiliser.Date_start.ToString());
                    end_date = Convert.ToDateTime(fertiliser.Date_end.ToString());
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFertiliser()
        {
            FertilisingJob fj = new FertilisingJob();
            fj.Description = textBox1.Text;
            string idStr = cbFertiliser.Text.Split('.')[0];
            fj.Fertiliser_id = int.Parse(idStr);
            fj.Quantity_kg = int.Parse(textBox3.Text);
            string idStr1 = cbSoj.Text.Split('.')[0];
            fj.SowingJob_id = int.Parse(idStr1);
            string idStr2 = cbFarm.Text.Split('.')[0];
            fj.Farm_id = int.Parse(idStr2);
            string idStr3 = cbVehicle.Text.Split('.')[0];
            fj.Vehicle_id = int.Parse(idStr3);
            string idStr4 = cbCrop.Text.Split('.')[0];
            fj.Crop_id = int.Parse(idStr4);
            string idStr5 = cbEmployee.Text.Split('.')[0];
            fj.Employee_id = int.Parse(idStr5);
            fj.Date_start = this.dtpStart.Value;
            fj.Date_end = this.dtpEnd.Value;

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewFertilisingJob(fj);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void updateFertiliser()
        {
            FertilisingJob fj = new FertilisingJob();
            fj.Description = textBox1.Text;
            string idStr = cbFertiliser.Text.Split('.')[0];
            fj.Fertiliser_id = int.Parse(idStr);
            fj.Quantity_kg = int.Parse(textBox3.Text);
            string idStr1 = cbSoj.Text.Split('.')[0];
            fj.SowingJob_id = int.Parse(idStr1);
            string idStr2 = cbFarm.Text.Split('.')[0];
            fj.Farm_id = int.Parse(idStr2);
            string idStr3 = cbVehicle.Text.Split('.')[0];
            fj.Vehicle_id = int.Parse(idStr3);
            string idStr4 = cbCrop.Text.Split('.')[0];
            fj.Crop_id = int.Parse(idStr4);
            string idStr5 = cbEmployee.Text.Split('.')[0];
            fj.Employee_id = int.Parse(idStr5);
            fj.Date_start = this.dtpStart.Value;
            fj.Date_end = this.dtpEnd.Value;

            UpdateSQL edit = new UpdateSQL();
            int editrecord = edit.updateFertilisingJob(fj);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void FormFertilisingJob_Load(object sender, EventArgs e)
        {
            InsertSQL FertilisingJob = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = jb1.Description;
                cbFertiliser.Text = jb1.Fertiliser_id.ToString();
                textBox3.Text = jb1.Quantity_kg.ToString();
                cbSoj.Text = jb1.SowingJob_id.ToString();
                cbFarm.Text = jb1.Farm_id.ToString();
                cbCrop.Text = jb1.Crop_id.ToString();
                cbVehicle.Text = jb1.Vehicle_id.ToString();
                cbEmployee.Text = jb1.Employee_id.ToString();
                dtpStart.Text = jb1.Date_start.ToString();
                dtpEnd.Text = jb1.Date_end.ToString();


                TestSQL ts = new TestSQL();
                cropLists = ts.GetCropList();
                employeeList = ts.GetEmployeeList();
                farmLists = ts.GetFarmList();
                vehicleList = ts.GetVehicleList();
                fertiliserList = ts.GetFertiliserList();
                sowingLists = ts.GetSowingJobList();
                employeeList = ts.GetEmployeeList();

                SowingJob sj11 = new SowingJob();

                foreach (SowingJob sow in sowingLists)
                {

                    cbSoj.Items.Add(sow.Id);

                }

                foreach (Crop crop1 in cropLists)
                {

                    string showText = crop1.Id + ". " + crop1.Name;
                    cbCrop.Items.Add(showText);

                }

                foreach (Fertiliser fertiliser in fertiliserList)
                {

                    string showText = fertiliser.Id + ". " + fertiliser.Name;
                    cbVehicle.Items.Add(showText);

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
                }
            }
        }
    }
}
