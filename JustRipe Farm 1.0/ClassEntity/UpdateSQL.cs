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
            string query = "UPDATE orders SET description = @description,product_id = @product_id,quantity_box = @quantity_box,weight = @weight,palletAllocation = @palletAllocation,customer_id = @customer_id, order_date = @order_date, collection = @collection, price = @price, status = @status, remark = @remark " +
                                   "WHERE id = " + order.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
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

        public int UpdateEmployee(Employee employee)
        {
            string query = "UPDATE" + " employee SET first_name =@first_name,last_name= @last_name,username= @username,password= @password,dob= @dob,mobile= @mobile,email= @email,admin= @admin,status= @status,remark= @remark " +
                                           "WHERE id = " + employee.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
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

        public int updateCustomer(Customer customer)
        {
            string query = "UPDATE" + " customer SET name = @name, email = @email,p hone= @ phone , remark = @remark " +
                                           "WHERE id = " + customer.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = customer.Name;
            sqlComm.Parameters.Add("@email", MySqlDbType.Text).Value = customer.Email;
            sqlComm.Parameters.Add("@phone", MySqlDbType.Text).Value = customer.Phone;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = customer.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateProduct(Product product)
        {
            string query = "UPDATE" + " product SET name=@name,type=@type,quantity_box=@quantity_box,weight=@weight,box_id=@box_id " +
                                          "WHERE id = " + product.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = product.Name;
            sqlComm.Parameters.Add("@type", MySqlDbType.Text).Value = product.Type;
            sqlComm.Parameters.Add("@quantity_box", MySqlDbType.UInt32).Value = product.Quantity_box;
            sqlComm.Parameters.Add("@weight", MySqlDbType.Decimal).Value = product.Weight;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = product.Box_id;
            return sqlComm.ExecuteNonQuery();
        }

        public int updateStore(Storeroom storeroom)
        {
            string query = "UPDATE" + " storeroom SET description=@description,storingQty=@storingQty,temperature=@temperature,availability=@availabitily " +
                                           "WHERE id = " + storeroom.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = storeroom.Description;
            sqlComm.Parameters.Add("@storingQty", MySqlDbType.UInt32).Value = storeroom.StoringQty;
            sqlComm.Parameters.Add("@temperature", MySqlDbType.UInt32).Value = storeroom.Temperature;
            sqlComm.Parameters.Add("@availability", MySqlDbType.UInt64).Value = storeroom.Availability;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateVehicle(Vehicle vehicle)
        {
            string query = "UPDATE" + " vehicle SET name=@name,serial_number=@serial_number,buy_date=@buy_date,last_service_date=@last_service,remark=@remark " +
                                           "WHERE id = " + vehicle.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = vehicle.Name;
            sqlComm.Parameters.Add("@serial_number", MySqlDbType.UInt32).Value = vehicle.Serial_number;
            sqlComm.Parameters.Add("@buy_date", MySqlDbType.Date).Value = vehicle.Buy_date;
            sqlComm.Parameters.Add("@last_service_date", MySqlDbType.Date).Value = vehicle.Last_service_date;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = vehicle.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateFarm(Farm farm)
        {
            string query = "UPDATE" + " farm SET description=@description, area=@area, utilize_area=@utilize_area " +
                                          " WHERE id = " + farm.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = farm.Description;
            sqlComm.Parameters.Add("@area", MySqlDbType.Int32).Value = farm.Area;
            sqlComm.Parameters.Add("@utilize_area", MySqlDbType.Int32).Value = farm.Utilize_area;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateBox(Box box)
        {
            string query = "UPDATE" + " box SET name=@name, width=@width, height=@height, length=@length, max_weight=@max_weight, quantity=@quantity, status=@status " +
                                          "WHERE id = " + box.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = box.Name;
            sqlComm.Parameters.Add("@width", MySqlDbType.Decimal).Value = box.Width;
            sqlComm.Parameters.Add("@height", MySqlDbType.Decimal).Value = box.Height;
            sqlComm.Parameters.Add("@length", MySqlDbType.Decimal).Value = box.Length;
            sqlComm.Parameters.Add("@max_weight", MySqlDbType.Decimal).Value = box.Max_weight;
            sqlComm.Parameters.Add("@quantity", MySqlDbType.UInt32).Value = box.Quantity;
            sqlComm.Parameters.Add("@status", MySqlDbType.Text).Value = box.Status;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateCrop(Crop crop)
        {
            string query = "UPDATE" + " crop SET name=@name, type=@type, quantity_plot=@quantity_plot, remark=@remark " +
                                          "WHERE id = " + crop.Id;

            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = crop.Name;
            sqlComm.Parameters.Add("@type", MySqlDbType.Text).Value = crop.Type;
            sqlComm.Parameters.Add("@quantity_plot", MySqlDbType.UInt32).Value = crop.Quantity_plot;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = crop.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateBoxStorage(BoxStorage boxstorage)
        {
            string query = "UPDATE" + " boxstorage SET storingJob_id=@storingJob_id, product_id=@product_id, box_id=@box_id, nettWeight=@nettWeight, " +
                                                    " storeroom_id=@storeroom_id, add_date=@add_date, best_before=@best_before, out_date=@out_date, order_id=@order_id " +
                                                    "WHERE id = " + boxstorage.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@storingJob_id", MySqlDbType.Text).Value = boxstorage.StoringJob_id;
            sqlComm.Parameters.Add("@product_id", MySqlDbType.UInt32).Value = boxstorage.Product_id;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = boxstorage.Box_id;
            sqlComm.Parameters.Add("@nettWeight", MySqlDbType.Decimal).Value = boxstorage.NettWeight;
            sqlComm.Parameters.Add("@storeroom_id", MySqlDbType.UInt32).Value = boxstorage.Storeroom_id;
            sqlComm.Parameters.Add("@add_date", MySqlDbType.Date).Value = boxstorage.Add_date;
            sqlComm.Parameters.Add("@best_before", MySqlDbType.Date).Value = boxstorage.Best_before;
            sqlComm.Parameters.Add("@out_date", MySqlDbType.Date).Value = boxstorage.Out_date;
            sqlComm.Parameters.Add("@order_id", MySqlDbType.UInt32).Value = boxstorage.Order_id;

            return sqlComm.ExecuteNonQuery();
        }

        public int UpdateSowingJob(SowingJob sowingjob)
        {
            string query = "UPDATE" + " sowingjob SET description=@description, crop_id=@crop_id, quantity_prop=@quantity_prop, farm_id=@farm_id," +
                                                    " used_area=@used_area, vehicle_id=@vehicle_id, employee_id=@employee_id, date_start=@date_start, date_end=@date_end, " +
                                                    "time_start=@time_start, time_end=@time_end " +
                                                    "WHERE id = " + sowingjob.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = sowingjob.Description;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = sowingjob.Crop_id;
            sqlComm.Parameters.Add("@quantity_prop", MySqlDbType.UInt32).Value = sowingjob.Quantity_prop;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = sowingjob.Farm_id;
            sqlComm.Parameters.Add("@used_area", MySqlDbType.Text).Value = sowingjob.Used_area;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = sowingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = sowingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = sowingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = sowingjob.Date_end;
            //sqlComm.Parameters.Add("@time_start", MySqlDbType.Time).Value = sowingjob.Time_start;
            //sqlComm.Parameters.Add("@time_end", MySqlDbType.Time).Value = sowingjob.Time_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateHarvestingJob(HarvestingJob harvestingjob)
        {
            string query = "UPDATE" + " harvestingjob SET description=@description, sowingJob_id=@sowingJob_id, farm_id=@Farm_id, crop_id=@crop_id," +
                                                    " vehicle_id=@vehicle_id, est_quantity=@est_quantity, harvested_quantity=@harvested_quantity, employee_id=@employee_id," +
                                                    " date_start=@date_start, date_end=@date_end " +
                                                    "WHERE id = " + harvestingjob.Id;

            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = harvestingjob.Description;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = harvestingjob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = harvestingjob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = harvestingjob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = harvestingjob.Vehicle_id;
            sqlComm.Parameters.Add("@est_quantity", MySqlDbType.UInt32).Value = harvestingjob.Est_quantity;
            sqlComm.Parameters.Add("@harvested_quantity", MySqlDbType.UInt32).Value = harvestingjob.Harvested_quantity;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = harvestingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Time).Value = harvestingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Time).Value = harvestingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateStoringJob(StoringJob storingjob)
        {
            string query = "UPDATE" + " storingjob SET description=@description, harvest_id=@harvest_id, crop_id=@crop_id," +
                                                    " box_id=@box_id, quantity=@quantity, vehicle_id=@vehicle_id, employee_id=@employee_id," +
                                                    " date_start=@date_start, date_end=@date_end " +
                                                     "WHERE id = " + storingjob.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = storingjob.Description;
            sqlComm.Parameters.Add("@harvest_id", MySqlDbType.UInt32).Value = storingjob.Harvest_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = storingjob.Crop_id;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = storingjob.Box_id;
            sqlComm.Parameters.Add("@quantity", MySqlDbType.UInt32).Value = storingjob.Quantity;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = storingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = storingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = storingjob.Date_start;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = storingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateFertilisingJob(FertilisingJob fertilisingjob)
        {
            string query = "UPDATE" + " fertilisingjob SET description=@description, fertiliser_id=@fertiliser_id, quantity_kg=@quantity_kg," +
                                                    " sowingJob_id=@sowing_id, farm_id=@farm_id, crop_id=@crop_id, vehicle_id=@vehicle_id " +
                                                    " employee_id=@employee_id, date_start=@date_start, date_end=@date_end " +
                                                    "WHERE id = " + fertilisingjob.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = fertilisingjob.Description;
            sqlComm.Parameters.Add("@fertiliser_id", MySqlDbType.UInt32).Value = fertilisingjob.Fertiliser_id;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = fertilisingjob.Quantity_kg;
            sqlComm.Parameters.Add("@sowing_id", MySqlDbType.UInt32).Value = fertilisingjob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = fertilisingjob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = fertilisingjob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = fertilisingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = fertilisingjob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Time).Value = fertilisingjob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Time).Value = fertilisingjob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int updatePesticideJob(PesticideJob pesticidejob)
        {
            string query = "UPDATE" + " pesticejob SET description=@description,  pesticide_id_id=@pesticide_id, quantity_kg=@quantity_kg," +
                                                    " sowingJob_id=@sowing_id, farm_id=@farm_id, crop_id=@crop_id, vehicle_id=@vehicle_id " +
                                                    " employee_id=@employee_id, date_start=@date_start, date_start=@date_end " +
                                                     "WHERE id = " + pesticidejob.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = pesticidejob.Description;
            sqlComm.Parameters.Add("@pesticide_id", MySqlDbType.UInt32).Value = pesticidejob.Pesticide_id;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.Decimal).Value = pesticidejob.Quantity_kg;
            sqlComm.Parameters.Add("@sowing_id", MySqlDbType.UInt32).Value = pesticidejob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = pesticidejob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = pesticidejob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = pesticidejob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = pesticidejob.Employee_id;
            sqlComm.Parameters.Add("@date_start", MySqlDbType.Date).Value = pesticidejob.Date_start;
            sqlComm.Parameters.Add("@date_end", MySqlDbType.Date).Value = pesticidejob.Date_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int updateFertiliser(Fertiliser fertiliser)
        {
            string query = "UPDATE" + " fertiliser SET name=@name, quantity_kg=@quantity_kg, remark=@remark " +
                                                    "WHERE id = " + fertiliser.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = fertiliser.Name;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = fertiliser.Quantity_kg;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = fertiliser.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int updatePesticide(Pesticide pesticide)
        {
            string query = "UPDATE" + " pesticide SET name=@name, quantity_kg=@quantity_kg, remark=@remark " +
                                                     "WHERE id = " + pesticide.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@name", MySqlDbType.Text).Value = pesticide.Name;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = pesticide.Quantity_kg;
            sqlComm.Parameters.Add("@remark", MySqlDbType.Text).Value = pesticide.Remark;

            return sqlComm.ExecuteNonQuery();
        }

        public int editEmployee(Employee employee)
        {
            string query = "UPDATE" + " employee SET first_name=@first_name, last_name=@last_name, dob=@dob, mobile=@mobile, email=@email " +
                                          "WHERE id = " + employee.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());
            sqlComm.Parameters.Add("@first_name", MySqlDbType.Text).Value = employee.First_name;
            sqlComm.Parameters.Add("@last_name", MySqlDbType.Text).Value = employee.Last_name;
            sqlComm.Parameters.Add("@dob", MySqlDbType.Date).Value = employee.Dob;
            sqlComm.Parameters.Add("@mobile", MySqlDbType.Text).Value = employee.Mobile;
            sqlComm.Parameters.Add("@email", MySqlDbType.Text).Value = employee.Email;

            return sqlComm.ExecuteNonQuery();
        }

        public int editPassword(Employee employee)
        {
            string query = "UPDATE" + " employee SET  password=@password " +
                                           "WHERE id = " + employee.Id;
            MySqlCommand sqlComm = new MySqlCommand(query, MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@password", MySqlDbType.Text).Value = employee.Password;

            return sqlComm.ExecuteNonQuery();
        }
    }
}
