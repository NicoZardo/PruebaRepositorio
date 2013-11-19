using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Envios
{
    public class Envio
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime fechaEnvio;

        public DateTime FechaEnvio
        {
            get { return fechaEnvio; }
            set { fechaEnvio = value; }
        }
        private string concepto;

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private static Clases.Envios.FachadaEnvio persist = new Clases.Envios.PersistenciaEnvioOLEDB();
        public static void guardar(Envio obj)
        {
            persist.guardar(obj);
        }
    }
}