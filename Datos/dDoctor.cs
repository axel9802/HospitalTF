using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dDoctor
    {
        Database db = new Database();
        public string Insertar(EDoctor obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("Insert into Doctor(nombre,apellido,dni,telefono,sexo,edad,especialidad,turno,codigocita,idespecialidad) values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}',{8},{9})", obj.Nombre, obj.Apellido, obj.DNI, obj.Telefono, obj.Sexo, obj.Edad, obj.Especialidad, obj.Turno, obj.CodigoCita.Codigo, obj.idEspecialidad.Id_Especialidad);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Inserto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<EDoctor> ListarTodo() //CORREGIR AS PAS
        {
            try
            {
                List<EDoctor> Lsdatos = new List<EDoctor>();
                EDoctor objDatos = null;
                //DateTime d;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select nombre,apellido,dni,telefono,sexo,edad,especialidad,turno,codigocita,idespecialidad from Doctor", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objDatos = new EDoctor();
                    objDatos.Nombre = (string)reader["nombre"];
                    //d = (DateTime)reader["fecha"];
                    //objDatos.Fecha = d.ToShortDateString();
                    objDatos.Apellido = (string)reader["apellido"];
                    objDatos.DNI = (string)reader["dni"];
                    objDatos.Telefono = (string)reader["telefono"];
                    objDatos.Sexo = (string)reader["sexo"];
                    objDatos.Edad = (int)reader["edad"];
                    objDatos.Especialidad = (string)reader["especialidad"];
                    objDatos.Turno = (string)reader["turno"];
                    objDatos.CodigoCita = (ECitaMedica)reader["codigocita"];
                    objDatos.idEspecialidad = (EEspecialidad)reader["idespecialidad"];
                    Lsdatos.Add(objDatos);
                }
                reader.Close();
                return Lsdatos;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public string Modificar(EDoctor obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Doctor set nombre='{0}',apellido='{1}',telefono='{2}',sexo='{3}',edad={4},especialidad='{5}',turno='{6}',codigocita={7},idespecialidad={8} where dni='{9}',", obj.Nombre, obj.Apellido, obj.Telefono, obj.Sexo, obj.Edad, obj.Especialidad, obj.Turno, obj.CodigoCita.Codigo, obj.idEspecialidad.Id_Especialidad, obj.DNI);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modifico";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Eliminar(string dni)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("delete from Doctor where dni='{0}'", dni);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Elimino";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
