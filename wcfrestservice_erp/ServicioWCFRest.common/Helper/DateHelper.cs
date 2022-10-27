using System;
using System.Globalization;

namespace ServicioWCFRest.common.Helper
{
    public class DateHelper
    {
        public static string FormatoFecha(string psFecha_mdy)
        {   // OBJETIVO : Modificar el formato de una fecha de MM/DD/YYYY a DD/MM/YYYY o viceversa
            //SOLICITA  : psFecha_mdy = Fecha a formatear
            //RETORNA   : Fecha formateada

            if (psFecha_mdy.Equals(""))
            {
                return "";
            }
            else
            {
                return psFecha_mdy.Substring(3, 2) + "/" + psFecha_mdy.Substring(0, 2) + "/" + psFecha_mdy.Substring(6, 4);
            }
        }

        //20181108000000

        /// <summary>
        /// Modifica el formato de una fecha de MM/DD/YYYY a DD/MM/YYYY o viceversa
        /// Returns Fecha formateada
        /// </summary>
        /// <param name="psFecha_mdy"></param>
        /// <returns></returns>
        public static string FormatoFecha2(string psFecha_mdy)
        {  
            if (psFecha_mdy.Equals(""))
            {
                return "2022-01-01";
            }
            else
            {
                return psFecha_mdy.Substring(6, 2) + "/" + psFecha_mdy.Substring(4, 2) + "/" + psFecha_mdy.Substring(0, 4);
            }
        }


        public static string GetMonthNameByNumber(int nummonth)
        {
            string fullMonthName = new DateTime(2022, nummonth, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es-PE"));
            return fullMonthName;
        }

        public static string ConvertToDateStringFormat(DateTime dt)
        {
            return dt.ToString("yyyyMMddHHmmss");
        }

        public static bool ValidarEsJuevesDomingo(DateTime dt)
        {
            DayOfWeek day = dt.DayOfWeek;
            if (day != DayOfWeek.Thursday && day != DayOfWeek.Saturday)
            {
                return false;
            }
            return true;
        }

    }
}
