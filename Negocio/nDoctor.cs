using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nDoctor
    {
        dDoctor Doctordatos;
        public nDoctor()
        {
            Doctordatos = new dDoctor();
        }
        public string InsertarDoctordatos(string nombre, string apellido, string dni, string telefono, string sexo, int edad,string especialidad, string turno, int codigocita, int idespec)
        {
            ECitaMedica cita = new ECitaMedica()
            {
                Codigo = codigocita
            };
            EEspecialidad objespecialidad = new EEspecialidad()
            {
                Id_Especialidad = idespec
            };
            EDoctor doctor = new EDoctor()
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Telefono = telefono,
                Sexo = sexo,
                Edad = edad,
                Especialidad = especialidad,
                Turno = turno,
                CodigoCita = cita,
                idEspecialidad = objespecialidad
            };
            return Doctordatos.Insertar(doctor);
        }
        public string ModificarDoctordatos(string nombre, string apellido, string dni, string telefono, string sexo, int edad, string especialidad, string turno, int codigocita, int idespec)
        {
            ECitaMedica cita = new ECitaMedica()
            {
                Codigo = codigocita
            };
            EEspecialidad objespecialidad = new EEspecialidad()
            {
                Id_Especialidad = idespec
            };
            EDoctor doctor = new EDoctor()
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Telefono = telefono,
                Sexo = sexo,
                Edad = edad,
                Especialidad = especialidad,
                Turno = turno,
                CodigoCita = cita,
                idEspecialidad = objespecialidad
            };
            return Doctordatos.Modificar(doctor);
        }
        public string EliminarDoctordatos(string dni)
        {
            return Doctordatos.Eliminar(dni);
        }
        public List<EDoctor> ListarDoctores()
        {
            return Doctordatos.ListarTodo();
        }
    }
}
