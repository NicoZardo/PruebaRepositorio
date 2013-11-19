using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas
{
    public partial class ModificarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlfiliacion.Items.Add("Seleccione");
                ddlfiliacion.Items.Add("Ninguno");
                List<Clases.Institucion> lista = Clases.Institucion.mostrar();
                foreach (Clases.Institucion i in lista)
                {
                    ddlfiliacion.Items.Add(i.Nombre);
                }
            }
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            int ced = Convert.ToInt32(txtcedula.Text);
            string dir = txtdireccion.Text;
            int tel = Convert.ToInt32(txttelefono.Text);
            string email = txtemail.Text;
            string fil;
            if (cboxfiliacion.Checked == true)
                fil = ddlfiliacion.SelectedValue;
            else
                fil = txtfiliacion.Text;
            string estado;
            if (cboxbaja.Visible=true && cboxbaja.Checked == true)
                estado = "Inactivo";
            else
                estado = txtestado.Text;
            if (cboxalta.Visible = true && cboxalta.Checked == true)
                estado = "Activo";
            else
                estado = txtestado.Text;
            Clases.Clientes.Paciente.modificar(ced, dir, tel, email, fil, estado);
            limpiar();
        }

        public void limpiar()
        {
            txtcedula.Text = "";
            lbldatos.Text = "";
            cboxtelefono.Checked = false;
            txttelefono.Text = "";
            cboxdireccion.Checked = false;
            txtdireccion.Text = "";
            cboxemail.Checked = false;
            txtemail.Text = "";
            cboxfiliacion.Checked = false;
            cboxbaja.Checked = false;
            cboxalta.Checked = false;
        }

        protected void ddlfiliacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Clases.Clientes.Paciente> lista = Clases.Clientes.Paciente.buscarPorCedula(Convert.ToInt32(txtcedula.Text));
            foreach (Clases.Clientes.Paciente p in lista)
            {
                txtdireccion.Text = p.Direccion;
                txtemail.Text = p.Email;
                txttelefono.Text = p.Telefono.ToString();
                txtfiliacion.Text = p.Filiacion;
                txtestado.Text = p.Estado;
            }
            if (txtestado.Text == "Inactivo")
            {
                cboxalta.Visible = true;
                cboxbaja.Visible = false;
            }
            else
            {
                cboxbaja.Visible = true;
                cboxalta.Visible = false;
            }
        }

        protected void cboxtelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxtelefono.Checked == true)
            {
                txttelefono.Enabled = true;
                txttelefono.Text = "";
            }
            else
                txttelefono.Enabled = false;
        }

        protected void cboxdireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxdireccion.Checked == true)
            {
                txtdireccion.Enabled = true;
                txtdireccion.Text = "";
            }
            else
                txtdireccion.Enabled = false;
        }

        protected void cboxemail_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxemail.Checked == true)
            {
                txtemail.Enabled = true;
                txtemail.Text = "";
            }
            else
                txtemail.Enabled = false;
        }

        protected void cboxfiliacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxfiliacion.Checked == true)
                ddlfiliacion.Enabled = true;
            else
                ddlfiliacion.Enabled = false;
        }
    }
}