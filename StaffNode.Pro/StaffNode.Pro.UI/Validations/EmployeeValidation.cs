using FluentValidation;
using StaffNode.Pro.UI.Models;

namespace StaffNode.Pro.UI.Validations
{
    public class EmployeeValidation : AbstractValidator<EmployeeDataModel>
    {
        public EmployeeValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required.").WithErrorCode("Firstname");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required.").WithErrorCode("Lastname");
            RuleFor(x => x.JobTitle).NotEqual("Job title").WithMessage("Please select a job title.").WithErrorCode("JobTitle");
            RuleFor(x => x.Department).NotEqual("Department").WithMessage("Please select a department.").WithErrorCode("Department");
            RuleFor(x => x.Salary).GreaterThan(-1).WithMessage("Salary must be greater that -1.").WithErrorCode("Salary");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("Enter salary value.").WithErrorCode("Salary");
        }
    }
}
