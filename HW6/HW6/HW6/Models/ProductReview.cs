namespace HW6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Production.ProductReview")]
    public partial class ProductReview
    {
        public int ProductReviewID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string ReviewerName { get; set; }

        public DateTime ReviewDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Display(Name = "Rating: 1-5")]
        public int Rating { get; set; }

        [StringLength(3850)]
        public string Comments { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}