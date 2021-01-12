using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dDatos
    {
        Database db = new Database();
        public string Insertar(ECitaMedica obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("Insert into CitaMedica(codigo,fecha,precio,descrip) values({0}, '{1}', {2}, '{3}')", obj.Codigo, obj.Fecha, obj.Precio, obj.Descripcion);
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
        public List<ECitaMedica> ListarTodo()
        {
            try
            {
                List<ECitaMedica> Lsdatos = new List<ECitaMedica>();
                ECitaMedica objDatos = null;
                //DateTime d;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select codigo,fecha,precio,descrip from CitaMedica", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objDatos = new ECitaMedica();
                    objDatos.Codigo = (int)reader["codigo"];
                    //d = (DateTime)reader["fecha"];
                    //objDatos.Fecha = d.ToShortDateString();
                    objDatos.Fecha = (DateTime)reader["fecha"];
                    objDatos.Precio = (float)reader["precio"];
                    objDatos.Descripcion = (string)reader["descrip"];
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
        public string Modificar(ECitaMedica obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update CitaMedica set fecha'{0}',precio={1}, descrip={2} where codigo={3},", obj.Fecha, obj.Precio, obj.Descripcion, obj.Codigo);
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

        public string Eliminar(int codigo)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("delete from CitaMedica where codigo={0}", codigo);
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
