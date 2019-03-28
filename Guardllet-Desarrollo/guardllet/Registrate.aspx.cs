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


namespace Guardllet_Desarrollo.Frontend.Accounts
{
    public partial class Registrate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            bool estado_datos = AgregarDatos.Inicializar(TxtCelular.Text);
            if (estado_datos)
            {

                string codigo_monedero = CreacionCodigo.Monedero(TxtCelular.Text.Trim());
                Byte[] codigo_barras = CreacionCodigo.Barras(codigo_monedero);

                bool estado_monedero = CreacionMonedero.Crear(codigo_monedero,codigo_barras);
                if (estado_monedero)
                {

                    int id_datos = ObtenerDatos.ObtenerIdxNumero(TxtCelular.Text);
                    int id_monedero = ObtenerMonedero.ObtenerIdxCodigo(codigo_monedero);

                    bool estado_usuario = RegistroUsuario.Registro(id_monedero, id_datos, TxtCorreo.Text, TxtContraseña.Text, TxtCelular.Text);
                    if(estado_usuario)
                    {
                        string id_usuario = Datos.ObtenerID(TxtCorreo.Text).ToString();
                        Session["usuario"] = id_usuario;
                        FormsAuthentication.SetAuthCookie(id_usuario, false);
                        Response.Redirect("Completar-Datos.aspx", false);
                        HttpContext.Current.ApplicationInstance.CompleteRequest();
                    }
                }
            }
        }
    }
}