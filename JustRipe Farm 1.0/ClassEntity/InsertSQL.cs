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
                        + order.Order_date.ToString("yyyy-MM-dd") + " ," + order.Collection_date.ToString("yyyy-MM-dd") + " , " 
                        + order.Price + ", '" + order.Status + "' , '" + order.Remark + "' )";

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
                        + employee.Password + "' , " + employee.Dob + " , '" + employee.Mobile + "' , " + employee.Admin + " , '"
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
                        + " Values ('" + vehicle.Name + "', " + vehicle.Serial_number + ", " 
                        + vehicle.Buy_date.ToString("yyyy-MM-dd") + " , "
                        + vehicle.Last_service_date.ToString("yyyy-MM-dd") + " , '" + vehicle.Remark + "')";

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
                        + boxstorage.NettWeight + " , " + boxstorage.Storeroom_id + " , " 
                        + boxstorage.Add_date.ToString("yyyy-MM-dd") + " , " + boxstorage.Best_before.ToString("yyyy-MM-dd") + " , " 
                        + boxstorage.Out_date.ToString("yyyy-MM-dd") + " , " + boxstorage.Order_id + " )";

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
                        + sowingjob.Employee_id + " , " + sowingjob.Date.ToString("yyyy-MM-dd") + " , " 
                        + sowingjob.Time_start.ToString("yyyy-MM-dd") + "," + sowingjob.Time_end.ToString("yyyy-MM-dd") + ")";

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
                        + harvestingjob.Harvested_quantity + " , " + harvestingjob.Employee_id + " , " 
                        + harvestingjob.Date.ToString("yyyy-MM-dd") + ", "
                        + harvestingjob.Time_start.ToString("yyyy-MM-dd") + " , " 
                        + harvestingjob.Time_end.ToString("yyyy-MM-dd") + ")";

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
                        + storingjob.Employee_id + " , " + storingjob.Date.ToString("yyyy-MM-dd") + ", " 
                        + storingjob.Time_start.ToString("yyyy-MM-dd") + " ,"
                        + storingjob.Time_end.ToString("yyyy-MM-dd") + ")";

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
                        + fertilisingjob.Vehicle_id + " , " + fertilisingjob.Employee_id + " , " 
                        + fertilisingjob.Date.ToString("yyyy-MM-dd") + " , "
                        + fertilisingjob.Time_start.ToString("yyyy-MM-dd") + " , " 
                        + fertilisingjob.Time_end.ToString("yyyy-MM-dd") + ")";

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
                        + pesticidejob.Vehicle_id + " , " + pesticidejob.Employee_id + " , " 
                        + pesticidejob.Date.ToString("yyyy-MM-dd") + " , "
                        + pesticidejob.Time_start.ToString("yyyy-MM-dd") + " , " 
                        + pesticidejob.Time_end.ToString("yyyy-MM-dd") + ")";

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
}
