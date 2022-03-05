using System.ComponentModel.DataAnnotations;

namespace DentistOffice.DataAccess.Entities
{
    public class UserContact : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
