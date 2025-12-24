using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("ProductHistories")]
    public class ProductHistory
    {
        [Key]
        public Guid ChangeId { get; set; } = Guid.NewGuid();
        [Required]
        public DateTime ChangeOccur { get; set; } = DateTime.UtcNow;
        [Required]
        public string Source { get; set; } = "";
        [Required]
        public int ChangeQuantity { get; set; }
        [Required]
        public decimal ImportValue { get; set; }
        [Required]
        public decimal SaleValue { get; set; }


        public decimal TotalWorth => ChangeQuantity * SaleValue;

        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product AssociatedProduct { get; set; }
    }
}