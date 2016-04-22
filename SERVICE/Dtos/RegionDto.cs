namespace SERVICE.Dtos
{

    using System.Runtime.Serialization;
    [DataContract]
    public partial class RegionDto
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int? P_ID { get; set; }
        [DataMember]
        public string REGION_NAME { get; set; }
    }
}
