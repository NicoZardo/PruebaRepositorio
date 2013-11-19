using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas
{
    public partial class NuevaExtraccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlanalisis.Items.Add("Seleccione");
                ddlid.Items.Add("Seleccione");
                List<Clases.Referencias.Referencia> lista = Clases.Referencias.Referencia.mostrar();
                foreach (Clases.Referencias.Referencia r in lista)
                {
                    ddlanalisis.Items.Add(r.Analisis.ToString());
                    ddlid.Items.Add(r.Id.ToString());
                }
            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            //BUSCA AL PACIENTE EN BD Y CORROBORA DE QUE LO ENCONTRO MOSTRANDO SUS DATOS
            List<Clases.Clientes.Paciente> lista = Clases.Clientes.Paciente.buscarPorCedula(Convert.ToInt32(txtcedula.Text));
            foreach (Clases.Clientes.Paciente p in lista)
            {
                txtnombre.Text = p.Nombre;
                txtapellido.Text = p.Apellido;
                txtdireccion.Text = p.Direccion;
                txttelefono.Text = p.Telefono.ToString();
            }
        }

        protected void btnacepatar_Click(object sender, ImageClickEventArgs e)
        {
            //CREA UNA EXTRACCION
            Clases.Extracciones.Extraccion datos = new Clases.Extracciones.Extraccion();
            datos.NombrePaciente = txtnombre.Text;
            datos.ApePaciente = txtapellido.Text;
            datos.CedPaciente = Convert.ToInt32(txtcedula.Text);
            datos.DirPaciente = txtdireccion.Text;
            datos.TelPaciente = Convert.ToInt32(txttelefono.Text);
            datos.TipoAnalisis = ddlanalisis.SelectedValue;
            datos.Muestra = txtmuestra.Text;
            datos.FechaExtraccion = Convert.ToDateTime(txtfec.Text);
            datos.Estado = "Extraido";
            Clases.Extracciones.Extraccion.guardar(datos);

            //CREA UNA MUESTRA
            Clases.Muestra datoMuestra = new Clases.Muestra();
            datoMuestra.CedulaPaciente = Convert.ToInt32(txtcedula.Text);
            datoMuestra.TipoMuestra = txtmuestra.Text;
            datoMuestra.Estado = "Pendiente";
            datoMuestra.FechaMuestra = Convert.ToDateTime(txtfec.Text);
            Clases.Muestra.guardar(datoMuestra);

            limpiar();
        }

        public void limpiar()
        {
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtfec.Text = "";
            txtmuestra.Text = "";
            ddlanalisis.SelectedIndex = 0;
        }

        protected void ddlanalisis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlid.SelectedIndex = ddlanalisis.SelectedIndex;
            string seleccion = ddlanalisis.SelectedValue;
            if (ddlanalisis.SelectedValue == "Seleccione")
                txtmuestra.Text = "";
            List<Clases.Referencias.Referencia> lista = Clases.Referencias.Referencia.mostrar();
            foreach (Clases.Referencias.Referencia r in lista)
            {
                if (seleccion == r.Analisis)
                    txtmuestra.Text = r.Muestra;
            }
        }

        protected void ddlid_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlid.SelectedIndex = ddlanalisis.SelectedIndex;
        }

        protected void btnfecha_Click(object sender, EventArgs e)
        {
            txtfec.Text = DateTime.Now.Day + "/"+ DateTime.Now.Month + "/" + DateTime.Now.Year;
        }
    }
}