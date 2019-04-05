﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Drawing;
using System.Web.Security;

using Guardllet_Desarrollo.Backend.Data.Accounts;
using Guardllet_Desarrollo.Backend.Data.Customers;
using Guardllet_Desarrollo.Backend.Data.Wallet;
using Guardllet_Desarrollo.Backend.Emails;


namespace Guardllet_Desarrollo.Frontend.Accounts
{
    public partial class Registrate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {     
            int id_usuario = RegistroUsuario.Registro(TxtCorreo.Text.Trim(), TxtContraseña.Text.Trim());

            if (id_usuario != 0)
            {
                bool correo = EnviarCorreo.Registro(TxtCorreo.Text.Trim());

                Session["usuario"] = id_usuario;
                string id = id_usuario.ToString();
                FormsAuthentication.SetAuthCookie(id, false);
                Response.Redirect("Datos.aspx", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }            
        }
    }
}