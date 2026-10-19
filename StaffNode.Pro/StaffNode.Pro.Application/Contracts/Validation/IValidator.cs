namespace StaffNode.Pro.Application.Contracts.Validation
{
    public interface IValidator
    {
        IValidationResult Validate<T>(T entity) where T : class;
    }
}
