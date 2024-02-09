using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class Asistente : User
    {
        public string TipoAsistente { get; set; }

        public Asistente(string id, string name, string surname, string mail, string mobile, DateTime edad, string tipoAsistente) : base(id,name, surname, mail, mobile, edad)
        {
            this.TipoAsistente = tipoAsistente;
        }
    }
}
