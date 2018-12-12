using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class Farm
    {
        private int id;
        private string description;
        private int area;
        private int utilize_area;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Area { get => area; set => area = value; }
        public int Utilize_area { get => utilize_area; set => utilize_area = value; }
    }
}
