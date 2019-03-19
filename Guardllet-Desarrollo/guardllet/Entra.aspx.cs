using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            
            bool login = SesionUsuario.IniciarSesion(TxtCorreo.Text,TxtContraseña.Text);
            if (login) 
            {
                Console.WriteLine("Siiiiiiii");
            }
        }
    }
}