using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class Colaborador : User
    {
        public string Cargo { get; set; }

        public Colaborador(string id, string name, string surname, string mail, string mobile, DateTime edad, string cargo) : base(id,name, surname, mail, mobile, edad)
        {
            this.Cargo = cargo;
        }
    }

}
