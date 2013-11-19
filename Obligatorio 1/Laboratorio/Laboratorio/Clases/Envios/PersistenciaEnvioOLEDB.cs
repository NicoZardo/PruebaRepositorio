using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;


namespace Laboratorio.Clases.Envios
{
    public class PersistenciaEnvioOLEDB : FachadaEnvio
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Envio obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Emails (email, fecha_envio, concepto, estado) values (@em, @fec, @con, @es)", conexion);
            cmdInsert.Parameters.AddWithValue("@em", obj.Email);
            cmdInsert.Parameters.AddWithValue("@fec", obj.FechaEnvio);
            cmdInsert.Parameters.AddWithValue("@con", obj.Concepto);
            cmdInsert.Parameters.AddWithValue("@es", obj.Estado);
            cmdInsert.ExecuteNonQuery();
        }
    }
}