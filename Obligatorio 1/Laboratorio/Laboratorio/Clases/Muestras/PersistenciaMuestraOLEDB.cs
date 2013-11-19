using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Muestras
{
    public class PersistenciaMuestraOLEDB : FachadaMuestra
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Muestra obj)
        {

            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Muestra (estado, cedula_paciente, tipo_muestra, fecha) values (@es, @ced, @tip, @fec)", conexion);
            cmdInsert.Parameters.AddWithValue("@es", obj.Estado);
            cmdInsert.Parameters.AddWithValue("@ced", obj.CedulaPaciente);
            cmdInsert.Parameters.AddWithValue("@tip", obj.TipoMuestra);
            cmdInsert.Parameters.AddWithValue("@fec", obj.FechaMuestra);
            cmdInsert.ExecuteNonQuery();
        }

        public override void modificar(int ced, string est)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("update muestra set estado=@est where cedula=@cedula", conexion);
            cmd.Parameters.AddWithValue("@est", est);
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.ExecuteNonQuery();
        }
    }
}