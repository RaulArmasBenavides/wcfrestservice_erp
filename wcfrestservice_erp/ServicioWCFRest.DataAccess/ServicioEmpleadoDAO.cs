using ServicioWCFRest.Entity;
using ServicioWCFRest.Model;
using ServicioWCFRest.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWCFRest.DataAccess
{
    public class ServicioEmpleadoDAO : AccesoDB
    {
        public ServicioEmpleadoDAO()
        {
            constconexion.ProviderConnectionString = CustomXMLReader.leerConexion();//ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString;
            constconexion.Metadata = "res://*/EF.Model1.csdl|res://*/EF.Model1.ssdl|res://*/EF.Model1.msl";
        }

        public List<Empleado> readAll()
        {
            
            
            //using (NeptunoEntities db = new NeptunoEntities())
            //{
            //    return db.Empleados.Select(em => new Empleado
            //    {
            //        IdEmpleado = em.IdEmpleado,
            //        Apellidos = em.Apellidos,
            //        Nombre = em.Nombre,
            //        Cargo = em.Cargo,
            //        Direccion = em.Dirección
            //    }).ToList();
            //}
        }//
    }
}
