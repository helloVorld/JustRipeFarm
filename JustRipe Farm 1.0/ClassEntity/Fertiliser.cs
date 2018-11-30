using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class Fertiliser
    {
        private int id;
        private string name;
        private int quantity_kg;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity_kg { get => quantity_kg; set => quantity_kg = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
