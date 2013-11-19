using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Extracciones
{
    public class PersistenciaExtraccionOLEDB : FachadaExtracciones
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Extraccion obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Extracciones (fecha_extraccion, nombre_paciente, apellido_paciente, cedula, telefono, direccion, tipo_analisis, muestra, estado) values (@fec, @nom, @ape, @ced, @tel, @dir, @ana ,@mue, @es)", conexion);
            OleDbParameter parfec = cmdInsert.Parameters.Add("@fec", OleDbType.DBDate);
            parfec.Value = obj.FechaExtraccion;
            cmdInsert.Parameters.AddWithValue("@nom",obj.NombrePaciente);
            cmdInsert.Parameters.AddWithValue("@ape",obj.ApePaciente);
            cmdInsert.Parameters.AddWithValue("@ced",obj.CedPaciente);
            cmdInsert.Parameters.AddWithValue("@tel", obj.TelPaciente);
            cmdInsert.Parameters.AddWithValue("@dir",obj.DirPaciente);
            cmdInsert.Parameters.AddWithValue("@ana",obj.TipoAnalisis); 
            cmdInsert.Parameters.AddWithValue("@mue",obj.Muestra);
            cmdInsert.Parameters.AddWithValue("@es",obj.Estado);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Extraccion> mostrar()
        {
            List<Extraccion> lista = new List<Extraccion>(); ;
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdMostar = new OleDbCommand("select id, nombre_paciente, apellido_paciente, cedula, tipo_analisis, estado from extracciones", conexion);
            OleDbDataReader datos = cmdMostar.ExecuteReader();
            while (datos.Read())
            {
                Extraccion e = new Extraccion();
                e.Id = Convert.ToInt32(datos["id"]);
                e.NombrePaciente = datos["nombre_Paciente"].ToString();
                e.ApePaciente=datos["apellido_Paciente"].ToString();
                e.CedPaciente = Convert.ToInt32(datos["cedula"]);
                e.TipoAnalisis = datos["tipo_Analisis"].ToString();
                e.Estado = datos["estado"].ToString();
                lista.Add(e);
            }
            conexion.Close();
            return lista;
        }

        public override void modificar(int ced, string est)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("update extracciones set estado=@est where cedula=@cedula", conexion);
            cmd.Parameters.AddWithValue("@est", est);
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.ExecuteNonQuery();
        }
    }
}