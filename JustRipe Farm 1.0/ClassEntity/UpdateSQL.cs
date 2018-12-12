using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm.ClassEntity
{
    public class UpdateSQL
    {
        public int UpdateOrder(Order order)
        {
            string query = "UPDATE orders SET description = @description ,product_id = @product_id,quantity_box = @quantity_box,weight = @weight,palletAllocation = @palletAllocation,customer_id = @customer_id, order_date = @order_date, collection = @collection, price = @price, status = @status, remark = @remark " +
                                   "WHERE id = " + order.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = order.Description;
            sqlComm.Parameters.Add("@product_id", MySqlDbType.Text).Value = order.Product_id;
            sqlComm.Parameters.Add("@quantity_box", MySqlDbType.Text).Value = order.Quantity_box;
            sqlComm.Parameters.Add("@weight", MySqlDbType.Text).Value = order.Weight;
            sqlComm.Parameters.Add("@palletAllocation", MySqlDbType.Text).Value = order.PalletAllocation;
            sqlComm.Parameters.Add("@customer_id", MySqlDbType.Text).Value = order.Customer_id;
            sqlComm.Parameters.Add("@order_date", MySqlDbType.Date).Value = order.Order_date;
            sqlComm.Parameters.Add("@collection", MySqlDbType.Date).Value = order.Collection_date;
            sqlComm.Parameters.Add("@price", MySqlDbType.Decimal).Value = order.Price;
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = order.Status;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = order.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int UpdateEmployee(Employee employee)
        {
            MySqlCommand sqlComm = new MySqlCommand("UPDATE" + " employee SET first_name=@first_name,last_name=@last_name,username=@username,password=@password,dob=@dob,mobile=@mobile,email=@email,admin=@admin,status=@status,remark=@remark " +
                                           "WHERE id = 1" /*+ employee.Id*/, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@first_name", MySqlDbType.Text).Value = employee.First_name;
            sqlComm.Parameters.Add("@last_name", MySqlDbType.Text).Value = employee.Last_name;
            sqlComm.Parameters.Add("@username", MySqlDbType.Text).Value = employee.Username;
            sqlComm.Parameters.Add("@password", MySqlDbType.Text).Value = employee.Password;
            sqlComm.Parameters.Add("@dob", MySqlDbType.Text).Value = employee.Dob;
            sqlComm.Parameters.Add("@mobile", MySqlDbType.Text).Value = employee.Mobile;
            sqlComm.Parameters.Add("@email", MySqlDbType.Text).Value = employee.Email;
            sqlComm.Parameters.Add("@admin", MySqlDbType.Text).Value = employee.Admin;
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = employee.Status;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = employee.Remark;
            return sqlComm.ExecuteNonQuery();
        }
    }

    /*public class UpdateOrder
    {
        public class BoxHandler
        {
            public int addNewBox(MySqlConnection conn, Box box)
            {
                string sql = " UPDATE Box (name, width, height, length, max_weight, quantity, status) "
                            + " Values ('" + box.Name + "', " + box.Width + ", "
                            + box.Height + ", " + box.Length + ", " + box.Max_weight + ", "
                            + box.Quantity + ", )";

                MySqlCommand sqlComm = new MySqlCommand(sql, conn);
                return sqlComm.ExecuteNonQuery();
            }
        }

        public class OrderHandler
        {
            public int addNewOrder(MySqlConnection conn, Order order)
            {
                string sql = "UPDATE orders (description, product_id, quantity_box, weight, palletAllocation, " +
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
                string sql = "UPDATE product (name, type, quantity_box, weight, box_id) "
                            + " Values ('" + product.Name + "', '" + product.Type + "', " + product.Quantity_box + " , "
                            + product.Weight + " , " + product.Box_id + "`)";

                MySqlCommand sqlComm = new MySqlCommand(sql, conn);
                return sqlComm.ExecuteNonQuery();
            }
        }

        public class FarmHandler
        {
            public int addNewFarm(MySqlConnection conn, Farm farm)
            {
                string sql = "UPDATE farm (description, area, utilize_area) "
                            + " Values ('" + farm.Description + "', '" + farm.Area + "', '" + farm.Utilize_area + "')";

                MySqlCommand sqlComm = new MySqlCommand(sql, conn);
                return sqlComm.ExecuteNonQuery();
            }
        }

        public class EmployeeHandler
        {
            public int addNewEmployee(MySqlConnection conn, Employee employee)
            {
                string sql = "UPDATE employee (first_name, last_name, username, password, dob, " +
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
                string sql = "UPDATE customer (name, email, phone, remark) "
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
                string sql = "UPDATE storeroom (description, storingQty, temperature, availability) "
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
                string sql = "UPDATE crop (name, type, quantity_plot, remark) "
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
                string sql = "UPDATE vehicle (name, serial_number, buy_date, last_service_date, remark) "
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
                string sql = "UPDATE boxStorage (storingJob_id, product_id, box_id, nettWeight, storeroom_id" +
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
                string sql = "UPDATE sowingJob (description, crop_id, quantity_prop, farm_id, used_area, " +
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
            public int addNewHarvestingJob(MySqlConnection conn, HarvestingJob harvestingjob)
            {
                string sql = "UPDATE harvestingJob (description, sowingJob_id, farm_id, crop_id, vehicle_id " +
                             "est_quantity, harvested_quantity, employee_id, date, time_start, time_end) "
                            + " Values ('" + harvestingjob.Description + "', " + harvestingjob.SowingJob_id + ", " + harvestingjob.Farm_id + " , "
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
                string sql = "UPDATE storingJob (description, harvest_id, crop_id, box_id, quantity " +
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
                string sql = "UPDATE fertilisingJob (description, fertiliser_id, quantity_kg, sowingJob_id, farm_id" +
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
                string sql = "UPDATE pesticideJob (description, pesticide_id, quantity_kg, sowingJob_id, farm_id" +
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
                string sql = "UPDATE pesticideJob (name, quantity_kg, remark) "
                            + " Values ('" + fertiliser.Name + "', " + fertiliser.Quantity_kg + ", '" + fertiliser.Remark + "' )";

                MySqlCommand sqlComm = new MySqlCommand(sql, conn);
                return sqlComm.ExecuteNonQuery();
            }
        }

        public class PesticideHandler
        {
            public int addNewPesticide(MySqlConnection conn, Pesticide pesticide)
            {
                string sql = "UPDATE pesticideJob (name, quantity_kg, remark) "
                            + " Values ('" + pesticide.Name + "', " + pesticide.Quantity_kg + ", '" + pesticide.Remark + "' )";

                MySqlCommand sqlComm = new MySqlCommand(sql, conn);
                return sqlComm.ExecuteNonQuery();
            }
        }
    }*/
}
