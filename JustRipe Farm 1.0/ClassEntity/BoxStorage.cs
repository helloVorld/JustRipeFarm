using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class BoxStorage
    {
        private int id;
        private int storingJob_id;
        private int product_id;
        private int box_id;
        private double nettWeight;
        private int storeroom_id;
        private DateTime add_date;
        private DateTime best_before;
        private DateTime out_date;
        private int order_id;

        public int Id { get => id; set => id = value; }
        public int StoringJob_id { get => storingJob_id; set => storingJob_id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int Box_id { get => box_id; set => box_id = value; }
        public double NettWeight { get => nettWeight; set => nettWeight = value; }
        public int Storeroom_id { get => storeroom_id; set => storeroom_id = value; }
        public DateTime Add_date { get => add_date; set => add_date = value; }
        public DateTime Best_before { get => best_before; set => best_before = value; }
        public DateTime Out_date { get => out_date; set => out_date = value; }
        public int Order_id { get => order_id; set => order_id = value; }


        public BoxStorage()
        {

        }

        public BoxStorage(int storingJob_id, int product_id, int box_id, double nettWeight, int storeroom_id, DateTime add_date, DateTime best_before, DateTime out_date, int order_id)
        {
            this.StoringJob_id = storingJob_id;
            this.Product_id = product_id;
            this.Box_id = box_id;
            this.NettWeight = nettWeight;
            this.Storeroom_id = storeroom_id;
            this.Add_date = add_date;
            this.Best_before = best_before;
            this.Out_date = out_date;
            this.Order_id = order_id;
        }
    }
}
