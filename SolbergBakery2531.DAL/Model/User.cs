using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("Users")]
    public class User
    {
        [Key, ForeignKey("AccociatedStaff")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public bool Active { get; set; } = false;
        public virtual Staff AccociatedStaff { get; set; }
    }
}