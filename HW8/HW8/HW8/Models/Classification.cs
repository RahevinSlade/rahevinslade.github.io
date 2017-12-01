namespace HW8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classification
    {
        public int ClassificationID { get; set; }

        public int ArtWorkID { get; set; }

        public int GenreID { get; set; }

        public virtual ArtWork ArtWork { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
