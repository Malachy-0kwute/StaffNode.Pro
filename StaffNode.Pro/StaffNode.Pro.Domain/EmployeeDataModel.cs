using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;
using StaffNode.Pro.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace StaffNode.Pro.Domain
{
    [Collection("Employees")]
    public class EmployeeDataModel : BaseEntity
    {
        // ATTN DEV: The employee ID is different from the unique Id that identifies this object in the database
        public string EmployeeId { get; set; } = string.Empty;

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "First name must be a minimum of 2 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Last name must be a minimum of 2 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Last name must contain only letters.")]
        public string LastName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string? ProfileId { get; set; }
        public string? ContactId { get; set; } 
        public DateTime HireDate { get; set; } = DateTime.UtcNow.ToLocalTime();
        public DateTime? TerminationDate { get; set; }
    }
}
