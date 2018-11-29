using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Product
    {
        private int id;
        private string name;
        private string type;
        private int quantity_box;
        private decimal weight;
        private int box_id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Quantity_box { get => quantity_box; set => quantity_box = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public int Box_id { get => box_id; set => box_id = value; }
    }
}
