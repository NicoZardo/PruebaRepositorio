using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas.PaginasLaboratorista
{
    public partial class NuevoLaboratorista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            //RESTRICCION DE CONTRASEÑA
            if (txtcontraseña.Text == txtconfirm.Text)
            {
                Clases.Laboratorista datos = new Clases.Laboratorista();
                datos.Nombre = txtnombre.Text;
                datos.Apellido = txtapellido.Text;
                datos.Cedula = Convert.ToInt32(txtcedula.Text);
                datos.FechaNacimiento = Convert.ToDateTime(txtfecha.Text, new System.Globalization.CultureInfo("es-ES"));
                datos.Telefono = Convert.ToInt32(txttelefono.Text);
                datos.Direccion = txtdireccion.Text;
                datos.Email = txtemail.Text;
                datos.Usuario = txtusuario.Text;
                datos.Contraseña = txtcontraseña.Text;
                datos.Estado = "Activo";
                Clases.Laboratorista.guardar(datos);
                limpiar();
            }
            else
            {
                txtcontraseña.Text = "";
                txtconfirm.Text = "";
                lblerror.Text = "Verifique su contraseña";
            }
        }

        public void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcedula.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            txtconfirm.Text = "";
            txtfecha.Text = "";
        }
    }
}