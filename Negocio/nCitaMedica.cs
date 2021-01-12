using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nCitaMedica
    {
        dDatos CitaMedicadatos;
        public nCitaMedica()
        {
            CitaMedicadatos = new dDatos();
        }
        public string InsertarCitaMedicadatos(int codigo, DateTime fecha, float precio, string descripcion)
        {
            ECitaMedica cita = new ECitaMedica()
            {
                Codigo = codigo,
                Fecha = fecha,
                Precio = precio,
                Descripcion = descripcion
            };
            return CitaMedicadatos.Insertar(cita);
        }
        public string ModificarCitaMedicadatos(int codigo, DateTime fecha, float precio, string descripcion)
        {
            ECitaMedica cita = new ECitaMedica()
            {
                Codigo = codigo,
                Fecha = fecha,
                Precio = precio,
                Descripcion = descripcion
            };
            return CitaMedicadatos.Modificar(cita);
        }
        public string EliminarCitaMedicadatos(int codigo)
        {
            return CitaMedicadatos.Eliminar(codigo);
        }
        public List<ECitaMedica> ListaCitas()
        {
            return CitaMedicadatos.ListarTodo();
        }
    }
}
