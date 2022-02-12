using System;

namespace DentistOffice.ApplicationServices.API.Domain.Models
{
    public class UserDto
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
