using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Forms.Models
{
    public class LoanCalc
    {
        [Required(ErrorMessage = "Looks like you entered in the wrong amount")]
        public string Amount { get; set; }
        [Required(ErrorMessage = "Looks like you entered in the wrong rate")]
        public string Rate { get; set; }
        [Required(ErrorMessage = "You'll need to enter a number of pay periods")]
        public string Paym { get; set; }
    }
}