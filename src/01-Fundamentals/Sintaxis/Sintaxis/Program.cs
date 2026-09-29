using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Persona persona = new Persona();
            Botella botella = new Botella();

            persona.Nombre = "German";
            persona.Edad = 32;
            persona.Sueldo = 30000;

            Console.WriteLine("Persona: " + persona.Nombre + ", Edad: " + persona.Edad);

        }
    }
}
