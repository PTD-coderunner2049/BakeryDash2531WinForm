using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid ProductGlobalId { get; set; } = Guid.NewGuid();
        
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        [StringLength(300)]
        public string Note { get; set; } //Tasting advice or smthing
        public DateTime AvailableDate { get; set; } = DateTime.UtcNow;
        public DateTime DiscontinueDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal Pricing { get; set; }
    }
}
