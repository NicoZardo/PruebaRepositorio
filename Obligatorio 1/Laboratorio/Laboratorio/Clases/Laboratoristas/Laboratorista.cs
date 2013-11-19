using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases
{
    public class Laboratorista
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private static Clases.Laboratoristas.FachadaLaboratorista persist = new Clases.Laboratoristas.PersistenciaLaboratoristaOLEDB();

        public static void guardar(Laboratorista obj)
        {
            persist.guardar(obj);
        }
        public static List<Laboratorista> buscarUsuario()
        {
            return persist.buscarUsuario();
        }
    }
}