﻿using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using DentistOffice.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentistOffice.ApplicationServices.API.Domain.Requests.User
{
    public class AddUserRequest : IRequest<AddUserResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public List<UserAddress> UserAddress { get; set; }
        //public List<UserContact> UserContact { get; set; }
        //public List<UserCard> UserCard { get; set; }

        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAllergy { get; set; }
        public bool IsDiabetes { get; set; }
        public bool IsHypertension { get; set; }
        public bool IsHeartDiseases { get; set; }
        public bool IsJaundice { get; set; }
        public bool IsPregnancy { get; set; }
        public bool IsCough { get; set; }
        public bool IsQuarantine { get; set; }
        public decimal BodyTemperature { get; set; }
    }
}
