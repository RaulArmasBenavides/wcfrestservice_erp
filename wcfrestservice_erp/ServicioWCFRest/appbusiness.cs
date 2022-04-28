using log4net.Config;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;

namespace ServicioWCFRest
{
    public class appbusiness
    {
        #region Cultura

        private CultureInfo GetCulture()
        {
            CultureInfo culturePeru = new CultureInfo("es-PE", false);
            culturePeru.NumberFormat.NumberGroupSeparator = ",";
            culturePeru.NumberFormat.NumberDecimalSeparator = ".";
            return culturePeru;
        }

        private void SetCulture()
        {
            CultureInfo culturePeru = GetCulture();
            Thread.CurrentThread.CurrentCulture = culturePeru;
            Thread.CurrentThread.CurrentUICulture = culturePeru;
        }

        #endregion

        #region Configuración del Log

        static appbusiness()
        {
            XmlConfigurator.Configure();
        }

        private string Encriptar(string texto)
        {
            using (SHA512 hash = SHA512.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        #endregion
    }
}