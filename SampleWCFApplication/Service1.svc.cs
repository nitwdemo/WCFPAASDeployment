using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace SampleWCFApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int sum(string num1, string num2)
        {
            return Convert.ToInt32(num1) + Convert.ToInt32(num2);
        }
        
        public IAsyncResult BeginsumAsync1(string num1, string num2, AsyncCallback callback, object state)
        {
            return new CompletedAsyncResult(Convert.ToInt32(num1), Convert.ToInt32(num2));
        }

        public int EndsumAsync1(IAsyncResult r)
        {
            CompletedAsyncResult result = r as CompletedAsyncResult;
            Console.WriteLine("EndSampleMethod called with: " + result.Data);
            return result.Data;
        }

        public int sumpost(Sumobject sumobject)
        {
            int iValue = 0;
            iValue = sumobject.Num1 + sumobject.Num2;
            return iValue;
        }
        //public int sumpost(int num1, int num2)
        //{
        //    int iValue = 0;
        //    iValue = num1 + num2;
        //    return iValue;
        //}


        public List<Players> GetPlayersJson()
        {
            List<Players> obj = new List<Players>();
            obj.Add(new Players { Name = "a", Country = "a", ImageUrl = "a", Sports = "a" });
            obj.Add(new Players { Name = "b", Country = "b", ImageUrl = "b", Sports = "b" });
            return obj;
        }

    }

}
