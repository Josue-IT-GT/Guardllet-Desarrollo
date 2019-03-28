using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Guardllet_Desarrollo.Backend.Data.Accounts
{
    public class RegistroUsuario
    {
        public static bool Registro(int id_monedero, int id_datos, string correo, string contrasena, string celular)
        {
            bool resultado = false;
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    SqlCommand command = new SqlCommand("RegistroUsuario", Conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_monedero = new SqlParameter("@ID_MONEDERO", SqlDbType.Int);
                    param_monedero.Direction = ParameterDirection.Input;
                    param_monedero.Value = id_monedero;
                    command.Parameters.Add(param_monedero);

                    SqlParameter param_datos = new SqlParameter("@ID_DATOS", SqlDbType.Int);
                    param_datos.Direction = ParameterDirection.Input;
                    param_datos.Value = id_datos;
                    command.Parameters.Add(param_datos);

                    SqlParameter param_correo = new SqlParameter("@CORREO", SqlDbType.VarChar);
                    param_correo.Direction = ParameterDirection.Input;
                    param_correo.Value = correo;
                    command.Parameters.Add(param_correo);

                    SqlParameter param_contrasenia = new SqlParameter("@CONTRASEÑA", SqlDbType.VarChar);
                    param_contrasenia.Direction = ParameterDirection.Input;
                    param_contrasenia.Value = contrasena;
                    command.Parameters.Add(param_contrasenia);

                    SqlParameter param_celular = new SqlParameter("@CELULAR", SqlDbType.VarChar);
                    param_celular.Direction = ParameterDirection.Input;
                    param_celular.Value = celular;
                    command.Parameters.Add(param_celular);

                    SqlParameter param_tipo = new SqlParameter("@TIPO_USUARIO", SqlDbType.Int);
                    param_tipo.Direction = ParameterDirection.Input;
                    param_tipo.Value = 1;
                    command.Parameters.Add(param_tipo);

                    SqlParameter param_estado = new SqlParameter("@ESTADO", SqlDbType.Int);
                    param_estado.Direction = ParameterDirection.Input;
                    param_estado.Value = 1;
                    command.Parameters.Add(param_estado);

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