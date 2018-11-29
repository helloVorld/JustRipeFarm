using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm.ClassEntity
{
    class AllTheHandle
    {
    }

    public class OrderHandler
    {
        public int addNewOrder(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class ProductHandler
    {
        public int addNewProduct(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    

    public class FarmHandler
    {
        public int addNewFarm(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class EmployeeHandler
    {
        public int addNewEmployee(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class CustomerHandler
    {
        public int addNewCustomer(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class StoreHandler
    {
        public int addNewStore(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }

    public class InventoryHandler
    {
        public int addNewInventory(MySqlConnection conn, Crop crop)
        {
            string sql = "INSERT INTO crops (name, quantity, growth_stage) "
                        + " Values ('" + crop.Name + "', " + crop.Quantity + ", '" + crop.GrowthStage + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
