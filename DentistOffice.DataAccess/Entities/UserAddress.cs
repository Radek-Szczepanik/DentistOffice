using System.ComponentModel.DataAnnotations;

namespace DentistOffice.DataAccess.Entities
{
    public class UserAddress : EntityBase
    {
        [Required]
        [MaxLength(30)]
        public string Street { get; set; }
        [Required]
        [MaxLength(10)]
        public string StreetNumber { get; set; }
        [Required]
        [MaxLength(10)]
        public string PostCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
