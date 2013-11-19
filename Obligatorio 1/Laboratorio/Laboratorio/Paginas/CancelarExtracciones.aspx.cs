using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas
{
    public partial class CancelarExtracciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Clases.Extracciones.Extraccion> lista = Clases.Extracciones.Extraccion.mostrar();
            foreach (Clases.Extracciones.Extraccion ex in lista)
            {
                if(ex.Estado!="Cancelado")
                    lblinfo.Text = "Extraccion para "+ex.NombrePaciente+" "+ex.ApePaciente+". Analisis de "+ex.TipoAnalisis+", extraida el "+ex.FechaExtraccion;
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            int ced=Convert.ToInt32(txtcedula.Text);
            string estado = "Cancelado";
            Clases.Extracciones.Extraccion.modificar(ced, estado);
            Clases.Muestra.modificar(ced, estado);
            limpiar();
        }

        public void limpiar()
        {
            txtcedula.Text = "";
            lblinfo.Text = "";
        }
    }
}