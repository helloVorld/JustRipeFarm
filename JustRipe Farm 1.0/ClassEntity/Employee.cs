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
        private DateTime dob;
        private string mobile;
        private string email;
        private Boolean admin;
        private string status;
        private string remark;

        public int Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Email { get => email; set => email = value; }
        public Boolean Admin { get => admin; set => admin = value; }
        public string Status { get => status; set => status = value; }
        public string Remark { get => remark; set => remark = value; }

        public Employee()
        {

        }

        public Employee(string first_name, string last_name, DateTime dob, string mobile, string email, string username, string password)
        {
            this.First_name = first_name;
            this.Last_name = email;
            this.Dob = dob;
            this.Mobile = mobile;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }
    }
}
