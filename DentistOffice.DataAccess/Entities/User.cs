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

        public UserAddress UserAddress { get; set; }
        public UserContact UserContact { get; set; }
        public UserCard UserCard { get; set; }
    }
}
