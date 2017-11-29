using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW8.Models
{
    public class Artist
    {
        [Display(Name ="ArtistID:"), Required]
        public int ID { get; set; }

        [Display(Name = "Date Of Birth:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime DOB { get; set; }

        [Display(Name = "Name:"), Required]
        public string Name { get; set; }

        [Display(Name = "Birth City:"), Required]
        public string BirthCity { get; set; }
    }
}
