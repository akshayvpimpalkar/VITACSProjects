using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyRestService_insert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILogService
    {

        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat =WebMessageFormat.Json,UriTemplate ="/InsertLog/{UserId}/{Password}")]
        bool InsertLog(int UserId, string Password);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DisplayLog")]
        List<Log> Display();

        // TODO: Add your service operations here
    }
    
}
