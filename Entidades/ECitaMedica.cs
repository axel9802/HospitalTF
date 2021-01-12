using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECitaMedica
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Codigo + " " + Fecha + " " + Descripcion + "  " + Precio;
        }

    }
}
