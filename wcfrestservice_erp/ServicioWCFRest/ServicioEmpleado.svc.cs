using log4net;
using ServicioWCFRest.DataAccess;
using ServicioWCFRest.DataAccess.Model;
using ServicioWCFRest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ServicioWCFRest
{

    public class ServicioEmpleado : IServicioEmpleado
    {

        #region Variables de Clase

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private const int VALOR_MAX = 9999999;

        #endregion

        #region Configuración del Log

        static ServicioEmpleado()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        #endregion



        ServicioEmpleadoDAO ser;
             
        public bool create(Empleado empleado)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                try
                {
                    EmpleadoEntity emp = new EmpleadoEntity();
                    emp.Apellidos = empleado.Apellidos;
                    emp.Nombre = empleado.Nombre;
                    emp.Cargo = empleado.Cargo;
                    emp.Dirección = empleado.Direccion;
                    db.Empleados.Add(emp);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception )
                {
                    return false;
                }
            }
        }//

        public bool delete(Empleado empleado)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                try
                {
                    int cod = Convert.ToInt32(empleado.IdEmpleado);
                    EmpleadoEntity emp = db.Empleados.Single(em => em.IdEmpleado == cod);
                    db.Empleados.Remove(emp);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }//

        public bool edit(Empleado empleado)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                try
                {
                    int cod = Convert.ToInt32(empleado.IdEmpleado);
                    EmpleadoEntity emp = db.Empleados.Single(em => em.IdEmpleado == cod);
                    emp.Apellidos = empleado.Apellidos;
                    emp.Nombre = empleado.Nombre;
                    emp.Cargo = empleado.Cargo;
                    emp.Dirección = empleado.Direccion;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }//

        public Empleado find(string id)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                int cod = Convert.ToInt32(id);
                return db.Empleados.Where(em => em.IdEmpleado == cod).Select(em => new Empleado
                {
                    IdEmpleado = em.IdEmpleado,
                    Apellidos = em.Apellidos,
                    Nombre = em.Nombre,
                    Cargo = em.Cargo,
                    Direccion = em.Dirección
                }).First();
            }
        }//

        public List<Empleado> readAll()
        {
            LogNeptuno.LogMensaje("Probando el log");
            ser = new ServicioEmpleadoDAO();
            return ser.readAll();
        }//


        //public List<Empleado> readAlloauth()
        //{

        //    if (Authenticate(WebOperationContext.Current.IncomingRequest))
        //    {
        //        return readAll();
        //    }
        //    else
        //    {
        //        WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
        //        // return "Unauthorized Request.";
        //        return null;
        //    }
   
        //}

        //private bool Authenticate(IncomingWebRequestContext context)
        //{
        //    bool Authenticated = false;
        //    string normalizedUrl;
        //    string normalizedRequestParameters;
        //    //context.Headers
        //    NameValueCollection pa = context.UriTemplateMatch.QueryParameters;
        //    if (pa != null && pa["oauth_consumer_key"] != null)
        //    {
        //        // to get uri without oauth parameters
        //        string uri = context.UriTemplateMatch.RequestUri.OriginalString.Replace
        //            (context.UriTemplateMatch.RequestUri.Query, "");
        //        string consumersecret = "suryabhai";
        //        OAuthBase oauth = new OAuthBase();
        //        string hash = oauth.GenerateSignature(
        //            new Uri(uri),
        //            pa["oauth_consumer_key"],
        //            consumersecret,
        //            null, // totken
        //            null, //token secret
        //            "GET",
        //            pa["oauth_timestamp"],
        //            pa["oauth_nonce"],
        //            out normalizedUrl,
        //            out normalizedRequestParameters
        //            );
        //        Authenticated = pa["oauth_signature"] == hash;
        //    }
        //    return Authenticated;
        //}
    }
}
