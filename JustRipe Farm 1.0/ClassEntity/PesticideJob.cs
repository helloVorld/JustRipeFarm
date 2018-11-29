﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class PesticideJob
    {
        private int id;
        private string description;
        private int pesticide_id;
        private int quantity_kg;
        private int sowingJob_id;
        private int farm_id;
        private int crop_id;
        private int vehicle_id;
        private int employee_id;
        private DateTime date;
        private DateTime time_start;
        private DateTime time_end;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Pesticide_id { get => pesticide_id; set => pesticide_id = value; }
        public int Quantity_kg { get => quantity_kg; set => quantity_kg = value; }
        public int SowingJob_id { get => sowingJob_id; set => sowingJob_id = value; }
        public int Farm_id { get => farm_id; set => farm_id = value; }
        public int Crop_id { get => crop_id; set => crop_id = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Time_start { get => time_start; set => time_start = value; }
        public DateTime Time_end { get => time_end; set => time_end = value; }
    }
}