﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class Crop
    {
        private int id;
        private string name;
        private string type;
        private int quantity_plot;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Quantity_plot { get => quantity_plot; set => quantity_plot = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
