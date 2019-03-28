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
        public static int IdxNumero(string celular)
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

        public static Dictionary<string, string> IDcomplementos(string id_usuario)
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SqlConnection Conexion = new SqlConnection(StringConexion))
            {

                Conexion.Open();
                string cmd = string.Format("SELECT * FROM Usuario Where ID_USUARIO ='{0}'", id_usuario);
                DataSet Datos = new DataSet();
                SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                DP.Fill(Datos);
                Conexion.Close();

                try
                {
                    string id_monedero = Datos.Tables[0].Rows[0]["ID_MONEDERO"].ToString();
                    string id_datos = Datos.Tables[0].Rows[0]["ID_DATOS"].ToString();

                    Dictionary<string, string> Complementos = new Dictionary<string, string>();

                    Complementos.Add("Id_monedero", id_monedero);
                    Complementos.Add("Id_datos", id_datos);

                    return Complementos;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                    Dictionary<string, string> Complementos = new Dictionary<string, string>();
                    Complementos.Add("Resultado", exc.ToString());
                    return Complementos;
                }
            }
        }

        public static Dictionary<string, string> Informacion(string id_datos) 
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SqlConnection Conexion = new SqlConnection(StringConexion))
            {

                Conexion.Open();
                string cmd = string.Format("SELECT * FROM DATOS Where ID_DATOS ='{0}'", id_datos);
                DataSet Datos = new DataSet();
                SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                DP.Fill(Datos);
                Conexion.Close();

                try
                {
                    string nombre = Datos.Tables[0].Rows[0]["NOMBRE"].ToString();
                    string apellido_p = Datos.Tables[0].Rows[0]["APELLIDO_P"].ToString();
                    string apellido_m = Datos.Tables[0].Rows[0]["APELLIDO_M"].ToString();

                    Dictionary<string, string> Usuario = new Dictionary<string, string>();

                    Usuario.Add("Nombre", nombre);
                    Usuario.Add("Apellido_p", apellido_p);
                    Usuario.Add("Apellido_m", apellido_m);

                    return Usuario;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                    Dictionary<string, string> Usuario = new Dictionary<string, string>();
                    Usuario.Add("Resultado", exc.ToString());
                    return Usuario;
                }
            }
        }
    }
}