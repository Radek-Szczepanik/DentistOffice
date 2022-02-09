using System;
using System.ComponentModel.DataAnnotations;

namespace DentistOffice.DataAccess.Entities
{
    public class User : EntityBase
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public int UserAddressId { get; set; }
        public virtual UserAddress UserAddress { get; set; }
        public int UserContactId { get; set; }
        public virtual UserContact UserContact { get; set; }
        public int UserCardId { get; set; }
        public virtual UserCard UserCard { get; set; }
    }
}
