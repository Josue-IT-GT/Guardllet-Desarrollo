using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Guardllet_Desarrollo.Backend.Data.Customers
{
    public class AgregarDatos
    {
        public static bool Inicializar(string celular)
        {
            bool resultado = false;
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    SqlCommand command = new SqlCommand("InicializarDatos", Conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_nombre = new SqlParameter("@NOMBRE", SqlDbType.VarChar);
                    param_nombre.Direction = ParameterDirection.Input;
                    param_nombre.Value = " ";
                    command.Parameters.Add(param_nombre);

                    SqlParameter param_apellidop = new SqlParameter("@APELLIDO_P", SqlDbType.VarChar);
                    param_apellidop.Direction = ParameterDirection.Input;
                    param_apellidop.Value = " ";
                    command.Parameters.Add(param_apellidop);

                    SqlParameter param_apellidom = new SqlParameter("@APELLIDO_M", SqlDbType.VarChar);
                    param_apellidom.Direction = ParameterDirection.Input;
                    param_apellidom.Value = " ";
                    command.Parameters.Add(param_apellidom);

                    SqlParameter param_celular = new SqlParameter("@CELULAR", SqlDbType.VarChar);
                    param_celular.Direction = ParameterDirection.Input;
                    param_celular.Value = celular;
                    command.Parameters.Add(param_celular);

                    SqlParameter param_boleta = new SqlParameter("@BOLETA", SqlDbType.VarChar);
                    param_boleta.Direction = ParameterDirection.Input;
                    param_boleta.Value = " ";
                    command.Parameters.Add(param_boleta);

                    SqlParameter param_escuela = new SqlParameter("@ID_ESCUELA", SqlDbType.Int);
                    param_escuela.Direction = ParameterDirection.Input;
                    param_escuela.Value = 1;
                    command.Parameters.Add(param_escuela);

                    SqlParameter param_foto = new SqlParameter("@FOTO", SqlDbType.VarChar);
                    param_foto.Direction = ParameterDirection.Input;
                    param_foto.Value = " ";
                    command.Parameters.Add(param_foto);

                    command.ExecuteScalar();

                    Conexion.Close();

                    resultado = true;
                    return resultado;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return resultado;
            }
        }

        public static bool Agregar(int id, string nombre, string apellido_p, string apellido_m, string boleta, string escuela)
        {
            bool resultado = false;
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    SqlCommand command = new SqlCommand("RegistroDatos", Conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_id = new SqlParameter("@ID", SqlDbType.Int);
                    param_id.Direction = ParameterDirection.Input;
                    param_id.Value = id;
                    command.Parameters.Add(param_id);

                    SqlParameter param_nombre = new SqlParameter("@NOMBRE", SqlDbType.VarChar);
                    param_nombre.Direction = ParameterDirection.Input;
                    param_nombre.Value = nombre;
                    command.Parameters.Add(param_nombre);

                    SqlParameter param_apellidop = new SqlParameter("@APELLIDO_P", SqlDbType.VarChar);
                    param_apellidop.Direction = ParameterDirection.Input;
                    param_apellidop.Value = apellido_p;
                    command.Parameters.Add(param_apellidop);

                    SqlParameter param_apellidom = new SqlParameter("@APELLIDO_M", SqlDbType.VarChar);
                    param_apellidom.Direction = ParameterDirection.Input;
                    param_apellidom.Value = apellido_m;
                    command.Parameters.Add(param_apellidom);

                    SqlParameter param_boleta = new SqlParameter("@BOLETA", SqlDbType.VarChar);
                    param_boleta.Direction = ParameterDirection.Input;
                    param_boleta.Value = boleta;
                    command.Parameters.Add(param_boleta);

                    SqlParameter param_escuela = new SqlParameter("@ID_ESCUELA", SqlDbType.Int);
                    param_escuela.Direction = ParameterDirection.Input;
                    param_escuela.Value = escuela;
                    command.Parameters.Add(param_escuela);

                    SqlParameter param_foto = new SqlParameter("@FOTO", SqlDbType.VarChar);
                    param_foto.Direction = ParameterDirection.Input;
                    param_foto.Value = "asdfg";
                    command.Parameters.Add(param_foto);

                    command.ExecuteScalar();
                    Conexion.Close();
                    resultado = true;

                    return resultado;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return resultado;
            }
        }
    }
}