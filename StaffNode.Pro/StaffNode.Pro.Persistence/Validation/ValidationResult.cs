using StaffNode.Pro.Application.Contracts.Validation;

namespace StaffNode.Pro.Persistence.Validation
{
    public class ValidationResult : IValidationResult
    {
        public bool IsValid => Errors.Any().Equals(false);

        public List<string> Errors { get; } = new List<string>();

        public ValidationResult(List<System.ComponentModel.DataAnnotations.ValidationResult> validationResults)
        {
            if (validationResults.Any())
            {
                var errors = validationResults.Select(result => result.ErrorMessage);
                if (errors is not null && errors.Any())
                {
                    Errors.AddRange(errors);
                }
            }
        }

    }
}
