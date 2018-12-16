using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class StoringJob
    {
        private int id;
        private string description;
        private int harvest_id;
        private int crop_id;
        private int box_id;
        private int quantity;
        private int vehicle_id;
        private int employee_id;
        private DateTime date_start;
        private DateTime date_end;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Harvest_id { get => harvest_id; set => harvest_id = value; }
        public int Crop_id { get => crop_id; set => crop_id = value; }
        public int Box_id { get => box_id; set => box_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public DateTime Date_start { get => date_start; set => date_start = value; }
        public DateTime Date_end { get => date_start; set => date_end = value; }
    }
}
