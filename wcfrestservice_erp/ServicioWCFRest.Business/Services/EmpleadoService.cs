using ServicioWCFRest.Business.Interfaces;
using ServicioWCFRest.DataAccess.Model;
using ServicioWCFRest.DataAccess.Repository;
using ServicioWCFRest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWCFRest.Business.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        EmpleadoRepository ser;
        public IEnumerable<Empleado> readAll()
        {
            LogNeptuno.LogMensaje("Probando el log");
            ser = new EmpleadoRepository();
            return ser.readAll();
        }

    }
}
