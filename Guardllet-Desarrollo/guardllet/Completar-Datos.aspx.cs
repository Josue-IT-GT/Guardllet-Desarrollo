using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            bool estatus_datos = DatosUsuario.Agregar(TxtNombre.Text.Trim(),TxtApellidoP.Text.Trim(),
                                                      TxtApellidoM.Text.Trim(),TxtBoleta.Text.Trim(),
                                                      TxtGrupo.Text.Trim())
        }
    }
}