using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Extracciones
{
    public class Extraccion
    {
        private string nombrePaciente;

        public string NombrePaciente
        {
            get { return nombrePaciente; }
            set { nombrePaciente = value; }
        }
        private string apePaciente;

        public string ApePaciente
        {
            get { return apePaciente; }
            set { apePaciente = value; }
        }
        private int telPaciente;

        public int TelPaciente
        {
            get { return telPaciente; }
            set { telPaciente = value; }
        }
        private int cedPaciente;

        public int CedPaciente
        {
            get { return cedPaciente; }
            set { cedPaciente = value; }
        }
        private string dirPaciente;

        public string DirPaciente
        {
            get { return dirPaciente; }
            set { dirPaciente = value; }
        }
        private DateTime fechaExtraccion;

        public DateTime FechaExtraccion
        {
            get { return fechaExtraccion; }
            set { fechaExtraccion = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string tipoAnalisis;

        public string TipoAnalisis
        {
            get { return tipoAnalisis; }
            set { tipoAnalisis = value; }
        }
        private string muestra;

        public string Muestra
        {
            get { return muestra; }
            set { muestra = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private static Clases.Extracciones.FachadaExtracciones persist = new Clases.Extracciones.PersistenciaExtraccionOLEDB();
        public static void guardar(Extraccion obj)
        {
            persist.guardar(obj);
        }
        public static List<Extraccion> mostrar()
        {
            return persist.mostrar();
        }
        public static void modificar(int ced, string est)
        {
            persist.modificar(ced, est);
        }
    }
}