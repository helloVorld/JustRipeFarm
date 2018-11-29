using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Storeroom
    {
        private int id;
        private string description;
        private int storingQty;
        private int temperature;
        private int availability;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int StoringQty { get => storingQty; set => storingQty = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public int Availability { get => availability; set => availability = value; }
    }
}
