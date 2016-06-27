using System.Runtime.Serialization;

namespace WCFServiceWebRole1
{
    [DataContract]
    public class Sumobject
    {
        [DataMember]
        public int Num1 { get; set; }
        [DataMember]
        public int Num2 { get; set; }
    }

}