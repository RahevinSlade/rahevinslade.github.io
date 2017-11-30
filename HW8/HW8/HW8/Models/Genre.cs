using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace HW8.Models
{
    [Table("Genre")]
    public partial class Genre
    {
        public Genre()
        {
            ArtWorks = new HashSet<ArtWork>();
        }

        [Key]
        [Display(Name = "Genre:"), Required]
        public string GenreName { get; set; }

        public virtual ICollection<ArtWork> ArtWorks { get; set; }

    }
}