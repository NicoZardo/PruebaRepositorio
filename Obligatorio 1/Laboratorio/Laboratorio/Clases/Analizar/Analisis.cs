using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases
{
    public class Analisis
    {
        private string nomPaciente;

        public string NomPaciente
        {
            get { return nomPaciente; }
            set { nomPaciente = value; }
        }
        private string apePaciente;

        public string ApePaciente
        {
            get { return apePaciente; }
            set { apePaciente = value; }
        }
        private int cedPaciente;

        public int CedPaciente
        {
            get { return cedPaciente; }
            set { cedPaciente = value; }
        }
        private DateTime fechaAnalisis;

        public DateTime FechaAnalisis
        {
            get { return fechaAnalisis; }
            set { fechaAnalisis = value; }
        }
        private string tipoAnalisis;

        public string TipoAnalisis
        {
            get { return tipoAnalisis; }
            set { tipoAnalisis = value; }
        }
        private Decimal resultado;

        public Decimal Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
        private int precioAnalisis;

        public int PrecioAnalisis
        {
            get { return precioAnalisis; }
            set { precioAnalisis = value; }
        }
        private int precioTotal;

        public int PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private int costoMateriales;

        public int CostoMateriales
        {
            get { return costoMateriales; }
            set { costoMateriales = value; }
        }
        private int cedulaUsuario;

        public int CedulaUsuario
        {
            get { return cedulaUsuario; }
            set { cedulaUsuario = value; }
        }
        private string tipoPaciente;

        public string TipoPaciente
        {
            get { return tipoPaciente; }
            set { tipoPaciente = value; }
        }

        private static Clases.Analizar.FachadaAnalisis persist = new Clases.Analizar.PersistenciaAnalisisOLEDB();
        public static void guardar(Analisis obj)
        {
            persist.guardar(obj);
        }
        public static List<Analisis> mostrarAnalisis()
        {
            return persist.mostrarAnalisis();
        }
        public static void modificar(int ced, string est)
        {
            persist.modificar(ced, est);
        }
    }
}