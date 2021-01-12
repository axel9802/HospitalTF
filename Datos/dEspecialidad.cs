using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dEspecialidad
    {
        Database db = new Database();

        public string Insertar(EEspecialidad obj)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con = db.ConectaDb();
                string insert = string.Format("insert into Especialidad(nombre, idespec) values ('{0}', {1})", obj.Nombre, obj.Id_Especialidad);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return ("Inserto datos");
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<EEspecialidad> ListarTodo()
        {
            try
            {
                List<EEspecialidad> aux = new List<EEspecialidad>();
                EEspecialidad objDatos = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select nombre, idespec from Especialidad", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                objDatos = new EEspecialidad();
                objDatos.Nombre = (string)reader["nombre"];
                objDatos.Id_Especialidad = (int)reader["idespec"];
                aux.Add(objDatos);
                }
                reader.Close();
                return aux;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Modificar(EEspecialidad obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Especialidad set nombre = '{0}' where idespec={1}", obj.Nombre, obj.Id_Especialidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modifico datos";
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
        public string Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("delete from Especialidad where idespec={0}", id);
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
