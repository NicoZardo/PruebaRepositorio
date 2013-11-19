using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas.Paginas_Laboratorista
{
    public partial class NuevoEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            if (txtconfirm.Text == txtcontraseña.Text)
            {
                Clases.Empleado datos = new Clases.Empleado();
                datos.Nombre = txtnombre.Text;
                datos.Apellido = txtapellido.Text;
                datos.Cedula = Convert.ToInt32(txtcedula.Text);
                datos.FechaNacimiento = Convert.ToDateTime(txtfecha.Text, new System.Globalization.CultureInfo("es-ES"));
                datos.Direccion = txtdireccion.Text;
                datos.Telefono = Convert.ToInt32(txttelefono.Text);
                datos.Email = txtemail.Text;
                datos.Usuario = txtusuario.Text;
                datos.Contraseña = txtcontraseña.Text;
                datos.Estado = "Activo";
                Clases.Empleado.guardar(datos);
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
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            txtconfirm.Text = "";
            txtemail.Text = "";
            txtfecha.Text = "";

        }
    }
}