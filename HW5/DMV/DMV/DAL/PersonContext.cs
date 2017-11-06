using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMV.Models;
using System.Data.Entity;

namespace DMV.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("name=PersonContext")
        {

        }
        public virtual DbSet<Person> Persons { get; set; }
    }
}