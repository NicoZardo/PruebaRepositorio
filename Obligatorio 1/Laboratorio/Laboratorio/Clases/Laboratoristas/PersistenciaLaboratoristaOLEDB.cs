using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Laboratoristas
{
    public class PersistenciaLaboratoristaOLEDB : FachadaLaboratorista
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Laboratorista obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Laboratorista (nombre, apellido, cedula, fecha_nacimiento, telefono, direccion, email, usuario, contraseña, estado) values (@nom, @ape, @ced, @fec, @dir, @tel, @em ,@usu, @cont, @es)", conexion);
            cmdInsert.Parameters.AddWithValue("@nom", obj.Nombre);
            cmdInsert.Parameters.AddWithValue("@ape", obj.Apellido);
            cmdInsert.Parameters.AddWithValue("@ced", obj.Cedula);
            OleDbParameter parfec = cmdInsert.Parameters.Add("@fec", OleDbType.DBDate);
            parfec.Value = obj.FechaNacimiento;
            cmdInsert.Parameters.AddWithValue("@tel", obj.Telefono);
            cmdInsert.Parameters.AddWithValue("@dir", obj.Direccion);
            cmdInsert.Parameters.AddWithValue("@em", obj.Email);
            cmdInsert.Parameters.AddWithValue("@usu", obj.Usuario);
            cmdInsert.Parameters.AddWithValue("@cont", obj.Contraseña);
            cmdInsert.Parameters.AddWithValue("@es", obj.Estado);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Laboratorista> buscarUsuario()
        {
            List<Laboratorista> lista = new List<Laboratorista>();
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("select usuario, contraseña, nombre, apellido, cedula from laboratorista", conexion);
            OleDbDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Laboratorista l = new Laboratorista();
                l.Usuario = datos["usuario"].ToString();
                l.Contraseña = datos["contraseña"].ToString();
                l.Nombre = datos["nombre"].ToString();
                l.Apellido = datos["apellido"].ToString();
                l.Cedula = Convert.ToInt32(datos["cedula"]);
                lista.Add(l);
            }
            return lista;
        }
    }
}