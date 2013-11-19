using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Analizar
{
    public class PersistenciaAnalisisOLEDB : FachadaAnalisis
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Analisis obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into [analisis paciente] (nombre_paciente, apellido_paciente, cedula_paciente, fecha_analisis, tipo_analisis, resultado, precio_analisis, costo_materiales, precio_total, estado, cedula_usuario, tipo_paciente) values (@nom, @ape, @ced, @fec, @tipo, @res, @precioA, @mat, @total, @est, @usuario, @tipoPaciente)", conexion);
            cmdInsert.Parameters.AddWithValue("@nom", obj.NomPaciente);
            cmdInsert.Parameters.AddWithValue("@ape", obj.ApePaciente);
            cmdInsert.Parameters.AddWithValue("@ced", obj.CedPaciente);
            OleDbParameter parfec = cmdInsert.Parameters.Add("@fec", OleDbType.DBDate);
            parfec.Value = obj.FechaAnalisis;
            cmdInsert.Parameters.AddWithValue("@tipo", obj.TipoAnalisis);
            cmdInsert.Parameters.AddWithValue("@res", obj.Resultado);
            cmdInsert.Parameters.AddWithValue("@precioA", obj.PrecioAnalisis);
            cmdInsert.Parameters.AddWithValue("@mat", obj.CostoMateriales);
            cmdInsert.Parameters.AddWithValue("@total", obj.PrecioTotal);
            cmdInsert.Parameters.AddWithValue("@est", obj.Estado);
            cmdInsert.Parameters.AddWithValue("@usuario", obj.CedulaUsuario);
            cmdInsert.Parameters.AddWithValue("@tipoPaciente", obj.TipoPaciente);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Analisis> mostrarAnalisis()
        {
            List<Analisis> lista = new List<Analisis>();
            OleDbConnection conexion = crearConexion();
            OleDbCommand comando = new OleDbCommand("select id, nombre_paciente, apellido_paciente, cedula_paciente, fecha_analisis, tipo_analisis, resultado, precio_total, estado, cedula_usuario, tipo_paciente from [analisis paciente]", conexion);
            OleDbDataReader datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Analisis a = new Analisis();
                a.Id = Convert.ToInt32(datos["id"]);
                a.NomPaciente = datos["nombre_paciente"].ToString();
                a.ApePaciente = datos["apellido_paciente"].ToString();
                a.CedPaciente = Convert.ToInt32(datos["cedula_paciente"]);
                a.FechaAnalisis = Convert.ToDateTime(datos["fecha_analisis"]);
                a.TipoAnalisis = datos["tipo_analisis"].ToString();
                a.Resultado = Convert.ToInt32(datos["resultado"]);
                a.PrecioTotal = Convert.ToInt32(datos["precio_total"]);
                a.Estado = datos["estado"].ToString();
                a.CedulaUsuario = Convert.ToInt32(datos["cedula_usuario"]);
                a.TipoPaciente = datos["tipo_paciente"].ToString();
                lista.Add(a);
            }
            return lista;
        }

        public override void modificar(int ced, string est)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("update [analisis paciente] set estado=@est where cedula=@cedula", conexion);
            cmd.Parameters.AddWithValue("@est", est);
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.ExecuteNonQuery();
        }
    }
}