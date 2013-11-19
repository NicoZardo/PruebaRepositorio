using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas.Paginas_Laboratoristas
{
    public partial class Analisis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
            if(!IsPostBack)
            {
                ddlextraccion.Items.Add("Seleccione");
                ddlid.Items.Add("Seleccione");
                List<Clases.Extracciones.Extraccion> lista = Clases.Extracciones.Extraccion.mostrar();
                foreach (Clases.Extracciones.Extraccion ex in lista)
                {
                    if (ex.Estado != "Analizado")
                    {
                        ddlextraccion.Items.Add(ex.TipoAnalisis+", "+ex.CedPaciente);
                        ddlid.Items.Add(ex.Id.ToString());
                    }
                }
            }
        }

        protected void ddlextraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlid.SelectedIndex = ddlextraccion.SelectedIndex;
            List<Clases.Extracciones.Extraccion> lista = Clases.Extracciones.Extraccion.mostrar();
            foreach (Clases.Extracciones.Extraccion ex in lista)
            {
                if(ex.Id == Convert.ToInt32(ddlid.SelectedValue))
                {
                    txtnombre.Text = ex.NombrePaciente.ToString();
                    txtapellido.Text = ex.ApePaciente.ToString();
                    txtcedula.Text = ex.CedPaciente.ToString();
                    txtanalisis.Text = ex.TipoAnalisis.ToString();
                }
            }
        }

        protected void ddlid_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlid.SelectedIndex = ddlextraccion.SelectedIndex;
        }

        protected void btnaceptar_Click(object sender, ImageClickEventArgs e)
        {
            if (Clases.Referencias.Referencia.verificar(Convert.ToDecimal(txtresultado.Text), txtanalisis.Text) == false)
            {
                txtresultado.Text = "";
                lblmensaje.Text = "Ingreso incorrecto, verifique";
            }
            else
            {
                int cedulaUsuario=0;
                string a = PaginaPrincipal.usu;
                string b = PaginaPrincipal.cont;
                
                List<Clases.Laboratorista> lista = Clases.Laboratorista.buscarUsuario();
                foreach (Clases.Laboratorista l in lista)
                {
                    if (l.Usuario == a && l.Contraseña == b)
                        cedulaUsuario = l.Cedula;            
                }
                Clases.Analisis datos = new Clases.Analisis();
                datos.NomPaciente = txtnombre.Text;
                datos.ApePaciente = txtapellido.Text;
                datos.CedPaciente = Convert.ToInt32(txtcedula.Text);
                datos.TipoAnalisis = txtanalisis.Text;
                datos.FechaAnalisis = Convert.ToDateTime(txtfecha.Text);
                datos.Resultado = Convert.ToDecimal(txtresultado.Text);
                datos.PrecioAnalisis = Convert.ToInt32(txtprecioanalisis.Text);
                datos.CostoMateriales = Convert.ToInt32(txtmateriales.Text);
                datos.PrecioTotal = Convert.ToInt32(txttotal.Text);
                datos.Estado = "No pago";
                datos.CedulaUsuario = cedulaUsuario;
                string est = "Analizado";
                datos.TipoPaciente = txtestado.Text;
                Clases.Analisis.guardar(datos);
                Clases.Extracciones.Extraccion.modificar(Convert.ToInt32(txtcedula.Text), est);
                Clases.Muestra.modificar(Convert.ToInt32(txtcedula.Text), est);
                limpiar();
            }
        }
        public void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcedula.Text = "";
            txtanalisis.Text = "";
            txtfecha.Text = "";
            txtprecioanalisis.Text = "";
            txtresultado.Text = "";
            txtmateriales.Text = "";
            txttotal.Text = "";
            ddlextraccion.SelectedIndex = 0;
            ddlid.SelectedIndex = 0;
        }

        protected void btnfecha_Click(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            int c=Convert.ToInt32(txtcedula.Text);
            bool encontrado = false;

            List<Clases.Clientes.Paciente> listaP = Clases.Clientes.Paciente.buscarPorCedula(c);
            foreach (Clases.Clientes.Paciente p in listaP)
            {
                if (p.Filiacion != "No")
                    encontrado = true;
            }
            List<Clases.Referencias.Referencia> lista = Clases.Referencias.Referencia.mostrar();
            foreach (Clases.Referencias.Referencia r in lista)
            {
                if (r.Analisis == txtanalisis.Text && encontrado == false)
                {
                    txtprecioanalisis.Text = r.PrecioPart.ToString();
                    txtestado.Text = "Particular";
                }
                else
                {
                    txtprecioanalisis.Text = r.PrecioInst.ToString();
                    txtestado.Text = "Afiliado";
                }                 
            }
        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            if (txtestado.Text == "Particular")
                suma = Convert.ToInt32(txtmateriales.Text) + Convert.ToInt32(txtprecioanalisis.Text);
            else
                suma = (Convert.ToInt32(txtprecioanalisis.Text) * 28 )+ Convert.ToInt32(txtmateriales.Text);
            txttotal.Text = suma.ToString();
        }
    }
}