using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Referencias
{
    public abstract class FachadaReferencia
    {
        public abstract void guardar(Referencia obj);
        public abstract List<Referencia> mostrar();
        public abstract bool verificar(Decimal resultado, string analisis);
    }
}