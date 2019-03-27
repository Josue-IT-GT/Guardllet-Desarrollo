using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Guardllet_Desarrollo.Backend.Data.Wallet
{
    public class CreacionMonedero
    {
        public static bool Crear(string codigo, Byte[] img_codigo)
        {
            bool resultado = false;
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    SqlCommand command = new SqlCommand("RegistroMonedero", Conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_saldo = new SqlParameter("@SALDO", SqlDbType.VarChar);
                    param_saldo.Direction = ParameterDirection.Input;
                    param_saldo.Value = "0";
                    command.Parameters.Add(param_saldo);

                    SqlParameter param_n_codigo = new SqlParameter("@NUM_CODIGO", SqlDbType.VarChar);
                    param_n_codigo.Direction = ParameterDirection.Input;
                    param_n_codigo.Value = codigo;
                    command.Parameters.Add(param_n_codigo);

                    SqlParameter param_i_codigo = new SqlParameter("@IMG_CODIGO", SqlDbType.Image);
                    param_i_codigo.Direction = ParameterDirection.Input;
                    param_i_codigo.Value = img_codigo;
                    command.Parameters.Add(param_i_codigo);

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