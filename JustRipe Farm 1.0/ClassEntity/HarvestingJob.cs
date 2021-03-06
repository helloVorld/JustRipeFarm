﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class HarvestingJob
    {
        private int id;
        private string description;
        private int sowingJob_id;
        private int farm_id;
        private int crop_id;
        private int vehicle_id;
        private int est_quantity;
        private int harvested_quantity;
        private int employee_id;
        private DateTime date_start;
        private DateTime date_end;


        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int SowingJob_id { get => sowingJob_id; set => sowingJob_id = value; }
        public int Farm_id { get => farm_id; set => farm_id = value; }
        public int Crop_id { get => crop_id; set => crop_id = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public int Est_quantity { get => est_quantity; set => est_quantity = value; }
        public int Harvested_quantity { get => harvested_quantity; set => harvested_quantity = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public DateTime Date_start { get => date_start; set => date_start = value; }
        public DateTime Date_end { get => date_end; set => date_end = value; }
    }
}
