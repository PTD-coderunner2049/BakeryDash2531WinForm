using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SolbergBakery2531.DAL.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        [StringLength(1000)]
        public string Note { get; set; } //Tasting advice or smthing
        public DateTime AvailableDate { get; set; } = DateTime.UtcNow;
        public DateTime DiscontinueDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal Pricing { get; set; }
        public Guid ProdCategoryId { get; set; }
        [ForeignKey("ProdCategoryId")]
        public virtual ProdCategory AssociatedCategory { get; set; }
        public virtual ICollection<ProductVisual> ProductVisuals { get; set; }
    }
}
