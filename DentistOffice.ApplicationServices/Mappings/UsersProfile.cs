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
            CreateMap<AddUserRequest, User>()
                .ForMember(x => x.UserAddress, y => y.MapFrom(dto => new UserAddress()
                {
                    Street = dto.Street,
                    StreetNumber = dto.StreetNumber,
                    PostCode = dto.PostCode,
                    City = dto.City
                }))
                .ForMember(x => x.UserContact, y => y.MapFrom(dto => new UserContact()
                {
                    Email = dto.Email,
                    PhoneNumber = dto.PhoneNumber
                }));
                //.ForMember(x => x.UserCards, y => y.MapFrom(dto => new UserCard()));
                //{
                //    IsAllergy = dto.IsAllergy,
                //    IsDiabetes = dto.IsDiabetes,
                //    IsHypertension = dto.IsHypertension,
                //    IsHeartDiseases = dto.IsHeartDiseases,
                //    IsJaundice = dto.IsJaundice,
                //    IsPregnancy = dto.IsPregnancy,
                //    IsCough = dto.IsCough,
                //    IsQuarantine = dto.IsQuarantine,
                //    BodyTemperature = dto.BodyTemperature
                //}));
        }
    }
}
