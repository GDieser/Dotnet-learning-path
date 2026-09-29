using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    internal class Persona
    {
        private int edad;
        private int sueldo;
        private string nombre;

        public int Edad{

            get { return edad; }
            set { edad = value; }
        }
        public int Sueldo{ get { return sueldo; } set { sueldo = value; } }

        public string Nombre{ get { return nombre; } set { nombre = value; } }
    }
}
