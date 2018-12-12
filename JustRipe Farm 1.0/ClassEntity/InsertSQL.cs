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
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + "swoingjob(description, crop_id, quantity_prop, farm_id, used_area, vehicle_id, employee_id, date, time_start, time_end)" +
                                            "VALUES" + "(@description, @crop_id, @quantity_prop, @farm_id, @used_area, @vehicle_id, @employee_id, @date, @time_start, @time_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = sowingjob.Description;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = sowingjob.Crop_id;
            sqlComm.Parameters.Add("@quantity_prop", MySqlDbType.UInt32).Value = sowingjob.Quantity_prop;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = sowingjob.Farm_id;
            sqlComm.Parameters.Add("@used_area", MySqlDbType.Text).Value = sowingjob.Used_area;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = sowingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = sowingjob.Employee_id;
            sqlComm.Parameters.Add("@date", MySqlDbType.Date).Value = sowingjob.Date;
            sqlComm.Parameters.Add("@time_start", MySqlDbType.Time).Value = sowingjob.Time_start;
            sqlComm.Parameters.Add("@time_end", MySqlDbType.Time).Value = sowingjob.Time_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewHarvestingJob(HarvestingJob harvestingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + "harvestingjob(description, sowingJob_id, farm_id, crop_id, vehicle_id, est_quantity, harvested_quantity, employee_id, date, time_start, time_end)" +
                                            "VALUES" + "(@description, @sowingJob_id, @farm_id, @crop_id, @vehicle_id, @est_quantity, @harvested_quantity, @employee_id, @date, @time_start, @time_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = harvestingjob.Description;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = harvestingjob.Crop_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = harvestingjob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = harvestingjob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = harvestingjob.Vehicle_id;
            sqlComm.Parameters.Add("@est_quantity", MySqlDbType.Text).Value = harvestingjob.Est_quantity;
            sqlComm.Parameters.Add("@harvested_quantity", MySqlDbType.Text).Value = harvestingjob.Harvested_quantity;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = harvestingjob.Employee_id;
            sqlComm.Parameters.Add("@date", MySqlDbType.Date).Value = harvestingjob.Date;
            sqlComm.Parameters.Add("@time_start", MySqlDbType.Time).Value = harvestingjob.Time_start;
            sqlComm.Parameters.Add("@time_end", MySqlDbType.Time).Value = harvestingjob.Time_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewStoringJob(StoringJob storingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " stroingjob(description, harvest_id, crop_id, box_id, quantity, vehicle_id, employee_id, date, time_start, time_end)" +
                                        "VALUES" + "(@description, @harvest_id, @crop_id, @box_id, @quantity, @vehicle_id, @employee_id, @date, @time_start, @time_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = storingjob.Description;
            sqlComm.Parameters.Add("@harvest_id", MySqlDbType.UInt32).Value = storingjob.Harvest_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = storingjob.Crop_id;
            sqlComm.Parameters.Add("@box_id", MySqlDbType.UInt32).Value = storingjob.Box_id;
            sqlComm.Parameters.Add("@quantity", MySqlDbType.UInt32).Value = storingjob.Quantity;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = storingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = storingjob.Employee_id;
            sqlComm.Parameters.Add("@date", MySqlDbType.Date).Value = storingjob.Date;
            sqlComm.Parameters.Add("@time_start", MySqlDbType.Time).Value = storingjob.Time_start;
            sqlComm.Parameters.Add("@time_end", MySqlDbType.Time).Value = storingjob.Time_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewFertilisingJob(FertilisingJob fertilisingjob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " fertilisingjob(description, fertiliser_id, quantity_kg, sowingJob_id, farm_id, crop_id, vehicle_id, employee_id, date, time_start, time_end)" +
                                        "VALUES" + "(@description, @fertiliser_id, @quantity_kg, @sowingJob_id, @farm_id, @rop_id, @vehicle_id, @employee_id, @date, @time_start, @time_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = fertilisingjob.Description;
            sqlComm.Parameters.Add("@fertiliser_id", MySqlDbType.UInt32).Value = fertilisingjob.Fertiliser_id;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.UInt32).Value = fertilisingjob.Quantity_kg;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = fertilisingjob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = fertilisingjob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = fertilisingjob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = fertilisingjob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = fertilisingjob.Employee_id;
            sqlComm.Parameters.Add("@date", MySqlDbType.Date).Value = fertilisingjob.Date;
            sqlComm.Parameters.Add("@time_start", MySqlDbType.Time).Value = fertilisingjob.Time_start;
            sqlComm.Parameters.Add("@time_end", MySqlDbType.Time).Value = fertilisingjob.Time_end;

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewPesticideJob(PesticideJob pesticidejob)
        {
            MySqlCommand sqlComm = new MySqlCommand("INSERT INTO" + " pesticidejob(description, pesticide_id, quantity_kg, sowingJob_id, farm_id, crop_id, vehicle_id, employee_id, date, time_start, time_end)" +
                                       "VALUES" + "(@description, @pesticide_id, @quantity_kg, @sowingJob_id, @farm_id, @rop_id, @vehicle_id, @employee_id, @date, @time_start, @time_end)", MysqlDbc.Instance.getConn());

            sqlComm.Parameters.Add("@description", MySqlDbType.Text).Value = pesticidejob.Description;
            sqlComm.Parameters.Add("@pesticide_id", MySqlDbType.UInt32).Value = pesticidejob.Pesticide_id;
            sqlComm.Parameters.Add("@quantity_kg", MySqlDbType.Decimal).Value = pesticidejob.Quantity_kg;
            sqlComm.Parameters.Add("@sowingJob_id", MySqlDbType.UInt32).Value = pesticidejob.SowingJob_id;
            sqlComm.Parameters.Add("@farm_id", MySqlDbType.UInt32).Value = pesticidejob.Farm_id;
            sqlComm.Parameters.Add("@crop_id", MySqlDbType.UInt32).Value = pesticidejob.Crop_id;
            sqlComm.Parameters.Add("@vehicle_id", MySqlDbType.UInt32).Value = pesticidejob.Vehicle_id;
            sqlComm.Parameters.Add("@employee_id", MySqlDbType.UInt32).Value = pesticidejob.Employee_id;
            sqlComm.Parameters.Add("@date", MySqlDbType.Date).Value = pesticidejob.Date;
            sqlComm.Parameters.Add("@time_start", MySqlDbType.Time).Value = pesticidejob.Time_start;
            sqlComm.Parameters.Add("@time_end", MySqlDbType.Time).Value = pesticidejob.Time_end;

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

    

    //public class BoxHandler
    //{
    //    public int addNewBox(MySqlConnection conn, Box box)
    //    {
    //        string sql = "INSERT INTO Box (name, width, height, length, max_weight, quantity, status) "
    //                    + " Values ('" + box.Name + "', " + box.Width + ", "
    //                    +  box.Height + ", " + box.Length + ", " + box.Max_weight + ", " 
    //                    +  box.Quantity + ", )";

    //        MySqlCommand sqlComm = new MySqlCommand(sql, conn);
    //        return sqlComm.ExecuteNonQuery();
    //    }
    //}

    //}

    public class OrderHandler
    {
        //public int addNewOrder(MySqlConnection conn, Order order)
        //{
        //    string sql = "INSERT INTO orders (description, product_id, quantity_box, weight, palletAllocation, " +
        //        "                               customer_id, order_date, collection_date, price, status, remark) "
        //                + " Values ('" + order.Description + "', " + order.Product_id + ", " + order.Quantity_box + ", " 
        //                + order.Weight + " , '" + order.PalletAllocation + "', " + order.Customer_id + " , " 
        //                + order.Order_date.ToString("yyyy-MM-dd") + " ," + order.Collection_date.ToString("yyyy-MM-dd") + " , " 
        //                + order.Price + ", '" + order.Status + "' , '" + order.Remark + "' )";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }
    //public class ProductHandler
    //{
    //    public int addNewProduct(MySqlConnection conn, Product product)
    //    {
    //        string sql = "INSERT INTO product (name, type, quantity_box, weight, box_id) "
    //                    + " Values ('" + product.Name + "', '" + product.Type + "', " + product.Quantity_box + " , "
    //                    + product.Weight + " , " +product.Box_id + "`)";

    //        MySqlCommand sqlComm = new MySqlCommand(sql, conn);
    //        return sqlComm.ExecuteNonQuery();
    //    }
    //}

    //public class FarmHandler
    //{
    //    public int addNewFarm(MySqlConnection conn, Farm farm)
    //    {
    //        string sql = "INSERT INTO farm (description, area, utilize_area) "
    //                    + " Values ('" + farm.Description + "', '" + farm.Area + "', '" + farm.Utilize_area + "')";

    //        MySqlCommand sqlComm = new MySqlCommand(sql, conn);
    //        return sqlComm.ExecuteNonQuery();
    //    }
    //}

    public class EmployeeHandler
    {
        //public int addNewEmployee(MySqlConnection conn, Employee employee)
        //{
        //    string sql = "INSERT INTO employee (first_name, last_name, username, password, dob, " +
        //                                         "mobile, email, admin, status, remark) "
        //                + " Values ('" + employee.First_name + "', '" + employee.Last_name + "', '" + employee.Username + "' , '"
        //                + employee.Password + "' , " + employee.Dob + " , '" + employee.Mobile + "' , " + employee.Admin + " , '"
        //                + employee.Status + "' , '" + employee.Remark + "')";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);


        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class CustomerHandler
    {
        //public int addNewCustomer( Customer customer)
        //{
        //    string sql = "INSERT INTO customer (name, email, phone, remark) "
        //                + " Values ('" + customer.Name + "', '" + customer.Email + "', '" + customer.Phone + "' , '"
        //                + customer.Remark + "')";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, MysqlDbc.Instance.getConn());
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class StoreroomHandler
    {
        //public int addNewStore(MySqlConnection conn, Storeroom storeroom)
        //{
        //    string sql = "INSERT INTO storeroom (description, storingQty, temperature, availability) "
        //                + " Values ('" + storeroom.Description + "', " + storeroom.StoringQty + ", " + storeroom.Temperature + " , '"
        //                + storeroom.Availability + "')";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    //public class CropHandler
    //{
    //    public int addNewCrop(MySqlConnection conn, Crop crop)
    //    {
    //        string sql = "INSERT INTO crop (name, type, quantity_plot, remark) "
    //                    + " Values ('" + crop.Name + "', '" + crop.Type + "', " + crop.Quantity_plot + " , '"
    //                    + crop.Remark + "')";

    //        MySqlCommand sqlComm = new MySqlCommand(sql, conn);
    //        return sqlComm.ExecuteNonQuery();
    //    }
    //}

    public class VehicleHandler
    {
        //public int addNewVehicle(MySqlConnection conn, Vehicle vehicle)
        //{
        //    string sql = "INSERT INTO vehicle (name, serial_number, buy_date, last_service_date, remark) "
        //                + " Values ('" + vehicle.Name + "', " + vehicle.Serial_number + ", " 
        //                + vehicle.Buy_date.ToString("yyyy-MM-dd") + " , "
        //                + vehicle.Last_service_date.ToString("yyyy-MM-dd") + " , '" + vehicle.Remark + "')";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    //public class BoxStorageHandler
    //{
    //    public int addNewBoxStorage(MySqlConnection conn, BoxStorage boxstorage)
    //    {
    //        string sql = "INSERT INTO boxStorage (storingJob_id, product_id, box_id, nettWeight, storeroom_id" +
    //                     " add_date, best_before, out_date, order_id) "
    //                    + " Values (" + boxstorage.StoringJob_id + ", " + boxstorage.Product_id + ", " + boxstorage.Box_id + " , "
    //                    + boxstorage.NettWeight + " , " + boxstorage.Storeroom_id + " , " 
    //                    + boxstorage.Add_date.ToString("yyyy-MM-dd") + " , " + boxstorage.Best_before.ToString("yyyy-MM-dd") + " , " 
    //                    + boxstorage.Out_date.ToString("yyyy-MM-dd") + " , " + boxstorage.Order_id + " )";

    //        MySqlCommand sqlComm = new MySqlCommand(sql, conn);
    //        return sqlComm.ExecuteNonQuery();
    //    }
    //}

    public class SowingJobHandler
    {
        //public int addNewSowingJob(MySqlConnection conn, SowingJob sowingjob)
        //{
        //    string sql = "INSERT INTO sowingJob (description, crop_id, quantity_prop, farm_id, used_area, " +
        //                 " vehicle_id, employee_id, date, time_start, time_end) "
        //                + " Values ('" + sowingjob.Description + "', " + sowingjob.Crop_id + ", " + sowingjob.Quantity_prop + " , "
        //                + sowingjob.Farm_id + " , '" + sowingjob.Used_area + "' , " + sowingjob.Vehicle_id + " , "
        //                + sowingjob.Employee_id + " , " + sowingjob.Date.ToString("yyyy-MM-dd") + " , " 
        //                + sowingjob.Time_start.ToString("yyyy-MM-dd") + "," + sowingjob.Time_end.ToString("yyyy-MM-dd") + ")";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class HarvestingJobHandler
    {
        //public int addNewHarvestingJob(MySqlConnection conn,HarvestingJob harvestingjob)
        //{
        //    string sql = "INSERT INTO harvestingJob (description, sowingJob_id, farm_id, crop_id, vehicle_id " +
        //                 "est_quantity, harvested_quantity, employee_id, date, time_start, time_end) "
        //                + " Values ('" + harvestingjob.Description + "', " + harvestingjob.SowingJob_id  + ", " + harvestingjob.Farm_id + " , "
        //                + harvestingjob.Crop_id + " , " + harvestingjob.Vehicle_id + " , " + harvestingjob.Est_quantity + " , "
        //                + harvestingjob.Harvested_quantity + " , " + harvestingjob.Employee_id + " , " 
        //                + harvestingjob.Date.ToString("yyyy-MM-dd") + ", "
        //                + harvestingjob.Time_start.ToString("yyyy-MM-dd") + " , " 
        //                + harvestingjob.Time_end.ToString("yyyy-MM-dd") + ")";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class StoringJobHandler
    {
        //public int addNewStoringJob(MySqlConnection conn, StoringJob storingjob)
        //{
        //    string sql = "INSERT INTO storingJob (description, harvest_id, crop_id, box_id, quantity " +
        //                 "vehicle_id, employee_id, date, time_start, time_end) "
        //                + " Values ('" + storingjob.Description + "', " + storingjob.Harvest_id + ", " + storingjob.Crop_id + " , "
        //                + storingjob.Box_id + " , " + storingjob.Quantity + " , " + storingjob.Vehicle_id + " , "
        //                + storingjob.Employee_id + " , " + storingjob.Date.ToString("yyyy-MM-dd") + ", " 
        //                + storingjob.Time_start.ToString("yyyy-MM-dd") + " ,"
        //                + storingjob.Time_end.ToString("yyyy-MM-dd") + ")";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class FertilisingJobHandler
    {
        //public int addNewFertilisingJob(MySqlConnection conn, FertilisingJob fertilisingjob)
        //{
        //    string sql = "INSERT INTO fertilisingJob (description, fertiliser_id, quantity_kg, sowingJob_id, farm_id" +
        //                 "crop_id, vehicle_id, employee_id, date, time_start, time_end) "
        //                + " Values ('" + fertilisingjob.Description + "', " + fertilisingjob.Fertiliser_id + ", " + fertilisingjob.Quantity_kg + " , "
        //                + fertilisingjob.SowingJob_id + " , " + fertilisingjob.Farm_id + " , " + fertilisingjob.Crop_id + " , "
        //                + fertilisingjob.Vehicle_id + " , " + fertilisingjob.Employee_id + " , " 
        //                + fertilisingjob.Date.ToString("yyyy-MM-dd") + " , "
        //                + fertilisingjob.Time_start.ToString("yyyy-MM-dd") + " , " 
        //                + fertilisingjob.Time_end.ToString("yyyy-MM-dd") + ")";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class PesticideJobHandler
    {
        //public int addNewPesticideJob(MySqlConnection conn, PesticideJob pesticidejob)
        //{
        //    string sql = "INSERT INTO pesticideJob (description, pesticide_id, quantity_kg, sowingJob_id, farm_id" +
        //                 "crop_id, vehicle_id, employee_id, date, time_start, time_end) "
        //                + " Values ('" + pesticidejob.Description + "', " + pesticidejob.Pesticide_id + ", " + pesticidejob.Quantity_kg + " , "
        //                + pesticidejob.SowingJob_id + " , " + pesticidejob.Farm_id + " , " + pesticidejob.Crop_id + " , "
        //                + pesticidejob.Vehicle_id + " , " + pesticidejob.Employee_id + " , " 
        //                + pesticidejob.Date.ToString("yyyy-MM-dd") + " , "
        //                + pesticidejob.Time_start.ToString("yyyy-MM-dd") + " , " 
        //                + pesticidejob.Time_end.ToString("yyyy-MM-dd") + ")";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class FertiliserHandler
    {
        //public int addNewFertiliser(MySqlConnection conn, Fertiliser fertiliser)
        //{
        //    string sql = "INSERT INTO pesticideJob (name, quantity_kg, remark) "
        //                + " Values ('" + fertiliser.Name + "', " + fertiliser.Quantity_kg + ", '" + fertiliser.Remark + "' )";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
    }

    public class PesticideHandler
    {
        //public int addNewPesticide(MySqlConnection conn, Pesticide pesticide)
        //{
        //    string sql = "INSERT INTO pesticideJob (name, quantity_kg, remark) "
        //                + " Values ('" + pesticide.Name + "', " + pesticide.Quantity_kg + ", '" + pesticide.Remark + "' )";

        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    return sqlComm.ExecuteNonQuery();
        //}
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
