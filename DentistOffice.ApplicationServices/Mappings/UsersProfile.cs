using AutoMapper;
using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.DataAccess.Entities;

namespace DentistOffice.ApplicationServices.Mappings
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
