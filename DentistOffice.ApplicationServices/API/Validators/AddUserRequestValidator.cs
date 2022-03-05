using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using FluentValidation;

namespace DentistOffice.ApplicationServices.API.Validators
{
    public class AddUserRequestValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator()
        {
            this.RuleFor(x => x.FirstName).Length(3, 20).NotNull();
            this.RuleFor(x => x.LastName).Length(3, 20).NotNull();
            this.RuleFor(x => x.DateOfBirth).NotNull();

            this.RuleFor(x => x.Email).Length(5, 50).EmailAddress().NotNull();
            this.RuleFor(x => x.PhoneNumber).Length(6, 20).NotNull();

            this.RuleFor(x => x.Street).Length(3, 30).NotNull();
            this.RuleFor(x => x.StreetNumber).Length(1, 10).NotNull();
            this.RuleFor(x => x.PostCode).Length(5, 10).NotNull();
            this.RuleFor(x => x.City).Length(3, 20).NotNull();

            this.RuleFor(x => x.IsAllergy).NotNull();
            this.RuleFor(x => x.IsDiabetes).NotNull();
            this.RuleFor(x => x.IsHypertension).NotNull();
            this.RuleFor(x => x.IsHeartDiseases).NotNull();
            this.RuleFor(x => x.IsJaundice).NotNull();
            this.RuleFor(x => x.IsPregnancy).NotNull();
            this.RuleFor(x => x.IsCough).NotNull();
            this.RuleFor(x => x.IsQuarantine).NotNull();
            this.RuleFor(x => x.BodyTemperature).NotNull();   
        }
    }
}
