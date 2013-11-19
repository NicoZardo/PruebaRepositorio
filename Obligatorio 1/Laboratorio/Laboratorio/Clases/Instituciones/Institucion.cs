using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases
{
    public class Institucion
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private static Clases.Instituciones.FachadaInstitucion persist = new Clases.Instituciones.PersistenciaInstitucionOLEDB();
        public static void guardar(Institucion obj)
        {
            persist.guardar(obj);
        }
        public static List<Institucion> mostrar()
        {
            return persist.mostar();
        }
    }
}