using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Box
    {
        private int id;
        private string name;
        private double width;
        private double height;
        private double length;
        private double max_weight;
        private int quantity;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public double Length { get => length; set => length = value; }
        public double Max_weight { get => max_weight; set => max_weight = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Status { get => status; set => status = value; }
    }
}
