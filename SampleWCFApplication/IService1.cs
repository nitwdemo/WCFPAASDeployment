using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWCFApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetsumJson/{num1}/{num2}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        int sum(string num1,string num2);


        [OperationContractAttribute(AsyncPattern = true)]
        [WebGet(UriTemplate = "/GetsumJsonAsync/{num1}/{num2}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        IAsyncResult BeginsumAsync1(string num1, string num2, AsyncCallback callback, object asyncState);
        int EndsumAsync1(IAsyncResult result);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate ="Getsumpost", ResponseFormat = WebMessageFormat.Json, RequestFormat =WebMessageFormat.Json)]
        int sumpost(Sumobject sumobject);
        //int sumpost(int num1, int num2);


        [WebGet(UriTemplate = "/GetPlayersJson",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Bare)]
        List<Players> GetPlayersJson();

    }
    
}
