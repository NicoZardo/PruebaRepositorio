using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas.PaginasLaboratorista
{
    public partial class ModificarInformacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Clases.Empleado> lista = Clases.Empleado.buscarPorCedula(Convert.ToInt32(txtcedula.Text));
            foreach (Clases.Empleado em in lista)
            {
                txtdireccion.Text = em.Direccion;
                txttelefono.Text = em.Telefono.ToString();
                txtemail.Text = em.Email;
                txtusuario.Text = em.Usuario;
                txtcont.Text = em.Contraseña;
                txtestado.Text = em.Estado;
            }
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            int ced = Convert.ToInt32(txtcedula.Text);
            string dir = txtdireccion.Text;
            int tel = Convert.ToInt32(txttelefono.Text);
            string mail = txtemail.Text;
            string us = txtusuario.Text;
            string cont = txtcont.Text;
            string est;
            if (cboxdespedir.Checked == true)
                est = "Despedido";
            else
                est = txtestado.Text;
            Clases.Empleado.modificar(ced, dir, tel, mail, us, cont, est);
            limpiar();
        }

        public void limpiar()
        {
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
            txtusuario.Text = "";
            txtcont.Text = "";
            txtestado.Text = "";
            cboxcont.Checked = false;
            cboxdespedir.Checked = false;
            cboxdireccion.Checked = false;
            cboxemail.Checked = false;
            cboxtelefono.Checked = false;
            cboxusuario.Checked = false;
        }
    }
}