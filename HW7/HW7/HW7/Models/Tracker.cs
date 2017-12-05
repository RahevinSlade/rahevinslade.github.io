namespace HW7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tracker")]
    public partial class Tracker
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Search { get; set; }

        public DateTime Stamp { get; set; }

        [Required]
        [StringLength(128)]
        public string UserIP { get; set; }

        [Required]
        [StringLength(128)]
        public string Browser { get; set; }
    }
}
