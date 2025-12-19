using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("StaffHistories")]
    public class StaffHistory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime Start { get; set; } = DateTime.UtcNow;
        public DateTime? End { get; set; }
        [Required]
        public bool Ongoing { get; set; } = true;
        public string HR_Feedback { get; set; } = "Was an Ordinary employee with us.";
        
        
        public Guid StaffId { get; set; }
        [ForeignKey("StaffId")]
        public virtual Staff AssociatedStaff { get; set; }
    }
}