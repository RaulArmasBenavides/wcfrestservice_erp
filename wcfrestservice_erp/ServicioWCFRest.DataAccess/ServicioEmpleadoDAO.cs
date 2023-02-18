using app.erp.rmab.common;
using ServicioWCFRest.DataAccess.Model;
using ServicioWCFRest.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ServicioWCFRest.DataAccess
{
    public class ServicioEmpleadoDAO : AccesoDB
    {
        public ServicioEmpleadoDAO()
        {
            constconexion.ProviderConnectionString = CustomXMLReader.leerConexion(1);//ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString;
            constconexion.Metadata = "res://*/Model.Modelo.csdl|res://*/Model.Modelo.ssdl|res://*/Model.Modelo.msl";
            this.Conexion();
        }

        public List<Empleado> readAll()
        {
            using (e)
            {
                return e.Empleados.Select(em => new Empleado
                {
                    IdEmpleado = em.IdEmpleado,
                    Apellidos = em.Apellidos,
                    Nombre = em.Nombre,
                    Cargo = em.Cargo,
                    Direccion = em.Dirección
                }).ToList();
            }
       

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
