using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas.Paginas_Laboratoristas
{
    public partial class PaginaInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
            if (!IsPostBack)
            {
                ddlcedula.Items.Add("Seleccione");
                List<Clases.Laboratorista> lista = Clases.Laboratorista.buscarUsuario();
                foreach (Clases.Laboratorista l in lista)
                {
                    ddlcedula.Items.Add(l.Cedula.ToString());
                }
            }
        }

        protected void btncantserv_Click(object sender, EventArgs e)
        {
            List<Clases.Analisis> lista = Clases.Analisis.mostrarAnalisis();
            int cantidad = lista.Count();
            lblinfo1.Text = "EL laboratorio ha hecho "+cantidad+" analisis.";
        }

        protected void btntotalcobrado_Click(object sender, EventArgs e)
        {
            int cobradoI = 0;
            int cobradoP = 0;
            List<Clases.Analisis> lista = Clases.Analisis.mostrarAnalisis();
            foreach (Clases.Analisis a in lista)
            {
                if (a.TipoPaciente == "Afiliado")
                    cobradoI = cobradoI + a.PrecioTotal;
                else
                    cobradoP = cobradoP + a.PrecioTotal;
            }
            lblinfo2.Text = "Total cobrado a Instituciones: " + cobradoI + ". Total cobrado a particulares: " + cobradoP;
        }

        protected void btnemp_Click(object sender, EventArgs e)
        {

        }

        protected void btncosto_Click(object sender, EventArgs e)
        {
            int costo = 0;
            DateTime desde = Convert.ToDateTime(txtdesdecosto.Text);
            DateTime hasta = Convert.ToDateTime(txthastacosto.Text);
            List<Clases.Analisis> lista = Clases.Analisis.mostrarAnalisis();
            List<Clases.Analisis> listaA = new List<Clases.Analisis>();
            foreach (Clases.Analisis a in lista)
            {
                if (a.FechaAnalisis >= desde && a.FechaAnalisis <= hasta)
                {
                    listaA.Add(a);
                }
            }
            foreach (Clases.Analisis an in listaA)
            {
                costo = costo + an.CostoMateriales;
            }
            lblinfo4.Text = "EL costo total de materiales es " + costo;
        }

        protected void ddlcedula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}