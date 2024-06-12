using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8
{
    class User
    {
       

        public string Login { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public DateTime LastLogin { get; set; }
        public User() { }
        public User(string login, string name, string surName, int age, DateTime lastLogin)
        {
            Login = login;
            Name = name;
            SurName = surName;
            Age = age;
            LastLogin = lastLogin;
        }
        public void OutPut()
        {
            Console.WriteLine($"{Login}|{Name}|{SurName}|{Age}|{LastLogin}");
        }

    }
}
