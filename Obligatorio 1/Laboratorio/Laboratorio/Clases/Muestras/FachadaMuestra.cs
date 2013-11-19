using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Muestras
{
    public abstract class FachadaMuestra
    {
        public abstract void guardar(Muestra obj);
        public abstract void modificar(int ced, string est);
    }
}