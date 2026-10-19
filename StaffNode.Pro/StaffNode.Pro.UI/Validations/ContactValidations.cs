using FluentValidation;
using StaffNode.Pro.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffNode.Pro.UI.Validations
{
    public class ContactValidations : AbstractValidator<ContactDataModel>
    {
        public ContactValidations()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required.").WithErrorCode("City");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required.").WithErrorCode("Address");
            RuleFor(x => x.State).NotEqual("State").WithMessage("Please select a state.").WithErrorCode("State"); ;
            RuleFor(x => x.ZipCode).NotEmpty().WithMessage("Please enter your zip-code.").WithErrorCode("ZipCode");
            RuleFor(x => x.Email).EmailAddress().WithMessage("A valid email address is required.").WithErrorCode("Email");
            RuleFor(x => x.PhoneNumber).MaximumLength(10).WithMessage("Phone number is restricted to 10 digits only.").WithErrorCode("PhoneNumber");
            RuleFor(x => x.PhoneNumber).MinimumLength(10).WithMessage("Phone number is restricted to 10 digits minimum.").WithErrorCode("PhoneNumber");
        }
    }
}
