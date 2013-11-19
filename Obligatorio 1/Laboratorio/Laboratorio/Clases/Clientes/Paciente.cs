using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Clientes
{
    public class Paciente
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string filiacion;

        public string Filiacion
        {
            get { return filiacion; }
            set { filiacion = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private static Clases.Clientes.FachadaPaciente persist = new Clases.Clientes.PersistenciaClienteOLEDB();
        public static void guardar(Paciente obj)
        {
            persist.guardar(obj);
        }
        public static List<Paciente> buscarPorCedula(int ci)
        {
            return persist.buscarPorCedula(ci);
        }
        public static void modificar(int ced, string dir, int tel, string mail, string fil, string est)
        {
            persist.modificar(ced, dir, tel, mail, fil, est);
        }
    }
}