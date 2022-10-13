using log4net;
using System;
using System.Reflection;
using System.Text;

namespace ServicioWCFRest.Entity
{
    [Serializable]
    public class LogNeptuno
    {
        #region Campos

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string _separador = "#############################################################";

        #endregion

        //#region Exception

        //public static Exception LogErrorEx(string mensaje)
        //{
        //    Log.Error("ERROR: " + mensaje);
        //    return new Exception(mensaje, new Exception(mensaje));
        //}

        //public static Exception LogErrorEx(Exception ex, string mensaje, string clase, string metodo)
        //{
        //    string detalle = ex.Message.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);
        //    Log.Error(log.ToString());

        //    return new Exception(log.ToString(), ex);
        //}

        //public static Exception LogErrorEx(Exception ex, string mensaje)
        //{
        //    Log.Error("ERROR: " + mensaje);
        //    Log.Error("DETALLE EXCEPCION: " + ex.ToString());
        //    return new Exception(mensaje, ex);
        //}

        //public static Exception LogErrorServicioEx<T>(string mensaje)
        //{
        //    Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje);
        //    return new Exception(mensaje, new Exception(mensaje));
        //}

        //public static Exception LogErrorServicioEx<T>(Exception ex, string mensaje)
        //{
        //    Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje);
        //    Log.Error("DETALLE EXCEPCION SERVICIO: " + ex.ToString());
        //    return new Exception(mensaje, ex);
        //}

        //#endregion Exception

        //#region FaultException

