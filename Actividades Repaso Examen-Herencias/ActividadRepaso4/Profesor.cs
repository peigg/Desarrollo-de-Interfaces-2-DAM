using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActividadRepaso4
{
    internal class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }
        public void explicar()
        {
            Console.WriteLine(("Estoy explicando."));
        }
    }
}
