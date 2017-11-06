using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMV.Models;
using System.Data.Entity;

namespace DMV.DAL
{
    public class Form
    {
        public Form() : base("name=Form")
        {

        }
        public virtual DbSet<Change> People { get; set; }
    }
}