using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("ProductVisuals")]
    public class ProductVisual
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public byte[] VisualinByte { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product AssociatedProduct { get; set; }
    }
}
