namespace HW7.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GiphyContext : DbContext
    {
        public GiphyContext()
            : base("name=GiphyContext")
        {
        }

        public virtual DbSet<Tracker> Trackers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
