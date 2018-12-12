using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Customer
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Remark { get => remark; set => remark = value; }

        public Customer()
        {

        }

        public Customer(string name, string email, string phone, string remark)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Remark = remark;
        }
    }


}
