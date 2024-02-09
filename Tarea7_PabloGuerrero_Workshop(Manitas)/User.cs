using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class User
    {
        // Properties
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string mobile { get; set; }
        public DateTime edad { get; set; }

        public User(string name, string surname, string mail, string mobile, DateTime edad)
        {
            name = name;
            surname = surname;
            mail = mail;
            mobile= mobile;
            edad = edad;
        }
    }
}
