using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Laboratoristas
{
    public abstract class FachadaLaboratorista
    {
        public abstract void guardar(Laboratorista obj);
        public abstract List<Laboratorista> buscarUsuario();
    }
}