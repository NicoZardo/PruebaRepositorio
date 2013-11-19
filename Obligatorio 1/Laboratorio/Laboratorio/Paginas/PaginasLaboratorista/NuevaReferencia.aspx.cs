using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas.PaginasLaboratorista
{
    public partial class NuevaReferencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("Menu1").Visible = true;
        }

        protected void btnacepatar_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Referencias.Referencia datos = new Clases.Referencias.Referencia();
            datos.Analisis = txtanalisis.Text;
            datos.Muestra = txtmuestra.Text;
            datos.Unidades = txtunidad.Text;
            datos.RefMin = Convert.ToDecimal(txtrefmin.Text);
            datos.RefMax = Convert.ToDecimal(txtrefmax.Text);
            datos.ErrorMin = Convert.ToDecimal(txterrormin.Text);
            datos.ErrorMax = Convert.ToDecimal(txterrormax.Text);
            datos.PrecioInst = Convert.ToInt32(txtprecioIns.Text);
            datos.PrecioPart = Convert.ToInt32(txtprecioPart.Text);
            Clases.Referencias.Referencia.guardar(datos);
            limpiar();
        }
        public void limpiar()
        {
            txtanalisis.Text = "";
            txtmuestra.Text = "";
            txtunidad.Text = "";
            txtrefmin.Text = "";
            txtrefmax.Text = "";
            txterrormin.Text = "";
            txterrormax.Text = "";
            txtprecioIns.Text = "";
            txtprecioPart.Text = "";
        }
    }
}