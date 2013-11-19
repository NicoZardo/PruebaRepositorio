using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Clientes
{
    public class PersistenciaClienteOLEDB : FachadaPaciente
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Paciente obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Paciente (nombre, apellido, cedula, fecha_nacimiento, telefono, direccion, email, filiacion, estado) values (@nom, @ape, @ced, @fec, @tel, @dir, @email, @fil, @est)", conexion);
            cmdInsert.Parameters.AddWithValue("@nom", obj.Nombre);
            cmdInsert.Parameters.AddWithValue("@ape", obj.Apellido);
            cmdInsert.Parameters.AddWithValue("@ced", obj.Cedula);
            OleDbParameter parfec = cmdInsert.Parameters.Add("@fec", OleDbType.DBDate);
            parfec.Value = obj.FechaNacimiento;
            cmdInsert.Parameters.AddWithValue("@tel", obj.Telefono);
            cmdInsert.Parameters.AddWithValue("@dir", obj.Direccion);
            cmdInsert.Parameters.AddWithValue("@email", obj.Email);
            cmdInsert.Parameters.AddWithValue("@fil", obj.Filiacion);
            cmdInsert.Parameters.AddWithValue("@est", obj.Estado);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Paciente> buscarPorCedula(int ci)
        {
            List<Paciente> lista = new List<Paciente>();
            OleDbConnection conexion = crearConexion();
            OleDbCommand comando = new OleDbCommand("select nombre, apellido, telefono, direccion, filiacion, email, estado from paciente where cedula=@cedula", conexion);
            comando.Parameters.AddWithValue("@cedula", ci);
            OleDbDataReader datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Paciente p = new Paciente();
                p.Nombre = datos["nombre"].ToString();
                p.Apellido = datos["apellido"].ToString();
                p.Direccion = datos["direccion"].ToString();
                p.Telefono = Convert.ToInt32(datos["telefono"]);
                p.Email = datos["email"].ToString();
                p.Filiacion = datos["filiacion"].ToString();
                p.Estado = datos["estado"].ToString();
                lista.Add(p);
            }
            return lista;
        }

        public override void modificar(int ced, string dir, int tel, string mail, string fil, string est)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("update paciente set telefono=@tel, direccion=@dir, email=@email, filiacion=@fil, estado=@est where cedula=@cedula", conexion); 
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@dir", dir);
            cmd.Parameters.AddWithValue("@email", mail);
            cmd.Parameters.AddWithValue("@fil", fil);
            cmd.Parameters.AddWithValue("@est", est);
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.ExecuteNonQuery();
        }
    }
}