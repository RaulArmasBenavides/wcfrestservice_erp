using log4net;
using ServicioWCFRest.Business.Interfaces;
using ServicioWCFRest.Business.Services;
using ServicioWCFRest.DataAccess;
using ServicioWCFRest.DataAccess.Model;
using ServicioWCFRest.DataAccess.Repository;
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

        public ServicioEmpleado()
        {
            log4net.Config.XmlConfigurator.Configure();
            _empleadoService = new EmpleadoService();
        }

        #endregion



        EmpleadoRepository ser;
        IEmpleadoService _empleadoService;
             
        public bool create(Empleado empleado)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                try
                {
                    db.Empleados.Add(empleado);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception )
                {
                    return false;
                }
            }
        }

        public bool delete(Empleado empleado)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                try
                {
                    int cod = Convert.ToInt32(empleado.IdEmpleado);
                    Empleado emp = db.Empleados.Single(em => em.IdEmpleado == cod);
                    db.Empleados.Remove(emp);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool edit(Empleado empleado)
        {
            using (NeptunoEntities db = new NeptunoEntities())
            {
                try
                {
                    int cod = Convert.ToInt32(empleado.IdEmpleado);
                    Empleado emp = db.Empleados.Single(em => em.IdEmpleado == cod);
                    emp.Apellidos = empleado.Apellidos;
                    emp.Nombre = empleado.Nombre;
                    emp.Cargo = empleado.Cargo;
                    emp.Dirección = empleado.Dirección;
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
                    Dirección = em.Dirección
                }).First();
            }
        }//

        public IEnumerable<Empleado> readAll()
        {
            return _empleadoService.readAll();
        }  


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
