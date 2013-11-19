using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Analizar
{
    public abstract class FachadaAnalisis
    {
        public abstract void guardar(Analisis obj);
        public abstract List<Analisis> mostrarAnalisis();
        public abstract void modificar(int ced, string est);
    }
}