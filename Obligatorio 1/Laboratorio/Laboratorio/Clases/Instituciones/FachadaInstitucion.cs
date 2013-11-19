using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Instituciones
{
    public abstract class FachadaInstitucion
    {
        public abstract void guardar(Institucion obj);

        public abstract List<Institucion> mostar();
    }
}