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
    public class ObtenerMonedero
    {
        public static int IdxCodigo(string codigo)
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    string cmd = string.Format("SELECT ID_MONEDERO FROM MONEDERO WHERE NUM_CODIGO ='{0}'", codigo);
                    DataSet Datos = new DataSet();
                    SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                    DP.Fill(Datos);
                    Conexion.Close();

                    int Id = Convert.ToInt32(Datos.Tables[0].Rows[0]["ID_MONEDERO"].ToString());

                    return Id;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return 0;
            }     
        }

        public static Byte[] CodigoImg(string id_monedero)
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SqlConnection Conexion = new SqlConnection(StringConexion))
            {

                Conexion.Open();
                string cmd = string.Format("SELECT IMG_CODIGO FROM MONEDERO Where ID_MONEDERO ='{0}'", id_monedero);
                DataSet Datos = new DataSet();
                SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                DP.Fill(Datos);
                Conexion.Close();

                try
                {
                    Byte[] bytes = new Byte[0];
                    bytes = (Byte[])Datos.Tables[0].Rows[0]["IMG_CODIGO"];

                    return bytes;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                    Byte[] bytes = new Byte[0];
                    return bytes;
                }
            }
        }

        public static int Saldo(string id_monedero) 
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SqlConnection Conexion = new SqlConnection(StringConexion))
            {

                Conexion.Open();
                string cmd = string.Format("SELECT SALDO FROM MONEDERO Where ID_MONEDERO ='{0}'", id_monedero);
                DataSet Datos = new DataSet();
                SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                DP.Fill(Datos);
                Conexion.Close();

                int saldo = Convert.ToInt16(Datos.Tables[0].Rows[0]["SALDO"]);

                return saldo;
            }
        }
    }
}