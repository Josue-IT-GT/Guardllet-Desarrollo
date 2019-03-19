using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Guardllet_Desarrollo.Backend.Data.Accounts;
using Guardllet_Desarrollo.Backend.Data.Customers;
using Guardllet_Desarrollo.Backend.Data.Wallet;

namespace Guardllet_Desarrollo.Frontend.Accounts
{
    public partial class Registrate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            bool estado_datos = DatosUsuario.Inicializar(TxtCelular.Text);
            if (estado_datos)
            {
                bool estado_monedero = CreacionMonedero.Crear("asdfghjklas");
                if (estado_monedero)
                {
                    int id_datos = ObtenerDatos.ObtenerIdxNumero(TxtCelular.Text);
                    int id_monedero = ObtenerMonedero.ObtenerIdxCodigo("asdfghjklas");
                    bool estado_usuario = RegistroUsuarios.Registro(id_monedero, id_datos, TxtCorreo.Text, TxtContraseña.Text, TxtCelular.Text);
                    
                    Response.Redirect("Completar-Datos.aspx");
                }
            }
        }
    }
}