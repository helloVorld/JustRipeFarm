using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm.ClassEntity
{
    class InsertSQL
    {
        public int addNewCustomer(Customer customer)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " customer(name,email,phone,remark)" +
                                           " VALUES" + " (@name,@email,@phone,@remark)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = customer.Name;
            sqlComm.Parameters.Add("@email", MySqlDbType.Text).Value = customer.Email;
            sqlComm.Parameters.Add("@phone", MySqlDbType.Text).Value = customer.Phone;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = customer.Remark;

            return sqlComm.ExecuteNonQuery();
        }


        public int addNewStore(Storeroom storeroom)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " storeroom(description,storingQty,temperature,availability)" +
                                           " VALUES" + " (@description,@storingQty,@temperature,@availability)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = storeroom.Description;
            sqlComm.Parameters.Add("@storingQty", MySqlDbType.UInt32).Value = storeroom.StoringQty;
            sqlComm.Parameters.Add("@temperature", MySqlDbType.Text).Value = storeroom.Temperature;
            sqlComm.Parameters.Add("@availability", MySqlDbType.UInt64).Value = storeroom.Availability;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewVehicle(Vehicle vehicle)
        {
            
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " vehicle(name,serial_number,buy_date,last_service_date,remark)" +
                                           " VALUES" + " (@name,@serial_number,@buy_date,@last_service_date,@remark)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = vehicle.Name;
            sqlComm.Parameters.Add("@serial_number", MySqlDbType.UInt32).Value = vehicle.Serial_number;
            sqlComm.Parameters.Add("@buy_date", MySqlDbType.Date).Value = vehicle.Buy_date;
            sqlComm.Parameters.Add("@last_service_date", MySqlDbType.Date).Value = vehicle.Last_service_date;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = vehicle.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewOrder(Order order)
        {

            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " orders(description,product_id,quantity_box,weight,palletAllocation,customer_id,order_date,collection,price,status,remark)" +
                                           " VALUES" + " (@description,@product_id,@quantity_box,@weight,@palletAllocation,@customer_id,@order_date,@collection,@price,@status,@remark)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = order.Description;
            sqlComm.Parameters.Add("@product_id", MySqlDbType.UInt32).Value = order.Product_id;
            sqlComm.Parameters.Add("@quantity_box", MySqlDbType.UInt32).Value = order.Quantity_box;
            sqlComm.Parameters.Add("@weight", MySqlDbType.Decimal).Value = order.Weight;
            sqlComm.Parameters.Add("@palletAllocation", MySqlDbType.UInt32).Value = order.PalletAllocation;
            sqlComm.Parameters.Add("@customer_id", MySqlDbType.UInt32).Value = order.Customer_id;
            sqlComm.Parameters.Add("@order_date", MySqlDbType.Date).Value = order.Order_date;
            sqlComm.Parameters.Add("@collection", MySqlDbType.Date).Value = order.Collection_date;
            sqlComm.Parameters.Add("@price", MySqlDbType.Decimal).Value = order.Price;
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = order.Status;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = order.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewProduct(Product product)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " product(name,type,quantity_box,weight,box_id)" +
                                          " VALUES" + " (@name,@type,@quantity_box,@weight,@box_id)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = product.Name;
            sqlComm.Parameters.Add("@type", MySqlDbType.Text).Value = product.Type;
            sqlComm.Parameters.Add("@quantity_box", MySqlDbType.UInt32).Value = product.Quantity_box;
            sqlComm.Parameters.Add("@weight", MySqlDbType.Decimal).Value = product.Weight;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = product.Box_id;
            return sqlComm.ExecuteNonQuery();
        }

        public int addNewFarm(Farm farm)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " farm(description,area,utilize_area)" +
                                          " VALUES" + " (@description,@area,@utilize_area)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = farm.Description;
            sqlComm.Parameters.Add("@area", MySqlDbType.Int32).Value = farm.Area;
            sqlComm.Parameters.Add("@utilize_area", MySqlDbType.Int32).Value = farm.Utilize_area;
            return sqlComm.ExecuteNonQuery();
        }

        public int addNewEmployee(Employee employee)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " employee(first_name,last_name,username,password,dob,mobile,email,admin,status,remark)" +
                                          " VALUES" + " (@first_name,@last_name,@username,@password,@dob,@mobile,@email,@admin,@status,@remark)", MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@first_name", MySqlDbType.Text).Value = employee.First_name;
            sqlComm.Parameters.Add("@last_name", MySqlDbType.Text).Value = employee.Last_name;
            sqlComm.Parameters.Add("@username", MySqlDbType.Text).Value = employee.Username;
            sqlComm.Parameters.Add("@password", MySqlDbType.Text).Value = employee.Password;
            sqlComm.Parameters.Add("@dob", MySqlDbType.Date).Value = employee.Dob;
            sqlComm.Parameters.Add("@mobile", MySqlDbType.Text).Value = employee.Mobile;
            sqlComm.Parameters.Add("@email", MySqlDbType.Text).Value = employee.Email;
            sqlComm.Parameters.Add("@admin", MySqlDbType.UInt32).Value = employee.Admin;
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = employee.Status;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = employee.Remark;
            return sqlComm.ExecuteNonQuery();
        }

        public int addNewCrop(Crop crop)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " crop(name, type, quantity_plot, remark)" +
                                        "VALUES" + "(@name, @type, @quantity_plot, @remark)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = crop.Name;
            sqlComm.Parameters.Add("@type", MySqlDbType.Text).Value = crop.Type;
            sqlComm.Parameters.Add("@quantity_plot", MySqlDbType.UInt32).Value = crop.Quantity_plot;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = crop.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewBox(Box box)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " box(name, width, height, length, max_weight, quantity, status)" +
                                        "VALUES" + "(@name, @width, @height, @length, @max_weight, @quantity, @status)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = box.Name;
            sqlComm.Parameters.Add("@Width", MySqlDbType.Decimal).Value = box.Width;
            sqlComm.Parameters.Add("@Height", MySqlDbType.Decimal).Value = box.Height;
            sqlComm.Parameters.Add("@Length", MySqlDbType.Decimal).Value = box.Length;
            sqlComm.Parameters.Add("@max_weight", MySqlDbType.Decimal).Value = box.Max_weight;
            sqlComm.Parameters.Add("@quantity", MySqlDbType.UInt32).Value = box.Quantity;
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = box.Status;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewBoxStorage(BoxStorage boxstorage)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " box(storingJob_id, product_id, box_id, nettWeight, storeroom_id, add_date, best_before, out_date, order_id)" +
                                        "VALUES" + "(@storingJob_id, @product_id, @box_id, @nettWeight, @storeroom_id, @add_date, @best_before, @out_date, @order_id)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@storingJob_id", MySqlDbType.UInt32).Value = boxstorage.StoringJob_id;
            sqlComm.Parameters.Add("@product_id", MySqlDbType.UInt32).Value = boxstorage.Product_id;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = boxstorage.Box_id;
            sqlComm.Parameters.Add("@nettWeight", MySqlDbType.Decimal).Value = boxstorage.NettWeight;
            sqlComm.Parameters.Add("@storeroom_id", MySqlDbType.UInt32).Value = boxstorage.Storeroom_id;
            sqlComm.Parameters.Add("@add_date", MySqlDbType.Date).Value = boxstorage.Storeroom_id;
            sqlComm.Parameters.Add("@best_before", MySqlDbType.Date).Value = boxstorage.Storeroom_id;
            sqlComm.Parameters.Add("@out_date", MySqlDbType.Date).Value = boxstorage.Storeroom_id;
            sqlComm.Parameters.Add("@order_id", MySqlDbType.UInt32).Value = boxstorage.Storeroom_id;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewSowingJob(SowingJob sowingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " sowingjob(description, crop_id, quantity_prop, farm_id, used_area, vehicle_id, employee_id, date_start, date_end)" +      
                                            "VALUES" + "(@description, @crop_id, @quantity_prop, @farm_id, @used_area, @vehicle_id, @employee_id, @date_start, @date_end)", MysqlDbc.Instance.getConn()); 

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = sowingjob.Description;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = sowingjob.Crop_id;
            sqlComm.Parameters.Add("@quantity_prop", MySqlDbType.UInt32).Value = sowingjob.Quantity_prop;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = sowingjob.Farm_id;
            sqlComm.Parameters.Add("@used_area", MySqlDbType.Text).Value = sowingjob.Used_area;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = sowingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = sowingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = sowingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = sowingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewHarvestingJob(HarvestingJob harvestingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " harvestingjob(description, sowingJob_id, farm_id, crop_id, vehicle_id, est_quantity, harvested_quantity, employee_id, date_start, date_end)" +
                                            " VALUES" + " (@description, @sowingJob_id, @farm_id, @crop_id, @vehicle_id, @est_quantity, @harvested_quantity, @employee_id, @date_start, @date_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = harvestingjob.Description;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = harvestingjob.Crop_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = harvestingjob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = harvestingjob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = harvestingjob.Vehicle_id;
            sqlComm.Parameters.Add("@est_quantity", MySqlDbType.Text).Value = harvestingjob.Est_quantity;
            sqlComm.Parameters.Add("@harvested_quantity", MySqlDbType.Text).Value = harvestingjob.Harvested_quantity;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = harvestingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = harvestingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = harvestingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewStoringJob(StoringJob storingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " storingjob(description, harvest_id, crop_id, box_id, quantity, vehicle_id, employee_id, date_start, date_end)" +
                                        "VALUES" + "(@description, @harvest_id, @crop_id, @box_id, @quantity, @vehicle_id, @employee_id, @date_start, @date_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = storingjob.Description;
            sqlComm.Parameters.Add("@harvest_id", MySqlDbType.UInt32).Value = storingjob.Harvest_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = storingjob.Crop_id;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = storingjob.Box_id;
            sqlComm.Parameters.Add("@quantity", MySqlDbType.UInt32).Value = storingjob.Quantity;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = storingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = storingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = storingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = storingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewFertilisingJob(FertilisingJob fertilisingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " fertilisingjob(description, fertiliser_id, quantity_kg, sowingJob_id, farm_id, crop_id, vehicle_id, employee_id, date_start, date_end)" +
                                        "VALUES" + "(@description, @fertiliser_id, @quantity_kg, @sowingJob_id, @farm_id, @crop_id, @vehicle_id, @employee_id, @date_start, date_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = fertilisingjob.Description;
            sqlComm.Parameters.Add("@fertiliser_id", MySqlDbType.UInt32).Value = fertilisingjob.Fertiliser_id;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = fertilisingjob.Quantity_kg;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = fertilisingjob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = fertilisingjob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = fertilisingjob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = fertilisingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = fertilisingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = fertilisingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = fertilisingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewPesticideJob(PesticideJob pesticidejob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " pesticidejob(description, pesticide_id, quantity_kg, sowingJob_id, farm_id, crop_id, vehicle_id, employee_id, date_start, date_end)" +
                                       "VALUES" + "(@description, @pesticide_id, @quantity_kg, @sowingJob_id, @farm_id, @rop_id, @vehicle_id, @employee_id, @date_start, @date_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = pesticidejob.Description;
            sqlComm.Parameters.Add("@pesticide_id", MySqlDbType.UInt32).Value = pesticidejob.Pesticide_id;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.Decimal).Value = pesticidejob.Quantity_kg;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = pesticidejob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = pesticidejob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = pesticidejob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = pesticidejob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = pesticidejob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = pesticidejob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = pesticidejob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewFertiliser(Fertiliser fertiliser)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " fertiliser(name, quantity_kg, remark)" +
                                          " VALUES" + " (@name, @quantity_kg, @remark)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = fertiliser.Name;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = fertiliser.Quantity_kg;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = fertiliser.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewPesticide(Pesticide pesticide)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " pesticide(name, quantity_kg, remark)" +
                                         " VALUES" + " (@name, @quantity_kg, @remark)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = pesticide.Name;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = pesticide.Quantity_kg;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = pesticide.Remark;

            return sqlComm.ExecuteNonQuery();
        }
    }

    /// <summary>
    /// SAMPLE
    /// </summary>
    public class TestSQL
    {
        public bool addNewSowingJob(DateTime dt/*SowingJob sj*/)
        {
            // can test at main screen "btnTestSql"
            try
            {
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = MysqlDbc.Instance.getConn();
                cmd.CommandText = "INSERT INTO sowingjob VALUES(@id, @description, @crop_id, @quantity_prop, @farm_id, @used_area, @vehicle_id, @employee_id, @date, @time_start, @time_end)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id"           , 0);
                cmd.Parameters.AddWithValue("@description"  , "sowing at helpcat"/*sj.Description*/);
                cmd.Parameters.AddWithValue("@crop_id"      , 1/*sj.Crop_id*/);
                cmd.Parameters.AddWithValue("@quantity_prop", 213/*sj.Quantity_prop*/);
                cmd.Parameters.AddWithValue("@farm_id"      , 2/*sj.Farm_id*/);
                cmd.Parameters.AddWithValue("@used_area"    , "please change to int"/*sj.Used_area*/);
                cmd.Parameters.AddWithValue("@vehicle_id"   , 3/*sj.Vehicle_id*/);
                cmd.Parameters.AddWithValue("@employee_id"  , 4/*sj.Employee_id*/);
                cmd.Parameters.AddWithValue("@date"         , dt.ToString("yyyy-MM-dd")/*sj.Date.ToString("yyyy-MM-dd")*/);
                cmd.Parameters.AddWithValue("@time_start"   , dt.ToString("HH:mm:ss")/*sj.Time_start.ToString("HH:mm:ss")*/);
                cmd.Parameters.AddWithValue("@time_end"     , dt.ToString("HH:mm:ss")/*sj.Time_end.ToString("HH:mm:ss")*/);
                cmd.ExecuteNonQuery();

                Console.WriteLine("MySQL addNewSowingJob: success");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: {0}", ex.ToString());

            }
            return false;
        }

        // can test at form sowing job 
        // access through operation -> sowing job -> new sowing
        public List<Crop> GetCropList()
        {
            List<Crop> cropLists = new List<Crop>();
            MySqlDataReader rdr = null;
            try
            {


                string stm = "SELECT * FROM crop";
                MySqlCommand cmd = new MySqlCommand(stm, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Crop cr = new Crop();
                    cr.Id = rdr.GetInt32("id");
                    cr.Name = rdr.GetString("name");
                    cr.Type = rdr.GetString("type");
                    cr.Quantity_plot = rdr.GetInt32("quantity_plot");
                    cr.Remark = rdr.GetString("remark");

                    Console.WriteLine("crop => " + cr);
                    cropLists.Add(cr);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

            }

            return cropLists;
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> employeeLists = new List<Employee>();
            MySqlDataReader rdr = null;
            try
            {


                string stm = "SELECT * FROM employee";
                MySqlCommand cmd = new MySqlCommand(stm, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee emp = new Employee();
                    emp.Id = rdr.GetInt32("id");
                    emp.First_name = rdr.GetString("first_name");
                    emp.Last_name = rdr.GetString("last_name");
                    emp.Username = rdr.GetString("username");
                    emp.Password = rdr.GetString("password");
                    emp.Dob = rdr.GetDateTime("dob");
                    emp.Mobile = rdr.GetString("mobile");
                    emp.Email = rdr.GetString("email");
                    emp.Admin = rdr.GetBoolean("admin");
                    emp.Status = rdr.GetString("status");
                    emp.Remark = rdr.GetString("remark");
                    employeeLists.Add(emp);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

            }

            return employeeLists;
        }

        public List<Farm> GetFarmList()
        {
            List<Farm> farmLists = new List<Farm>();
            MySqlDataReader rdr = null;
            try
            {


                string stm = "SELECT * FROM farm";
                MySqlCommand cmd = new MySqlCommand(stm, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Farm far = new Farm();
                    far.Id = rdr.GetInt32("id");
                    far.Description = rdr.GetString("description");
                    far.Area = rdr.GetInt32("area");
                    far.Utilize_area = rdr.GetInt32("utilize_area");

                    //Console.WriteLine("crop => " + cr);
                    farmLists.Add(far);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

            }

            return farmLists;
        }

        public List<Vehicle> GetVehicleList()
        {
            List<Vehicle> vehicleLists = new List<Vehicle>();
            MySqlDataReader rdr = null;
            try
            {


                string stm = "SELECT * FROM vehicle";
                MySqlCommand cmd = new MySqlCommand(stm, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Vehicle vehc = new Vehicle();
                    vehc.Id = rdr.GetInt32("id");
                    vehc.Name = rdr.GetString("name");
                    vehc.Serial_number = rdr.GetString("serial_number");
                    vehc.Buy_date = rdr.GetDateTime("buy_date");
                    vehc.Last_service_date = rdr.GetDateTime("last_service_date");
                    vehc.Remark = rdr.GetString("remark");

                    //Console.WriteLine("crop => " + cr);
                    vehicleLists.Add(vehc);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

            }

            return vehicleLists;
        }

        public List<SowingJob> GetSowingJobList() //string employee_id
        {
            List<SowingJob> sowingLists = new List<SowingJob>();
            MySqlDataReader rdr = null;
            try
            {


                string stm = "SELECT * FROM sowingjob";
                MySqlCommand cmd = new MySqlCommand(stm, MysqlDbc.Instance.getConn());
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SowingJob sj1 = new SowingJob();
                    sj1.Id = rdr.GetInt32("id"); ;
                    sj1.Description = rdr.GetString("description");
                    sj1.Crop_id = rdr.GetInt32("crop_id");
                    sj1.Quantity_prop = rdr.GetInt32("quantity_prop");
                    sj1.Farm_id = rdr.GetInt32("farm_id");
                    sj1.Used_area = rdr.GetString("used_area");
                    sj1.Vehicle_id = rdr.GetInt32("vehicle_id");
                    sj1.Employee_id = rdr.GetInt32("employee_id");
                    sj1.Date_start = rdr.GetDateTime("date_start");
                    sj1.Date_end = rdr.GetDateTime("date_end");

                    sowingLists.Add(sj1);

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

            }

            return sowingLists;
        }

    }
}
