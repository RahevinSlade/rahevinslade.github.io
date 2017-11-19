using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW6.Models
{
    public partial class HW6Context : DbContext
    {
        public HW6Context()
        {
            : base("name=HW6Context")
        }

    }
}