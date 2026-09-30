using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    internal class Articulo
    {
        // "prop" forma abreviada
        public int CodigoArticulo { get; set; }

        public float Precio { get; set; }

        //public int CodigoMarca { get; set; }
        private int codMarca;

        public int CodigoMarca
        {
            get { return codMarca; }

            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;

            }
        }

    }
}
