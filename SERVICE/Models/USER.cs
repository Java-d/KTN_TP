namespace SERVICE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(60)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(30)]
        public string PASSWORD { get; set; }
    }
}
