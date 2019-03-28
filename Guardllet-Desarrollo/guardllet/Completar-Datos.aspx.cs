﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;

using Guardllet_Desarrollo.Backend.Data.Customers;
using Guardllet_Desarrollo.Backend.Data.Accounts;

namespace Guardllet_Desarrollo.Frontend.Accounts
{
    public partial class Completar_Datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ListaEscuelas.Items.Insert(0, "Escuela");
                Dictionary<int, Dictionary<string, string>> Paises = Datos.ObtenerEscuelas();
                int numero_paises = Paises.Count();
                for (int i = 0; i < numero_paises; i++)
                {
                    Dictionary<string, string> Pais = Paises[i];
                    int id = Convert.ToInt16(Pais["Id"]);
                    string nombre = Pais["Nombre"];
                    ListaEscuelas.Items.Insert(id, nombre);
                }
            }
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Session["usuario"].ToString());
            string escuela = ListaEscuelas.SelectedIndex.ToString();
            bool estado_datos = AgregarDatos.Agregar(id,TxtNombre.Text.Trim(), TxtApellidoP.Text.Trim(),TxtApellidoM.Text.Trim(), TxtBoleta.Text.Trim(),escuela.Trim());
            
            if (estado_datos) 
            {
                string id_usuario = id.ToString();
                FormsAuthentication.SetAuthCookie(id_usuario, false);
                Response.Redirect("MiDinero.aspx", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
        }
    }
}