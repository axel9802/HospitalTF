using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dPaciente
    {
        Database db = new Database();
        public string Insertar(EPaciente obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("Insert into Paciente(nombre,apellido,dni,telefono,sexo,edad,padecimiento,codigocita) values('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7})", obj.Nombre, obj.Apellido, obj.DNI, obj.Telefono, obj.Sexo, obj.Edad, obj.Padecimiento,obj.CodigoCita.Codigo);
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

        public List<EPaciente> ListarTodo() //CORREGIR AS PAS
        {
            try
            {
                List<EPaciente> Lsdatos = new List<EPaciente>();
                EPaciente objDatos = null;
                //DateTime d;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select pa.nombre,pa.apellido,pa.dni,pa.telefono,pa.sexo,pa.edad,pa.padecimiento,cit.codigocita as CitaMedica,cit.codcita from CitaMedica as cit, Paciente as pa where cit.=pa.CodigoCita", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objDatos = new EPaciente();
                    objDatos.Nombre = (string)reader["nombre"];
                    //d = (DateTime)reader["fecha"];
                    //objDatos.Fecha = d.ToShortDateString();
                    objDatos.Apellido = (string)reader["apellido"];
                    objDatos.DNI = (string)reader["dni"];
                    objDatos.Telefono = (string)reader["telefono"];
                    objDatos.Sexo = (string)reader["sexo"];
                    objDatos.Edad = (int)reader["edad"];
                    objDatos.Padecimiento = (string)reader["padecimiento"];
                    objDatos.CodigoCita = (ECitaMedica)reader["codigocita"];   
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

        public string Modificar(EPaciente obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Paciente set nombre='{0}',apellido='{1}',telefono='{2}',sexo='{3}',edad={4},padecimiento='{5}',codigocita={6} where dni='{7}',", obj.Nombre, obj.Apellido, obj.Telefono, obj.Sexo, obj.Edad, obj.Padecimiento, obj.CodigoCita.Codigo, obj.DNI);
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
                string delete = string.Format("delete from Paciente where dni='{0}'", dni);
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