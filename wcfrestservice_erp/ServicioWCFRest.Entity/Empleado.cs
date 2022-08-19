using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioWCFRest.Entity
{
    [DataContract]
    public class Empleado
    {
        public int IdEmpleado { get; set; }


        [DataMember(Name = "Nombre", Order = 1)]
        public string Nombre { get; set; } 

        [DataMember(Name = "Apellidos", Order = 2)]
        public string Apellidos { get; set; }


        [DataMember(Name = "Cargo", Order = 3)]
        public string Cargo { get; set; }


        [DataMember(Name = "Direccion", Order = 4)]
        public string Direccion { get; set; }
    }
}