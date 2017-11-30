﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW8.Models;
using System.Data.Entity;

namespace HW8.DAL
{
    public class ArtistContext : DbContext
    {
        public ArtistContext() : base("name=ArtistContext")
        {

        }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtWork> ArtWorks { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Property(e => e.BirthCity)
                .IsFixedLength();

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.ArtWorks)
                .WithRequired(e => e.Artist1)
                .HasForeignKey(e => e.ArtistName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArtWork>()
                .HasMany(e => e.Genres)
                .WithMany(e => e.ArtWorks)
                .Map(m => m.ToTable("Classification").MapLeftKey("ArtWork").MapRightKey("Genre"));
        }

    }
}