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
    public class ObtenerDatos
    {
        public static int ObtenerIdxNumero(string celular)
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    string cmd = string.Format("SELECT ID_DATOS FROM DATOS WHERE CELULAR ='{0}'", celular);
                    DataSet Datos = new DataSet();
                    SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                    DP.Fill(Datos);
                    Conexion.Close();

                    int Id = Convert.ToInt32(Datos.Tables[0].Rows[0]["ID_DATOS"].ToString());

                    return Id;
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