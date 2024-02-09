using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadRepaso4
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return ("Hola, me llamo " + Nombre);
        }
        public Persona()
        {
            Nombre = string.Empty;
        }
    }
}

