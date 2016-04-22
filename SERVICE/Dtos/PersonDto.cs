namespace SERVICE.Dtos
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class PersonDto
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string FIRST_NAME { get; set; }

        [DataMember]
        public string LAST_NAME { get; set; }

        [DataMember]
        public RegionDto REGION { get; set; }
    }
}