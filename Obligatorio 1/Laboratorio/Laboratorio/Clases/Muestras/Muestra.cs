using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases
{
    public class Muestra
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private int cedulaPaciente;

        public int CedulaPaciente
        {
            get { return cedulaPaciente; }
            set { cedulaPaciente = value; }
        }
        private string tipoMuestra;

        public string TipoMuestra
        {
            get { return tipoMuestra; }
            set { tipoMuestra = value; }
        }

        private DateTime fechaMuestra;

        public DateTime FechaMuestra
        {
            get { return fechaMuestra; }
            set { fechaMuestra = value; }
        }
        private static Clases.Muestras.FachadaMuestra persist = new Clases.Muestras.PersistenciaMuestraOLEDB();

        public static void guardar(Muestra obj)
        {
            persist.guardar(obj);
        }
        public static void modificar(int ced, string est)
        {
            persist.modificar(ced, est);
        }
    }
}