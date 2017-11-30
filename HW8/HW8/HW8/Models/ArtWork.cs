using HW8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace HW8.Models
{
    [Table("Artist")]
    public class ArtWork
    {
        public ArtWork()
        {
            Genres = new HashSet<Genre>();
        }

        [Key]
        [Display(Name = "Title:"), Required]
        public string Title { get; set; }

        [Display(Name = "ArtistName:"), Required]
        public string ArtistName { get; set; }

        public virtual Artist Works { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}