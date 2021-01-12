using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nPaciente
    {
        dPaciente Pacientedatos;
        public nPaciente()
        {
            Pacientedatos = new dPaciente();
        }
        public string InsertarPacientedatos(string nombre,string apellido,string dni,string telefono,string sexo,int edad,string padecimiento,int codigocita)
        {
            ECitaMedica cita = new ECitaMedica()
            {
                Codigo = codigocita
            };

            EPaciente paciente = new EPaciente()
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Telefono = telefono,
                Sexo = sexo,
                Edad = edad,
                Padecimiento = padecimiento,
                CodigoCita = cita
            };
            return Pacientedatos.Insertar(paciente);
        }
        public string ModificarPacientedatos(string nombre, string apellido, string dni, string telefono, string sexo, int edad, string padecimiento, int codigocita)
        {
            ECitaMedica cita = new ECitaMedica()
            {
                Codigo = codigocita
            };

            EPaciente paciente = new EPaciente()
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Telefono = telefono,
                Sexo = sexo,
                Edad = edad,
                Padecimiento = padecimiento,
                CodigoCita = cita
            };
            return Pacientedatos.Modificar(paciente);
        }
        public string EliminarPacientedatos(string dni)
        {
            return Pacientedatos.Eliminar(dni);
        }
        public List<EPaciente> ListarPacientes()
        {
            return Pacientedatos.ListarTodo();
        }
    }
}
