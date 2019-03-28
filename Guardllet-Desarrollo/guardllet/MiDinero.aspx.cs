using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Guardllet_Desarrollo.Backend.Data.Customers;
using Guardllet_Desarrollo.Backend.Data.Wallet;

namespace Guardllet_Desarrollo.Frontend.Customers
{
    public partial class MiDinero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["usuario"].ToString();
            
            Dictionary<string, string> id_datos = ObtenerDatos.IDcomplementos(id);

            Dictionary<string, string> datos_usuario = ObtenerDatos.Informacion(id_datos["Id_datos"]);

            Lb_Nombre.Text = datos_usuario["Nombre"];
            Lb_Apellido_p.Text = datos_usuario["Apellido_p"];
            Lb_Apellido_M.Text = datos_usuario["Apellido_m"];

            Byte[] codigo_img = ObtenerMonedero.CodigoImg(id_datos["Id_monedero"]);

            string ConvercionImg = "Data:image/jpg;base64," + Convert.ToBase64String(codigo_img);
            Monedero.ImageUrl = ConvercionImg;
            Monedero.Visible = true;

            int saldo = ObtenerMonedero.Saldo(id_datos["Id_monedero"]);

            Lb_Saldo.Text = "$ "+saldo.ToString();
        }
    }
}