using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    internal class Botella
    {
        //Contructor
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }

        //Sobrecarga
        public Botella() { }

        //Destructor
        ~Botella() 
        { 
            //logica
        }

        private int capacidad;
        private string color;
        private string material;

        public int Capacidad {  get { return capacidad; } set { capacidad = value; }}

        public string Color { get { return color; } set { color = value; }}

        public string Material { get { return material; } set { material = value; }}


    }
}
