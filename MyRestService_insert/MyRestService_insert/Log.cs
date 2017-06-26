using System.Runtime.Serialization;

namespace MyRestService_insert
{
    [DataContract]
    public class Log
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}