using HW8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace HW8.Models
{
    [Table("Artist")]
    public partial class Artist
    {
        public Artist()
        {
            ArtWorks = new HashSet<ArtWork>();
        }

        [Key]
        [Display(Name = "Name:"), Required]
        public string ArtistName { get; set; }

        [Display(Name = "Date Of Birth:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime DOB { get; set; }


        [Display(Name = "Birth City:"), Required]
        public string BirthCity { get; set; }

        public virtual ICollection<ArtWork> ArtWorks { get; set; }
    }
}
