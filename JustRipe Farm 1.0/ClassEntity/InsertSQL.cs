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
    }

    public class BoxHandler
    {
        public int addNewBox(MySqlConnection conn, Box box)
        {
            string sql = "INSERT INTO Box (name, width, height, length, max_weight, quantity, status) "
                        + " Values ('" + box.Name + "', " + box.Width + ", "
                        +  box.Height + ", " + box.Length + ", " + box.Max_weight + ", " 
                        +  box.Quantity + ", )";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class OrderHandler
    {
        public int addNewOrder(MySqlConnection conn, Order order)
        {
            string sql = "INSERT INTO orders (description, product_id, quantity_box, weight, palletAllocation, " +
                "                               customer_id, order_date, collection_date, price, status, remark) "
                        + " Values ('" + order.Description + "', " + order.Product_id + ", " + order.Quantity_box + ", " 
                        + order.Weight + " , '" + order.PalletAllocation + "', " + order.Customer_id + " , " 
                        + order.Order_date +" ," + order.Collection_date +" , " + order.Price + ", '"
                        + order.Status + "' , '" + order.Remark + "' )";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
    public class ProductHandler
    {
        public int addNewProduct(MySqlConnection conn, Product product)
        {
            string sql = "INSERT INTO product (name, type, quantity_box, weight, box_id) "
                        + " Values ('" + product.Name + "', '" + product.Type + "', " + product.Quantity_box + " , "
                        + product.Weight + " , " +product.Box_id + "`)";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class FarmHandler
    {
        public int addNewFarm(MySqlConnection conn, Farm farm)
        {
            string sql = "INSERT INTO farm (description, area, utilize_area) "
                        + " Values ('" + farm.Description + "', '" + farm.Area + "', '" + farm.Utilize_area + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class EmployeeHandler
    {
        public int addNewEmployee(MySqlConnection conn, Employee employee)
        {
            string sql = "INSERT INTO employee (first_name, last_name, username, password, dob, " +
                                                 "mobile, email, admin, status, remark) "
                        + " Values ('" + employee.First_name + "', '" + employee.Last_name + "', '" + employee.Username + "' , '"
                        + employee.Password + "' , '" + employee.Dob + "' , '" + employee.Mobile + "' , " + employee.Admin + " , '"
                        + employee.Status + "' , '" + employee.Remark + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class CustomerHandler
    {
        public int addNewCustomer(MySqlConnection conn, Customer customer)
        {
            string sql = "INSERT INTO customer (name, email, phone, remark) "
                        + " Values ('" + customer.Name + "', '" + customer.Email + "', '" + customer.Phone + "' , '"
                        + customer.Remark + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class StoreroomHandler
    {
        public int addNewStore(MySqlConnection conn, Storeroom storeroom)
        {
            string sql = "INSERT INTO storeroom (description, storingQty, temperature, availability) "
                        + " Values ('" + storeroom.Description + "', " + storeroom.StoringQty + ", " + storeroom.Temperature + " , '"
                        + storeroom.Availability + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class CropHandler
    {
        public int addNewCrop(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crop (name, type, quantity_plot, remark) "
                        + " Values ('" + crop.Name + "', '" + crop.Type + "', " + crop.Quantity_plot + " , '"
                        + crop.Remark + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class VehicleHandler
    {
        public int addNewVehicle(MySqlConnection conn, Vehicle vehicle)
        {
            string sql = "INSERT INTO vehicle (name, serial_number, buy_date, last_service_date, remark) "
                        + " Values ('" + vehicle.Name + "', " + vehicle.Serial_number + ", " + vehicle.Buy_date + " , "
                        + vehicle.Last_service_date + " , '" + vehicle.Remark + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class BoxStorageHandler
    {
        public int addNewBoxStorage(MySqlConnection conn, BoxStorage boxstorage)
        {
            string sql = "INSERT INTO boxStorage (storingJob_id, product_id, box_id, nettWeight, storeroom_id" +
                         " add_date, best_before, out_date, order_id) "
                        + " Values (" + boxstorage.StoringJob_id + ", " + boxstorage.Product_id + ", " + boxstorage.Box_id + " , "
                        + boxstorage.NettWeight + " , " + boxstorage.Storeroom_id + " , " + boxstorage.Add_date + " , "
                        + boxstorage.Best_before + " , " + boxstorage.Out_date + " , " + boxstorage.Order_id + " )";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class SowingJobHandler
    {
        public int addNewSowingJob(MySqlConnection conn, SowingJob sowingjob)
        {
            string sql = "INSERT INTO sowingJob (description, crop_id, quantity_prop, farm_id, used_area, " +
                         " vehicle_id, employee_id, date, time_start, time_end) "
                        + " Values ('" + sowingjob.Description + "', " + sowingjob.Crop_id + ", " + sowingjob.Quantity_prop + " , "
                        + sowingjob.Farm_id + " , '" + sowingjob.Used_area + "' , " + sowingjob.Vehicle_id + " , "
                        + sowingjob.Employee_id + " , " + sowingjob.Date + " , " + sowingjob.Time_start + "," 
                        + sowingjob.Time_end + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class HarvestingJobHandler
    {
        public int addNewHarvestingJob(MySqlConnection conn,HarvestingJob harvestingjob)
        {
            string sql = "INSERT INTO harvestingJob (description, sowingJob_id, farm_id, crop_id, vehicle_id " +
                         "est_quantity, harvested_quantity, employee_id, date, time_start, time_end) "
                        + " Values ('" + harvestingjob.Description + "', " + harvestingjob.SowingJob_id  + ", " + harvestingjob.Farm_id + " , "
                        + harvestingjob.Crop_id + " , " + harvestingjob.Vehicle_id + " , " + harvestingjob.Est_quantity + " , "
                        + harvestingjob.Harvested_quantity + " , " + harvestingjob.Employee_id + " , " + harvestingjob.Date + ", "
                        + harvestingjob.Time_start + " , " + harvestingjob.Time_end + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class StoringJobHandler
    {
        public int addNewStoringJob(MySqlConnection conn, StoringJob storingjob)
        {
            string sql = "INSERT INTO storingJob (description, harvest_id, crop_id, box_id, quantity " +
                         "vehicle_id, employee_id, date, time_start, time_end) "
                        + " Values ('" + storingjob.Description + "', " + storingjob.Harvest_id + ", " + storingjob.Crop_id + " , "
                        + storingjob.Box_id + " , " + storingjob.Quantity + " , " + storingjob.Vehicle_id + " , "
                        + storingjob.Employee_id + " , " + storingjob.Date + ", " + storingjob.Time_start + " ,"
                        + storingjob.Time_end + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class FertilisingJobHandler
    {
        public int addNewFertilisingJob(MySqlConnection conn, FertilisingJob fertilisingjob)
        {
            string sql = "INSERT INTO fertilisingJob (description, fertiliser_id, quantity_kg, sowingJob_id, farm_id" +
                         "crop_id, vehicle_id, employee_id, date, time_start, time_end) "
                        + " Values ('" + fertilisingjob.Description + "', " + fertilisingjob.Fertiliser_id + ", " + fertilisingjob.Quantity_kg + " , "
                        + fertilisingjob.SowingJob_id + " , " + fertilisingjob.Farm_id + " , " + fertilisingjob.Crop_id + " , "
                        + fertilisingjob.Vehicle_id + " , " + fertilisingjob.Employee_id + " , " + fertilisingjob.Date + " , "
                        + fertilisingjob.Time_start + " , " + fertilisingjob.Time_end + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class PesticideJobHandler
    {
        public int addNewPesticideJob(MySqlConnection conn, PesticideJob pesticidejob)
        {
            string sql = "INSERT INTO pesticideJob (description, pesticide_id, quantity_kg, sowingJob_id, farm_id" +
                         "crop_id, vehicle_id, employee_id, date, time_start, time_end) "
                        + " Values ('" + pesticidejob.Description + "', " + pesticidejob.Pesticide_id + ", " + pesticidejob.Quantity_kg + " , "
                        + pesticidejob.SowingJob_id + " , " + pesticidejob.Farm_id + " , " + pesticidejob.Crop_id + " , "
                        + pesticidejob.Vehicle_id + " , " + pesticidejob.Employee_id + " , " + pesticidejob.Date + " , "
                        + pesticidejob.Time_start + " , " + pesticidejob.Time_end + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class FertiliserHandler
    {
        public int addNewFertiliser(MySqlConnection conn, Fertiliser fertiliser)
        {
            string sql = "INSERT INTO pesticideJob (name, quantity_kg, remark) "
                        + " Values ('" + fertiliser.Name + "', " + fertiliser.Quantity_kg + ", '" + fertiliser.Remark + "' )";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class PesticideHandler
    {
        public int addNewPesticide(MySqlConnection conn, Pesticide pesticide)
        {
            string sql = "INSERT INTO pesticideJob (name, quantity_kg, remark) "
                        + " Values ('" + pesticide.Name + "', " + pesticide.Quantity_kg + ", '" + pesticide.Remark + "' )";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
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

                    Console.WriteLine("crop => "+cr);
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
    }
}
