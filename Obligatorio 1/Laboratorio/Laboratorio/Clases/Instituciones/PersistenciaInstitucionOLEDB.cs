using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Instituciones
{
    public class PersistenciaInstitucionOLEDB : FachadaInstitucion
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Institucion obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into Institucion (nombre, direccion, telefono, email) values (@nom, @dir, @tel, @em)", conexion);
            cmdInsert.Parameters.AddWithValue("@nom",obj.Nombre);
            cmdInsert.Parameters.AddWithValue("@dir", obj.Direccion);
            cmdInsert.Parameters.AddWithValue("@tel", obj.Telefono);
            cmdInsert.Parameters.AddWithValue("@em", obj.Email);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Institucion> mostar()
        {
            List<Institucion> lista = new List<Institucion>(); 
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdMostar = new OleDbCommand("select id, nombre, email From Institucion", conexion);
            OleDbDataReader datos = cmdMostar.ExecuteReader();
            while (datos.Read())
            {
                Institucion i = new Institucion();
                i.Id = Convert.ToInt32(datos["id"]);
                i.Nombre = datos["nombre"].ToString();
                i.Email = datos["email"].ToString();
                lista.Add(i);
            }
            conexion.Close();
            return lista;
        }
    }
}