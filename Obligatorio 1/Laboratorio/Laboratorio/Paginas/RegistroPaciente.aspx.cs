using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas
{
    public partial class RegistroPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlinstitucion.Items.Add("Seleccione");
                ddlid.Items.Add("Seleccione");
                List<Clases.Institucion> nomId = Clases.Institucion.mostrar();
                foreach (Clases.Institucion i in nomId)
                {
                    ddlid.Items.Add(i.Id.ToString());
                    ddlinstitucion.Items.Add(i.Nombre);
                }
            }
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Clientes.Paciente datos = new Clases.Clientes.Paciente();
            datos.Nombre = txtnombre.Text;
            datos.Apellido = txtapellido.Text;
            datos.Cedula = Convert.ToInt32(txtcedula.Text);
            datos.Telefono = Convert.ToInt32(txttelefon.Text);
            datos.Direccion = txtdireccion.Text;
            datos.FechaNacimiento = Convert.ToDateTime(txtfecha.Text, new System.Globalization.CultureInfo("es-ES"));
            datos.Email = txtemail.Text;
            if (cbxafiliado.Checked == true && ddlinstitucion.SelectedValue!="Seleccione")
                datos.Filiacion = ddlinstitucion.SelectedValue;
            else
                datos.Filiacion = "No";
            datos.Estado = "Activo";
            Clases.Clientes.Paciente.guardar(datos);
            limpiar();
        }

        public void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txttelefon.Text = "";
            txtcedula.Text = "";
            txtfecha.Text = "";
            cbxafiliado.Checked = false;
            ddlinstitucion.SelectedIndex = 0;
            ddlid.SelectedIndex = 0;
            ddlinstitucion.Enabled = false;
        }

        protected void cbxafiliado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxafiliado.Checked == true)
                ddlinstitucion.Enabled = true;
            else
                ddlinstitucion.Enabled = false;
        }

        protected void ddlid_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlid.SelectedIndex = ddlinstitucion.SelectedIndex;
        }

        protected void ddlinstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlid.SelectedIndex = ddlinstitucion.SelectedIndex;
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            Server.Transfer("ModificarPaciente.aspx");
        }
    }
}