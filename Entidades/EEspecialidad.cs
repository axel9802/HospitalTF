using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEspecialidad
    {
        public string Nombre { get; set; }
        public int Id_Especialidad { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Id_Especialidad;
        }
    }
}