        //public static FaultException<ExcepcionLDS> LogErrorFex(Exception ex, string mensaje)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("ERROR: " + mensaje);
        //    log.AppendLine("DETALLE: " + ex.ToString());
        //    log.AppendLine("STACKTRACE: " + ex.StackTrace.ToString());
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = "", mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Grave) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(Exception ex, string mensaje, TipoError tipo)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("ERROR: " + mensaje);
        //    log.AppendLine("DETALLE: " + ex.ToString());
        //    log.AppendLine("STACKTRACE: " + ex.StackTrace.ToString());

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = "", mensajeUsuario = mensaje, categoria = Convert.ToInt32(tipo) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(Exception ex, string mensaje, string clase, string metodo)
        //{
        //    string detalle = ex.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Grave) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(Exception ex, string mensaje, string clase, string metodo, TipoError tipo)
        //{
        //    string detalle = ex.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(tipo) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, string detalle, string clase, string metodo, TipoError tipo)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(tipo) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, Exception ex)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("ERROR: " + mensaje);
        //    log.AppendLine("DETALLE: " + ex.ToString());
        //    log.AppendLine("STACKTRACE: " + ex.StackTrace.ToString());
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = "", mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Grave) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, TipoError tipo, Exception ex)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("ERROR: " + mensaje);
        //    log.AppendLine("DETALLE: " + ex.ToString());
        //    log.AppendLine("STACKTRACE: " + ex.StackTrace.ToString());

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = "", mensajeUsuario = mensaje, categoria = Convert.ToInt32(tipo) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, string clase, string metodo, Exception ex)
        //{
        //    string detalle = ex.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Grave) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, string clase, string metodo, TipoError tipo, Exception ex)
        //{
        //    string detalle = ex.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(tipo) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("ERROR: " + mensaje);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS()
        //    {
        //        mensajeAplicacion = "",
        //        mensajeUsuario = mensaje,
        //        categoria = Convert.ToInt32(TipoError.Grave)
        //    });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, TipoError tipo)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("ERROR: " + mensaje);

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS()
        //    {
        //        mensajeAplicacion = "",
        //        mensajeUsuario = mensaje,
        //        categoria = Convert.ToInt32(tipo)
        //    });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, string clase, string metodo, TipoError tipo)
        //{

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info(log.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error(log.ToString());
        //            break;

        //        default:
        //            Log.Error(log.ToString());
        //            break;
        //    }

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = "", mensajeUsuario = mensaje, categoria = Convert.ToInt32(tipo) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorFex(string mensaje, string clase, string metodo)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = "", mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Grave) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorValFex(string mensaje)
        //{
        //    Log.Error("ERROR: " + mensaje);
        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS()
        //    {
        //        mensajeAplicacion = "",
        //        mensajeUsuario = mensaje,
        //        categoria = Convert.ToInt32(TipoError.Validacion)
        //    });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorValFex(Exception ex, string mensaje, string clase, string metodo)
        //{
        //    string detalle = ex.Message.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Validacion) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorValFex(string mensaje, string clase, string metodo, Exception ex)
        //{
        //    string detalle = ex.Message.ToString();
        //    string stackTrace = ex.StackTrace.ToString();

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);
        //    log.AppendLine("STACKTRACE: " + stackTrace);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Validacion) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorValFex(string mensaje, string clase, string metodo)
        //{

        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    Log.Error(log.ToString());

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = mensaje, mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Validacion) });
        //}

        //public static FaultException<ExcepcionLDS> LogErrorValFex(string mensaje, string detalle, string clase, string metodo)
        //{
        //    StringBuilder log = new StringBuilder();

        //    log.AppendLine(_separador);
        //    log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        //    log.AppendLine("CLASE: " + clase);
        //    log.AppendLine("MÉTODO: " + metodo);
        //    log.AppendLine("MENSAJE: " + mensaje);
        //    log.AppendLine("DETALLE: " + detalle);

        //    return new FaultException<ExcepcionLDS>(new ExcepcionLDS() { mensajeAplicacion = detalle, mensajeUsuario = mensaje, categoria = Convert.ToInt32(TipoError.Validacion) });
        //}

        //#endregion

        //#region void

        //public static void LogError(string mensaje)
        //{
        //    Log.Error("ERROR: " + mensaje);
        //}

        //public static void LogError(string mensaje, TipoError tipo)
        //{

        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Info("VALIDACIÓN: " + mensaje);
        //            break;
        //        case TipoError.Grave:
        //            Log.Error("ERROR: " + mensaje);
        //            break;

        //        default:
        //            Log.Error("ERROR: " + mensaje);
        //            break;
        //    }
        //}

        //public static void LogError(Exception ex, string mensaje)
        //{
        //    Log.Error("ERROR: " + mensaje + "\n" + "DETALLE EXCEPCION: " + ex.ToString() + "\n" + "STACKTRACE: " + ex.StackTrace.ToString());
        //}

        //public static void LogError(Exception ex, string mensaje, TipoError tipo)
        //{
        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Error("VALIDACIÓN: " + mensaje + "\n" + "DETALLE: " + ex.ToString() + "\n" + "STACKTRACE: " + ex.StackTrace.ToString());
        //            break;
        //        case TipoError.Grave:
        //            Log.Error("ERROR: " + mensaje + "\n" + "DETALLE: " + ex.ToString() + "\n" + "STACKTRACE: " + ex.StackTrace.ToString());
        //            break;

        //        default:
        //            Log.Error("ERROR: " + mensaje + "\n" + "DETALLE: " + ex.ToString() + "\n" + "STACKTRACE: " + ex.StackTrace.ToString());
        //            break;
        //    }

        //}

        //public static void LogErrorServicio<T>(string mensaje)
        //{
        //    Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje);
        //}

        //public static void LogErrorServicio<T>(string mensaje, TipoError tipo)
        //{
        //    switch (tipo)
        //    {
        //        case TipoError.Validacion:
        //            Log.Error("VALIDACIÓN SERVICIO " + typeof(T).Name + ": " + mensaje + "\n");
        //            break;
        //        case TipoError.Grave:
        //            Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje + "\n");
        //            break;

        //        default:
        //            Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje + "\n");
        //            break;
        //    }

        //}

        public static void LogErrorServicio<T>(Exception ex, string mensaje)
        {
            Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje + "\n" + "DETALLE EXCEPCION SERVICIO: " + ex.ToString() + "\n" + "STACKTRACE: " + ex.StackTrace.ToString());
        }

        public static void LogMensaje(string mensaje)
        {
            Log.Info(mensaje);
        }

        public static void LogMensaje(string mensaje, string clase, string metodo)
        {
            StringBuilder log = new StringBuilder();

            log.AppendLine(_separador);
            log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
            log.AppendLine("CLASE: " + clase);
            log.AppendLine("MÉTODO: " + metodo);
            log.AppendLine("MENSAJE: " + mensaje);
            Log.Info(log.ToString());
        }

    }
}
