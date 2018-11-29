using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Farm
    {
        private int id;
        private string description;
        private string area;
        private string utilize;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Area { get => area; set => area = value; }
        public string Utilize { get => utilize; set => utilize = value; }
    }
}
