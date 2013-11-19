using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Empleados
{
    public class PersitenciaEmpleadoOLEDB : FachadaEmpleado
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Empleado obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Empleado (nombre, apellido, cedula, fecha_nacimiento, direccion, telefono, email, usuario, contraseña, estado) values (@nom, @ape, @ced, @fec, @dir, @tel, @em ,@usu, @cont, @es)", conexion);
            cmdInsert.Parameters.AddWithValue("@nom",obj.Nombre);
            cmdInsert.Parameters.AddWithValue("@ape",obj.Apellido);
            cmdInsert.Parameters.AddWithValue("@ced",obj.Cedula);
            OleDbParameter parfec = cmdInsert.Parameters.Add("@fec", OleDbType.DBDate);
            parfec.Value = obj.FechaNacimiento;
            cmdInsert.Parameters.AddWithValue("@dir",obj.Direccion);
            cmdInsert.Parameters.AddWithValue("@tel",obj.Telefono);
            cmdInsert.Parameters.AddWithValue("@em",obj.Email); 
            cmdInsert.Parameters.AddWithValue("@usu",obj.Usuario);
            cmdInsert.Parameters.AddWithValue("@pass",obj.Contraseña);
            cmdInsert.Parameters.AddWithValue("@es",obj.Estado);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Empleado> buscarPorCedula(int ci)
        {
            List<Empleado> lista = new List<Empleado>();
            OleDbConnection conexion = crearConexion();
            OleDbCommand comando = new OleDbCommand("select nombre, apellido, telefono, direccion, email, usuario, contraseña, estado from empleado where cedula=@cedula", conexion);
            comando.Parameters.AddWithValue("@cedula", ci);
            OleDbDataReader datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Empleado e = new Empleado();
                e.Nombre = datos["nombre"].ToString();
                e.Apellido = datos["apellido"].ToString();
                e.Telefono = Convert.ToInt32(datos["telefono"]);
                e.Direccion = datos["direccion"].ToString();
                e.Email = datos["email"].ToString();
                e.Usuario = datos["usuario"].ToString();
                e.Contraseña = datos["contraseña"].ToString();
                e.Estado = datos["estado"].ToString();
                lista.Add(e);
            }
            return lista;
        }

        public override void modificar(int ced, string dir, int tel, string mail, string usu, string cont, string est)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("update empleado set telefono=@tel, direccion=@dir, email=@email, usuario=@usu, contraseña=@cont, estado=@est where cedula=@cedula", conexion);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@dir", dir);
            cmd.Parameters.AddWithValue("@email", mail);
            cmd.Parameters.AddWithValue("@usu", usu);
            cmd.Parameters.AddWithValue("@cont", cont);
            cmd.Parameters.AddWithValue("@est", est);
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.ExecuteNonQuery();
        }
    }
}