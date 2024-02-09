using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesRepaso
{
    public class Persona
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
        return ("Hola, me llamo " + Nombre);
        }
        public string Saludar()
        {
            return ("Hola");
        }

        public int setEdad()
        { 
            Random random = new Random();

            int edad = random.Next(10, 80);

            return edad;

        }

        public string verEdad(int edad)
        {
            return ("Mi edad es " + edad);
        }
    }
}
