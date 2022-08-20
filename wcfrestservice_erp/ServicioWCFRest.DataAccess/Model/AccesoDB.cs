using System;
using System.Data.Entity.Core.EntityClient;
using System.IO;
using System.Net;

namespace ServicioWCFRest.DataAccess.Model
{
    public class AccesoDB
    {

        protected NeptunoEntities e;

        public string Database { get; set; }

        public string user { get; set; }

        public string Pwd { get; set; }

        public string Server { get; set; }

        public string HostName { get; set; }

        public string ConexProvider { get; set; }

        public string cadenadesencriptada { get; set; }

        protected EntityConnectionStringBuilder constconexion;



        public AccesoDB()
        {
            String hostName = Dns.GetHostName();
            constconexion = new EntityConnectionStringBuilder();
            constconexion.Provider = "System.Data.SqlClient";
     

        }

        public Boolean Conexion()
        {
            try
            {
                //conectar = new MySqlConnection(cadenadesencriptada);
                //System.Windows.Forms.MessageBox.Show("Conexion Establecida !!!");
                //conectar.Open();
                e = new NeptunoEntities(constconexion.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //System.Windows.Forms.MessageBox.Show("No se pudo conectar!!!");
            }
        }

        public void Creararchivo()
        {
            string cadena;
            string filename = @"C:\datos\feedback.ini";
            FileStream Stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(Stream);
            cadena = "Server=" + Server + ";Database=" + Database + "; User Id=" + user + ";Password=" + Pwd;
            //string cadenaencriptada = HelperDAO.Encriptar(cadena);  
            //writer.WriteLine(cadenaencriptada);
            writer.Close();
        }

        public void CrearArchivoConNombre(string x)
        {
            string cadena;
            string filename = @"C:\datos\feedback.ini";
            FileStream Stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(Stream);
            cadena = "Server=" + Server + ";Database=" + Database + "; User Id=" + user + ";Password=" + Pwd;
            //string cadenaencriptada = HelperDAO.Encriptar(cadena);
            //writer.WriteLine(cadenaencriptada);
            writer.Close();
        }
        public void Close()
        {
            e.SaveChanges();
            e.Dispose();
        }
        //public static SqlConnection Conexion()
        //{
        //    //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bdgenericEntities"].ConnectionString);
        //    //return cn;
        //}
    }
}
