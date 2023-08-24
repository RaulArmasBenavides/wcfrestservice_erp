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


        public static Exception LogErrorEx(string mensaje)
        {
            Log.Error("ERROR: " + mensaje);
            return new Exception(mensaje, new Exception(mensaje));
        }

        public static Exception LogErrorEx(Exception ex, string mensaje, string clase, string metodo)
        {
            string detalle = ex.Message.ToString();
            string stackTrace = ex.StackTrace.ToString();
            StringBuilder log = new StringBuilder();
            log.AppendLine(_separador);
            log.AppendLine("FECHA: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
            log.AppendLine("CLASE: " + clase);
            log.AppendLine("MÉTODO: " + metodo);
            log.AppendLine("MENSAJE: " + mensaje);
            log.AppendLine("DETALLE: " + detalle);
            log.AppendLine("STACKTRACE: " + stackTrace);
            Log.Error(log.ToString());
            return new Exception(log.ToString(), ex);
        }

        public static Exception LogErrorEx(Exception ex, string mensaje)
        {
            Log.Error("ERROR: " + mensaje);
            Log.Error("DETALLE EXCEPCION: " + ex.ToString());
            return new Exception(mensaje, ex);
        }

        public static Exception LogErrorServicioEx<T>(string mensaje)
        {
            Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje);
            return new Exception(mensaje, new Exception(mensaje));
        }

        public static Exception LogErrorServicioEx<T>(Exception ex, string mensaje)
        {
            Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje);
            Log.Error("DETALLE EXCEPCION SERVICIO: " + ex.ToString());
            return new Exception(mensaje, ex);
        }
        public static void LogError(Exception ex, string mensaje)
        {
            Log.Error("ERROR: " + mensaje + "\n" + "DETALLE EXCEPCION: " + ex.ToString() + "\n" + "STACKTRACE: " + ex.StackTrace.ToString());
        }
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

        public static void LogErrorServicio<T>(string mensaje)
        {
            Log.Error("ERROR SERVICIO " + typeof(T).Name + ": " + mensaje);
        }
    }
}
