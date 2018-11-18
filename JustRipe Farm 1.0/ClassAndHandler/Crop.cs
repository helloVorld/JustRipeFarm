using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class Crop
    {
        private string name;
        private int quantity;
        private string growthStage;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string GrowthStage
        {
            get
            {
                return growthStage;
            }

            set
            {
                growthStage = value;
            }
        }

        //public string Name { get => name; set => name = value; }
        //public int Quantity { get => quantity; set => quantity = value; }
        //public string GrowthStage { get => growthStage; set => growthStage = value; }
    }
}
