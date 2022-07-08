using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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



        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "readAlloauth", ResponseFormat = WebMessageFormat.Json)]
        //List<Empleado> readAlloauth();

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



        //[OperationContract(Name = "GetSampleMethod_With_OAuth")]
        //[WebGet(UriTemplate = "GetSampleMethod_With_OAuth/inputStr/{name}")]
        //string GetSampleMethod_With_OAuth(string name);
        //public string GetSampleMethod_With_OAuth(string strUserName)
        //{
        //    if (Authenticate(WebOperationContext.Current.IncomingRequest))
        //    {
        //        StringBuilder strReturnValue = new StringBuilder();
        //        // return username prefixed as shown below
        //        strReturnValue.Append(string.Format("You have entered userName as {0}", strUserName));
        //        return strReturnValue.ToString();
        //    }
        //    else
        //    {
        //        WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
        //        return "Unauthorized Request.";
        //    }
        //}

        //bool Authenticate(IncomingWebRequestContext incomingRequest);
    }
}
