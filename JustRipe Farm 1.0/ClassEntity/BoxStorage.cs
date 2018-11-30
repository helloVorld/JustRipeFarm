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
        private decimal nettWeight;
        private int storeroom_id;
        private DateTime add_date;
        private DateTime best_before;
        private DateTime out_date;
        private int order_id;

        public int Id { get => id; set => id = value; }
        public int StoringJob_id { get => storigJob_id; set => storigJob_id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int Box_id { get => box_id; set => box_id = value; }
        public decimal NettWeight { get => nettWeight; set => nettWeight = value; }
        public int Storeroom_id { get => storeroom_id; set => storeroom_id = value; }
        public DateTime Add_date { get => add_date; set => add_date = value; }
        public DateTime Best_before { get => best_before; set => best_before = value; }
        public DateTime Out_date { get => out_date; set => out_date = value; }
        public int Order_id { get => order_id; set => order_id = value; }
    }
}
