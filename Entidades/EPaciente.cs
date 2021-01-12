using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPaciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Padecimiento { get; set; }
        public ECitaMedica CodigoCita { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido + "  " + DNI + "" + Telefono + "" + Sexo + "" + Edad + "" + Padecimiento;
        }
    }
}
