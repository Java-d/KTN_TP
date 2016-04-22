namespace SERVICE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REGIONS")]
    public partial class REGION
    {

        public REGION()
        {
            PERSONS = new HashSet<PERSON>();
        }

        [Column(Order = 0)]
        public int ID { get; set; }

        [Column(Order = 2)]
        public int? P_ID { get; set; }

        [Column(Order = 3)]
        [Required]
        public int LEVEL { get; set; }

        [Column(Order = 1)]
        [Required]
        [StringLength(60)]
        public string REGION_NAME { get; set; }
        public virtual ICollection<PERSON> PERSONS { get; set; }
    }
}
