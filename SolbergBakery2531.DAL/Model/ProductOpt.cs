using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("ProductOpts")]
    public class ProductOpt
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(300)]
        public string Option { get; set; }
        public virtual Product AssociatedProduct { get; set; }
    }
}
