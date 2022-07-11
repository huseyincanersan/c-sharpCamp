using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmProjectIntro.Models
{
    public class User
    {
        //public int Id { get; set; }
        //public string FirsName { get; set; }
        //public string LastName { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }

        int id;
        string name;
        string username;
        string password;
        string surname;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}
