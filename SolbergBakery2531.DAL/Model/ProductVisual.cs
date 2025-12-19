using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("ProductVisuals")]
    public class ProductVisual
    {
        [Key, ForeignKey("AssociatedProduct")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        public byte[] VisualinByte { get; set; }
        public virtual Product AssociatedProduct { get; set; }
    }
}
