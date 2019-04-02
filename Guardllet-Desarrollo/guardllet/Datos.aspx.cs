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

            int escuela = Convert.ToInt16(ListaEscuelas.SelectedValue.ToString());

            int estado_datos = AgregarDatos.Generales(TxtNombre.Text.Trim(), TxtApellidoP.Text.Trim(),TxtApellidoM.Text.Trim(), TxtCelular.Text.Trim());
            
            int estado_datos_escolares = AgregarDatos.Escolares(escuela,TxtBoleta.Text.Trim(),TxtGrupo.Text.Trim(),TxtEdad.Text.Trim());

            if (estado_datos != 0 & estado_datos_escolares != 0) 
            {

                string id_usuario = id.ToString();
                FormsAuthentication.SetAuthCookie(id_usuario, false);
                Response.Redirect("MiDinero.aspx", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
        }
    }
}