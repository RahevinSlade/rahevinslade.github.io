using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW8.Models
{
    public class CheckDate : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime dt = Convert.ToDateTime(value);
            return dt < DateTime.Now;
        }

    }
}