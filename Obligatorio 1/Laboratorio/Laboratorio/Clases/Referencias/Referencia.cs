using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Referencias
{
    public class Referencia
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string analisis;

        public string Analisis
        {
            get { return analisis; }
            set { analisis = value; }
        }
        private string muestra;

        public string Muestra
        {
            get { return muestra; }
            set { muestra = value; }
        }
        private string unidades;

        public string Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
        private Decimal refMin;

        public Decimal RefMin
        {
            get { return refMin; }
            set { refMin = value; }
        }
        private Decimal refMax;

        public Decimal RefMax
        {
            get { return refMax; }
            set { refMax = value; }
        }
        private Decimal errorMin;

        public Decimal ErrorMin
        {
            get { return errorMin; }
            set { errorMin = value; }
        }
        private Decimal errorMax;

        public Decimal ErrorMax
        {
            get { return errorMax; }
            set { errorMax = value; }
        }
        private int precioInst;

        public int PrecioInst
        {
            get { return precioInst; }
            set { precioInst = value; }
        }
        private int precioPart;

        public int PrecioPart
        {
            get { return precioPart; }
            set { precioPart = value; }
        }

        private static Clases.Referencias.FachadaReferencia persist = new Clases.Referencias.PersistenciaReferenciaOLEDB();
        public static void guardar(Referencia obj)
        {
            persist.guardar(obj);
        }
        public static List<Referencia> mostrar()
        {
            return persist.mostrar();
        }
        public static bool verificar(Decimal resultado, string analisis)
        {
            return persist.verificar(resultado, analisis);
        }
    }
}