using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DMV.DAL
{
    public class Change
    {
        public Change() : base("name=Form")
        {

        }
        public virtual DbSet<Change> People { get; set; }
    }
}