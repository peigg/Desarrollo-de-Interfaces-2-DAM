﻿using System;
using System.Collections.Generic;
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
        return "Hola, me llamo " + Nombre;
        }
    }
}
