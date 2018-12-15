using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Vehicle
    {
        private int id;
        private string name;
        private string serial_number;
        private DateTime buy_date;
        private DateTime last_service_date;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Serial_number { get => serial_number; set => serial_number = value; }
        public DateTime Buy_date { get => buy_date; set => buy_date = value; }
        public DateTime Last_service_date { get => last_service_date; set => last_service_date = value; }
        public string Remark { get => remark; set => remark = value; }

    }
}
