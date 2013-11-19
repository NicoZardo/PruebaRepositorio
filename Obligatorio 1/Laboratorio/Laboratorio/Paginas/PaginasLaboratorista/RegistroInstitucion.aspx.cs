using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Paginas.Paginas_Laboratorista
{
    public partial class RegistroInstitucion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Institucion datos = new Clases.Institucion();
            datos.Nombre = txtnombre.Text;
            datos.Direccion = txtdireccion.Text;
            datos.Telefono = Convert.ToInt32(txttelefono.Text);
            datos.Email = txtemail.Text;
            Clases.Institucion.guardar(datos);
            limpiar();
        }

        public void limpiar()
        {
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
        }
    }
}