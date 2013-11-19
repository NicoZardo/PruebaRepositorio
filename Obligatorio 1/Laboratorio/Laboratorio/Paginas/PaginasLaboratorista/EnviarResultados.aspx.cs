using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Laboratorio.Paginas.PaginasLaboratorista
{
    public partial class EnviarResultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlanalisis.Items.Add("Seleccione");
                ddlcedula.Items.Add("Seleccione");
                List<Clases.Analisis> listaA = Clases.Analisis.mostrarAnalisis();
                foreach (Clases.Analisis a in listaA)
                {
                    if (a.Estado == "No pago")
                    {
                        ddlcedula.Items.Add(a.CedPaciente.ToString());
                        ddlanalisis.Items.Add(a.NomPaciente+" "+a.ApePaciente+", "+a.CedPaciente+", "+a.TipoAnalisis+", "+a.FechaAnalisis);
                    }
                }
            }
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("nicozardo14@hotmail.com");
            correo.To.Add(txtemail.Text);
            correo.Subject = "Notificacion de Analisis";
            correo.Body = txtmensaje.Text;

            SmtpClient cliente = new SmtpClient("smtp.live.com");
            cliente.Port = 25;
            cliente.Credentials = new System.Net.NetworkCredential("nicozardo14@hotmail.com", "sarandi1576");
            cliente.EnableSsl = true;
            cliente.Send(correo);

            Clases.Envios.Envio datos = new Clases.Envios.Envio();
            datos.Email = txtemail.Text;
            datos.Concepto = txtmensaje.Text;
            datos.Estado = "Enviado";
            datos.FechaEnvio = Convert.ToDateTime(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            Clases.Envios.Envio.guardar(datos);
            limpiar();
        }

        public void limpiar()
        {
            txtemail.Text = "";
            txtmensaje.Text = "";
            lblmensaje.Text = "";
            ddlanalisis.SelectedIndex = 0;
        }

        protected void ddlanalisis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlcedula.SelectedIndex = ddlanalisis.SelectedIndex;
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            //busca si el paciente esta afiliado, si no esta se le notficara que el resultado esta listo, de lo contrario busca la institucion afiliada y le manda un email
            List<Clases.Institucion> listaI = Clases.Institucion.mostrar();
            List<Clases.Clientes.Paciente> listaP = Clases.Clientes.Paciente.buscarPorCedula(Convert.ToInt32(ddlcedula.SelectedValue));
            foreach (Clases.Clientes.Paciente p in listaP)
            {
                if (p.Filiacion == "No")
                {
                    txtemail.Text = p.Email;
                    lblmensaje.Text = "Email para particular";
                    txtmensaje.Text = "Su analisis esta listo para ser levantado";
                }
                else
                {
                    foreach (Clases.Institucion i in listaI)
                    {
                        if (p.Filiacion == i.Nombre)
                        {
                            txtemail.Text = i.Email;
                            lblmensaje.Text = "Email para institucion";
                        }
                    }
                }
            }
            if (lblmensaje.Text == "Email para institucion")
            {
                List<Clases.Analisis> lista = Clases.Analisis.mostrarAnalisis();
                foreach (Clases.Analisis a in lista)
                {
                    if(Convert.ToInt32(ddlcedula.SelectedValue)==a.CedPaciente)
                    {
                        txtmensaje.Text = "El analisis del paciente " + a.NomPaciente + " " + a.ApePaciente + " ,cedula: " + a.CedPaciente
                        + ". Se le ha realizado un analisis de "+a.TipoAnalisis+" el dia "+a.FechaAnalisis+", y dio como resultado "
                        +a.Resultado+" .Quedamos a su disposicion por cualquier consulta.";
                    }
                }
            }
        }

        protected void ddlcedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlcedula.SelectedIndex = ddlanalisis.SelectedIndex;
        }
    }
}