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
            CreateMap<User, UserDto>()
                .ForMember(x => x.FirstName, y => y.MapFrom(z => z.FirstName))
                .ForMember(x => x.LastName, y => y.MapFrom(z => z.LastName))
                .ForMember(x => x.DateOfBirth, y => y.MapFrom(z => z.DateOfBirth))
                .ForMember(x => x.Street, y => y.MapFrom(z => z.UserAddress.Street))
                .ForMember(x => x.StreetNumber, y => y.MapFrom(z => z.UserAddress.StreetNumber))
                .ForMember(x => x.PostCode, y => y.MapFrom(z => z.UserAddress.PostCode))
                .ForMember(x => x.City, y => y.MapFrom(z => z.UserAddress.City))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.UserContact.Email))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.UserContact.PhoneNumber))
                .ForMember(x => x.IsAllergy, y => y.MapFrom(z => z.UserCard.IsAllergy))
                .ForMember(x => x.IsDiabetes, y => y.MapFrom(z => z.UserCard.IsDiabetes))
                .ForMember(x => x.IsHypertension, y => y.MapFrom(z => z.UserCard.IsHypertension))
                .ForMember(x => x.IsHeartDiseases, y => y.MapFrom(z => z.UserCard.IsHeartDiseases))
                .ForMember(x => x.IsJaundice, y => y.MapFrom(z => z.UserCard.IsJaundice))
                .ForMember(x => x.IsPregnancy, y => y.MapFrom(z => z.UserCard.IsPregnancy))
                .ForMember(x => x.IsCough, y => y.MapFrom(z => z.UserCard.IsCough))
                .ForMember(x => x.IsQuarantine, y => y.MapFrom(z => z.UserCard.IsQuarantine))
                .ForMember(x => x.BodyTemperature, y => y.MapFrom(z => z.UserCard.BodyTemperature));
            

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
                }))
                .ForMember(x => x.UserCard, y => y.MapFrom(dto => new UserCard()
                {
                    IsAllergy = dto.IsAllergy,
                    IsDiabetes = dto.IsDiabetes,
                    IsHypertension = dto.IsHypertension,
                    IsHeartDiseases = dto.IsHeartDiseases,
                    IsJaundice = dto.IsJaundice,
                    IsPregnancy = dto.IsPregnancy,
                    IsCough = dto.IsCough,
                    IsQuarantine = dto.IsQuarantine,
                    BodyTemperature = dto.BodyTemperature
                }));

            CreateMap<UpdateUserRequest, User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.userId))
                .ForMember(x => x.FirstName, y => y.MapFrom(z => z.FirstName))
                .ForMember(x => x.LastName, y => y.MapFrom(z => z.LastName))
                .ForMember(x => x.DateOfBirth, y => y.MapFrom(z => z.DateOfBirth));
            CreateMap<UpdateUserRequest, UserAddress>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.userId))
                .ForMember(x => x.Street, y => y.MapFrom(z => z.Street))
                .ForMember(x => x.StreetNumber, y => y.MapFrom(z => z.StreetNumber))
                .ForMember(x => x.PostCode, y => y.MapFrom(z => z.PostCode))
                .ForMember(x => x.City, y => y.MapFrom(z => z.City));
            CreateMap<UpdateUserRequest, UserContact>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.userId))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.PhoneNumber));
            CreateMap<UpdateUserRequest, UserCard>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.userId))
                .ForMember(x => x.IsAllergy, y => y.MapFrom(z => z.IsAllergy))
                .ForMember(x => x.IsDiabetes, y => y.MapFrom(z => z.IsDiabetes))
                .ForMember(x => x.IsHypertension, y => y.MapFrom(z => z.IsHypertension))
                .ForMember(x => x.IsHeartDiseases, y => y.MapFrom(z => z.IsHeartDiseases))
                .ForMember(x => x.IsJaundice, y => y.MapFrom(z => z.IsJaundice))
                .ForMember(x => x.IsPregnancy, y => y.MapFrom(z => z.IsPregnancy))
                .ForMember(x => x.IsCough, y => y.MapFrom(z => z.IsCough))
                .ForMember(x => x.IsQuarantine, y => y.MapFrom(z => z.IsQuarantine))
                .ForMember(x => x.BodyTemperature, y => y.MapFrom(z => z.BodyTemperature));

            CreateMap<DeleteUserRequest, User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.UserId));
        }
    }
}
