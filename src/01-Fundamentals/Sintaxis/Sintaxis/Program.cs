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

            Articulo[] art = new Articulo[10];

            persona.Nombre = "German";
            persona.Edad = 32;
            persona.Sueldo = 30000;

            Console.WriteLine("Persona: " + persona.Nombre + ", Edad: " + persona.Edad);
            Console.WriteLine(persona.Saludar());

            for (int i = 0; i < 10; i++)
            {
                art[i].CodigoArticulo = int.Parse(Console.ReadLine());
                art[i].Precio = int.Parse(Console.ReadLine());
                art[i].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Botella botella2 = new Botella("Rojo", "Plastico");

        }
    }
}
