using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DMV.DAL
{
    public class Form : DMVadd
    {
        public Form() : base("name=Form")
        {

        }
        public virtual DbSet<Change> Requests { get; set; }
    }
}