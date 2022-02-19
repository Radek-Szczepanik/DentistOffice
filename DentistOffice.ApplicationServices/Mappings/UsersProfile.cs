using AutoMapper;
using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.DataAccess.Entities;

namespace DentistOffice.ApplicationServices.Mappings
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserDto>();
            //CreateMap<AddUserRequest, User>()
            //    .ForMember(x => x.UserAddress.Street, y => y.MapFrom(z => z.Street))
            //    .ForMember(x => x.UserAddress.StreetNumber, y => y.MapFrom(z => z.StreetNumber))
            //    .ForMember(x => x.UserAddress.PostCode, y => y.MapFrom(z => z.PostCode))
            //    .ForMember(x => x.UserAddress.City, y => y.MapFrom(z => z.City));
            //CreateMap<AddUserRequest, UserAddress>();
            //CreateMap<AddUserRequest, UserContact>();
            //CreateMap<AddUserRequest, UserCard>();
        }
    }
}
