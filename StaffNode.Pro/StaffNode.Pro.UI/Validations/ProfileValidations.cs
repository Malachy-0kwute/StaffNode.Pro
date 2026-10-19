using FluentValidation;
using StaffNode.Pro.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffNode.Pro.UI.Validations
{
    /// <summary>
    /// ATTN DEV: Not obsolete
    /// </summary>
    [Obsolete("no validation for profile at the moment. (Maybe in the future)")]
    public class ProfileValidations : AbstractValidator<ProfileDataModel>
    {
        public ProfileValidations()
        {
            //RuleFor(x => x.Bio)
        }
    }
}
