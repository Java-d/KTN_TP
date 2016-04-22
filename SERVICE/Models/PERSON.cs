namespace SERVICE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONS")]
    public partial class PERSON
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Required]
        [Column(Order = 1)]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [Required]
        [Column(Order = 2)]
        [StringLength(30)]
        public string LAST_NAME { get; set; }

        [Required]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REGION_ID { get; set; }

        public virtual REGION REGION { get; set; }

    }

}
