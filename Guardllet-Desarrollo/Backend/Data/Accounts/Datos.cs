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
    public class Datos
    {
        public static Dictionary<int, Dictionary<string, string>> ObtenerEscuelas() 
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    string cmd = string.Format("SELECT * FROM ESCUELAS");
                    DataSet Datos = new DataSet();
                    SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                    DP.Fill(Datos);
                    Conexion.Close();
                    try
                    {
                        int numero_escuelas = Datos.Tables[0].Rows.Count;
                        Dictionary<int, Dictionary<string, string>> Escuelas = new Dictionary<int, Dictionary<string, string>>();
                        for (int contador = 0; contador < numero_escuelas; contador++)
                        {
                            string id = Datos.Tables[0].Rows[contador]["ID_ESCUELA"].ToString();
                            string nombre = Datos.Tables[0].Rows[contador]["NOMBRE"].ToString();
                            Dictionary<string, string> Escuela = new Dictionary<string, string>();
                            Escuela.Add("Id", id);
                            Escuela.Add("Nombre", nombre);
                            Escuelas.Add(contador, Escuela);
                        }
                        return Escuelas;
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                        Dictionary<int, Dictionary<string, string>> Escuelas = new Dictionary<int, Dictionary<string, string>>();
                        return Escuelas;
                    }
                }
            }
            catch (Exception exc) 
            {
                Console.WriteLine(exc);
                Dictionary<int, Dictionary<string, string>> Escuelas = new Dictionary<int, Dictionary<string, string>>();
                return Escuelas;
            }
        }

        public static int ObtenerID(string correo) 
        {
            string StringConexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SqlConnection Conexion = new SqlConnection(StringConexion))
                {
                    Conexion.Open();
                    string cmd = string.Format("SELECT ID_USUARIO FROM USUARIO WHERE CORREO ='{0}'", correo);
                    DataSet Datos = new DataSet();
                    SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
                    DP.Fill(Datos);
                    Conexion.Close();

                    int Id = Convert.ToInt32(Datos.Tables[0].Rows[0]["ID_USUARIO"].ToString());

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