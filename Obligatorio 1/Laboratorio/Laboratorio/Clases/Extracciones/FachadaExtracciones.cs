using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio.Clases.Extracciones
{
    public abstract class FachadaExtracciones
    {
        public abstract void guardar(Extraccion obj);
        public abstract List<Extraccion> mostrar();
        public abstract void modificar(int ced, string est);
    }
}