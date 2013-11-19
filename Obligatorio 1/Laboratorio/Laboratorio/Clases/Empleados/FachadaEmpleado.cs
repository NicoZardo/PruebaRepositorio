using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Empleados
{
    public abstract class FachadaEmpleado
    {
        public abstract void guardar(Empleado obj);
        public abstract List<Empleado> buscarPorCedula(int ci);
        public abstract void modificar(int ced, string dir, int tel, string mail, string usu, string cont, string est);
    }
}