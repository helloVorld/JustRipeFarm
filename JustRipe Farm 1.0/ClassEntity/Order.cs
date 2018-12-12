using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class Order
    {
        private int id;
        private string description;
        private int product_id;
        private int quantity_box;
        private double weight;
        private int palletAllocation;
        private int customer_id;
        private DateTime order_date;
        private DateTime collection_date;
        private double price;
        private string status;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int Quantity_box { get => quantity_box; set => quantity_box = value; }
        public double Weight { get => weight; set => weight = value; }
        public int PalletAllocation { get => palletAllocation; set => palletAllocation = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }
        public DateTime Order_date { get => order_date; set => order_date = value; }
        public DateTime Collection_date { get => collection_date; set => collection_date = value; }
        public double Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
