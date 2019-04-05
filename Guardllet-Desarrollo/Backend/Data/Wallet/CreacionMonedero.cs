﻿using System;
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
        public static int Crear(string codigo, Byte[] img_codigo)
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    SqlCommand command = new SqlCommand("RegistroMonedero", Conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_saldo = new SqlParameter("@CODIGO", SqlDbType.VarChar);
                    param_saldo.Direction = ParameterDirection.Input;
                    param_saldo.Value = codigo;
                    command.Parameters.Add(param_saldo);

                    SqlParameter param_n_codigo = new SqlParameter("@IMAGEN_CODIGO", SqlDbType.Image);
                    param_n_codigo.Direction = ParameterDirection.Input;
                    param_n_codigo.Value = img_codigo;
                    command.Parameters.Add(param_n_codigo);

                    SqlParameter param_i_codigo = new SqlParameter("@SALDO", SqlDbType.Int);
                    param_i_codigo.Direction = ParameterDirection.Input;
                    param_i_codigo.Value = 0;
                    command.Parameters.Add(param_i_codigo);

                    SqlParameter param_salida = new SqlParameter("@ID_REGISTRO", SqlDbType.Int);
                    param_salida.Direction = ParameterDirection.Output;
                    command.Parameters.Add(param_salida);

                    command.ExecuteScalar();

                    Conexion.Close();

                    int resultado = Convert.ToInt16(command.Parameters["@ID_REGISTRO"].Value.ToString());

                    return resultado;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return 0;
            }
        }
    }
}