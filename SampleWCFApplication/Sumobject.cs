using System.Runtime.Serialization;

namespace SampleWCFApplication
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