using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Paginas
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        public static string usu;
        public static string cont;
        public static string ape;
        public static string nom;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btniniciar_Click(object sender, EventArgs e)
        {
            string u = txtusu.Text;
            string c = txtcont.Text;

            bool enocntrado = false;

            List<Clases.Laboratorista> lista = Clases.Laboratorista.buscarUsuario();
            foreach (Clases.Laboratorista l in lista)
            {
                if (l.Usuario == u)
                {
                    if (l.Contraseña == c)
                    {
                        enocntrado = true;
                        nom = l.Nombre;
                        ape = l.Apellido;
                        usu = l.Usuario;
                        cont = l.Contraseña;
                    }
                }
            }

            if (enocntrado == true)
            {
                Session["Laboratorista"] = "Laboratorista";
                //HACE VISIBLE EL MENU DE LABORATORISTA
                Master.FindControl("Menu1").Visible = true;
                txtsesion.Text = nom+" "+ape;
                txtusu.Text = "";
            }
            else
            {
                txtcont.Text = "";
                txtusu.Text = "";
                lblerror.Text = "Usuario Incorrecto";
            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Clases.Analisis> lista = Clases.Analisis.mostrarAnalisis();
            foreach (Clases.Analisis a in lista)
            {
                if (Convert.ToInt32(txtcedula.Text) == a.CedPaciente && a.Estado == "No pago")
                {
                    lblinfo.Text = a.NomPaciente + " " + a.ApePaciente + " .Analisis de " + a.TipoAnalisis + " .Hecho el " + a.FechaAnalisis;
                }
                else
                    lblinfo.Text = "No hay analisis pendientes de pagos";
            }
        }

        protected void btnpago_Click(object sender, EventArgs e)
        {
            string pago = "Pago";
            Clases.Analisis.modificar(Convert.ToInt32(txtcedula.Text), pago);
            txtcedula.Text = "";
            lblinfo.Text = "";
        }
    }
}