using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Clases.Clientes
{
    public abstract class FachadaPaciente
    {
        public abstract void guardar(Paciente obj);
        public abstract List<Paciente> buscarPorCedula(int ci);
        public abstract void modificar(int ced, string dir, int tel, string mail, string fil, string est);
    }
}