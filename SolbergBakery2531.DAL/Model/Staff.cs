using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolbergBakery2531.DAL.Model
{
    [Table("Staffs")]
    public class Staff
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [StringLength(15)]
        [Index(IsUnique = true)]
        public string PhoneContact { get; set; }
        [Required]
        [StringLength(1)] //M/F
        public string Gender { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        [Required]
        [StringLength(11)]//(e.g., 000-00-0000)
        [Index(IsUnique = true)]
        public string SSN { get; set; }
        [Required]
        public decimal PayratePerHrs { get; set; }


        [Required]
        public bool Active { get; set; } = false;
        [Required]
        public bool IsSystemManager { get; set; } = false;

        public virtual User StaffAccount { get; set; }
        public virtual ICollection<StaffHistory> Histories { get; set; }
    }
}
