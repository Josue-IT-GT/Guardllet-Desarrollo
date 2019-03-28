using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;

using Guardllet_Desarrollo.Backend.Data.Accounts;

namespace Guardllet_Desarrollo.Frontend.Accounts
{
    public partial class Iniciar_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnResgitrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrate.aspx");
        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            
            bool login = SesionUsuario.IniciarSesion(TxtCorreo.Text.Trim(),TxtContraseña.Text.Trim());
            if (login)
            {
                int id = Datos.ObtenerID(TxtCorreo.Text.Trim());
                
                string id_usuario = id.ToString();
                FormsAuthentication.SetAuthCookie(id_usuario, false);
                Response.Redirect("MiDinero.aspx", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            else 
            {
 
            }
        }
    }
}