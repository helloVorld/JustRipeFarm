using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class SowingJob
    {
        private int id;
        private string description;
        private int crop_id;
        private int quantity_prop;
        private int farm_id;
        private string used_area;
        private int vehicle_id;
        private int employee_id;
        private DateTime date_start;
        private DateTime date_end;
        private DateTime time_start;
        private DateTime time_end;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Crop_id { get => crop_id; set => crop_id = value; }
        public int Quantity_prop { get => quantity_prop; set => quantity_prop = value; }
        public int Farm_id { get => farm_id; set => farm_id = value; }
        public string Used_area { get => used_area; set => used_area = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public DateTime Date_start { get => date_start; set => date_start = value; }
        public DateTime Date_end { get => date_end; set => date_end = value; }
        public DateTime Time_start { get => time_start; set => time_start = value; }
        public DateTime Time_end { get => time_end; set => time_end = value; }
    }
}
