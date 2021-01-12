using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EDoctor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Especialidad { get; set; }
        public string Turno { get; set; }
        public ECitaMedica CodigoCita { get; set; }
        public EEspecialidad idEspecialidad { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido + "  " + DNI + " " + Telefono + " " + Sexo + " " + Edad + " " + Especialidad + " " + Turno;
        }


    }
}
