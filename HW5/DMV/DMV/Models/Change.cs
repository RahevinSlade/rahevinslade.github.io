using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DMV.Models
{
    public class Change
    {
        [Display(Name = "Customer Number"), Required]
        public int ID { get; set; }

        [Display(Name = "Date of birth:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime DOB { get; set; }

        [Display(Name = "Name:"), Required]
        public string Fullname { get; set; }

        [Display(Name = "Address:"), Required]
        public string rAddress { get; set; }

        [Display(Name = "CSZ:"), Required]
        public string CSZ { get; set; }

        [Display(Name = "County:"), Required]
        public string County { get; set; }

        [Display(Name = "Mailing Address:")]
        public string nAddress { get; set; }

        [Display(Name = "Mailing CSZ:")]
        public string nCSZ { get; set; }

        [Display(Name = "Mailing County:")]
        public string nCounty { get; set; }

        [Display(Name = "Date:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime sDate { get; set; }


    }
}