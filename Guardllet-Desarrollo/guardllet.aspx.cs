﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Guardllet_Desarrollo
{
    public partial class guardllet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("guardllet/Entra.aspx");
        }

        protected void BtnRegitrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("guardllet/Registrate.aspx");
        }
    }
}