using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWCFRest
{
    
    [ServiceContract]
    public interface IServicioEmpleado
    {
        //definir los contratos(metodos) 

        [OperationContract]
        [WebInvoke(Method ="GET", UriTemplate = "readall", ResponseFormat = WebMessageFormat.Json)]
        List<Empleado> readAll();


        //[FaultContract(typeof(ExcepcionLDS))]
        //[OperationContract]
        //[WebInvoke(
        // Method = "POST",
        // RequestFormat = WebMessageFormat.Json,
        // ResponseFormat = WebMessageFormat.Json,
        // UriTemplate = "/Reclamo/ListarReclamosPorEmitir",
        // BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        //List<ReclamoDto> ListarReclamosPorEmitir(int corrProceso);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Empleado find(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", RequestFormat =WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool create(Empleado empleado);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool edit(Empleado empleado);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool delete(Empleado empleado);
    }
}
