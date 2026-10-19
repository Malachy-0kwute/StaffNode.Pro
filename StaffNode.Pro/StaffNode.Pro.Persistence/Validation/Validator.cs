using StaffNode.Pro.Application.Contracts.Validation;
using System.ComponentModel.DataAnnotations;

namespace StaffNode.Pro.Persistence.Validation
{
    public class Validator : IValidator
    {
        public IValidationResult Validate<T>(T entity) where T : class
        {
            var context = new ValidationContext(entity);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            System.ComponentModel.DataAnnotations.Validator
                .TryValidateObject(entity, context, results, validateAllProperties: true);

            var validationResults = new ValidationResult(results);

            return validationResults;
        }
    }
}
