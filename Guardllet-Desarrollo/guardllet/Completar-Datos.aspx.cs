using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;

using Guardllet_Desarrollo.Backend.Data.Customers;

namespace Guardllet_Desarrollo.Frontend.Accounts
{
    public partial class Completar_Datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Session["usuario"].ToString());
            bool estatus_datos = AgregarDatos.Agregar(id,TxtNombre.Text.Trim(), TxtApellidoP.Text.Trim(),
                                                      TxtApellidoM.Text.Trim(), TxtBoleta.Text.Trim(),
                                                      TxtGrupo.Text.Trim());
            if (estatus_datos) 
            {


                string id_usuario = id.ToString();
                FormsAuthentication.SetAuthCookie(id_usuario, false);
                Response.Redirect("MiDinero.aspx", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
        }
    }
}