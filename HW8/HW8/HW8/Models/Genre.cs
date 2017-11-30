using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW8.Models
{
    public class Genre
    {
        [Key]
        [Display(Name = "Genre:"), Required]
        public string GenreName { get; set; }

    }
}