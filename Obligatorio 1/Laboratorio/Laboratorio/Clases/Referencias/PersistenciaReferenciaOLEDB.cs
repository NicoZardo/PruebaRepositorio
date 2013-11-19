using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Referencias
{
    public class PersistenciaReferenciaOLEDB : FachadaReferencia
    {
        public static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=" + HttpRuntime.AppDomainAppPath + "BDLab.accdb" + "");
            conexion.Open();
            return conexion;
        }

        public override void guardar(Referencia obj)
        {
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdInsert = new OleDbCommand("insert into [Analisis Referencia] (analisis, muestra, unidades, referencia_min, referencia_max, error_min, error_max, precio_institucion, precio_particular) values (@ana, @mue, @uni, @refmin, @refMax, @errormin, @errorMax, @preI, @preP)", conexion);
            cmdInsert.Parameters.AddWithValue("@ana", obj.Analisis);
            cmdInsert.Parameters.AddWithValue("@mue", obj.Muestra);
            cmdInsert.Parameters.AddWithValue("@uni", obj.Unidades);
            cmdInsert.Parameters.AddWithValue("@refmin", obj.RefMin);
            cmdInsert.Parameters.AddWithValue("@refMax", obj.RefMax);
            cmdInsert.Parameters.AddWithValue("@errormin", obj.ErrorMin);
            cmdInsert.Parameters.AddWithValue("@errorMax", obj.ErrorMax);
            cmdInsert.Parameters.AddWithValue("@preI", obj.PrecioInst);
            cmdInsert.Parameters.AddWithValue("@preP", obj.PrecioPart);
            cmdInsert.ExecuteNonQuery();
        }

        public override List<Referencia> mostrar()
        {
            List<Referencia> lista = new List<Referencia>(); ;
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmdMostrar = new OleDbCommand("select id, analisis, muestra, precio_particular, precio_institucion from [analisis referencia]", conexion);
            OleDbDataReader datos = cmdMostrar.ExecuteReader();
            while (datos.Read())
            {
                Referencia r = new Referencia();
                r.Id = Convert.ToInt32(datos["id"]);
                r.Analisis = datos["analisis"].ToString();
                r.Muestra = datos["muestra"].ToString();
                r.PrecioPart = Convert.ToInt32(datos["precio_Particular"]);
                r.PrecioInst = Convert.ToInt32(datos["precio_Institucion"]);
                lista.Add(r);
            }
            conexion.Close();
            return lista;
        }

        public override bool verificar(Decimal resultado, string analisis)
        {
            bool confirm = false;
            OleDbConnection conexion = crearConexion();
            OleDbCommand cmd = new OleDbCommand("select id, referencia_min, referencia_max, error_min, error_max from [analisis referencia] where analisis=@analisis", conexion);
            cmd.Parameters.AddWithValue("@analisis", analisis);
            OleDbDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Referencia r = new Referencia();
                r.Id = Convert.ToInt32(datos["id"]);
                //r.Analisis = datos["analisis"].ToString();
                r.ErrorMin = Convert.ToInt32(datos["error_min"]);
                r.RefMin = Convert.ToInt32(datos["referencia_min"]);
                r.RefMax = Convert.ToInt32(datos["referencia_max"]);
                r.ErrorMax = Convert.ToInt32(datos["error_max"]);

                if (resultado < r.ErrorMin)
                {
                    confirm = false;
                    return confirm;
                }
                else if (resultado >= r.ErrorMin && resultado < r.RefMin)
                {
                    confirm = true;
                    return confirm;
                }
                else if (resultado >= r.RefMin && resultado <= r.RefMax)
                {
                    confirm = true;
                    return confirm;
                }
                else if (resultado > r.RefMax && resultado <= r.ErrorMax)
                {
                    confirm = true;
                    return confirm;
                }
                else if (resultado > r.ErrorMax)
                {
                    confirm = false;
                    return confirm;
                }
            }
        return confirm;
        }
    }
}