using ServicioWCFRest.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWCFRest.Business.Interfaces
{
    public interface IEmpleadoService
    {
        IEnumerable<Empleado> readAll();
    }
}
