using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm.ClassEntity
{
    public class Employee
    {
        private int id;
        private string first_name;
        private string last_name;
        private string username;
        private string password;
        private string dob;
        private string mobile;
        private string email;
        private bool admin;
        private string status;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Email { get => email; set => email = value; }
        public bool Admin { get => admin; set => admin = value; }
        public string Status { get => status; set => status = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
