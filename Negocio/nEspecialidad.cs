using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nEspecialidad
    {
        dEspecialidad especialidaddatos;
        public nEspecialidad()
        {
            especialidaddatos = new dEspecialidad();
        }

        public string InsertarEspecialidaddatos(string nombre, int idespec)
        {
            EEspecialidad especialidad = new EEspecialidad()
            {
                Nombre = nombre,
                Id_Especialidad = idespec
            };
            return especialidaddatos.Insertar(especialidad);
        }
        public string ModificarEspecialidaddatos(string nombre, int idespec)
        {
            EEspecialidad especialidad = new EEspecialidad()
            {
                Nombre = nombre,
                Id_Especialidad = idespec
            };
            return especialidaddatos.Modificar(especialidad);
        }
        public string EliminarEspecialidaddatos(int idespec)
        {
            return especialidaddatos.Eliminar(idespec);
        }
        public List<EEspecialidad> ListarEspecialidad()
        {
            return especialidaddatos.ListarTodo();
        }
    }
}
