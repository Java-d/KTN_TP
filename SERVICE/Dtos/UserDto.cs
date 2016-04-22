namespace SERVICE.Dtos
{
    using System.Runtime.Serialization;
    [DataContract]
    public partial class UserDto
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string FIRST_NAME { get; set; }
        [DataMember]
        public string LAST_NAME { get; set; }
        [DataMember]
        public string USERNAME { get; set; }
    }
}
