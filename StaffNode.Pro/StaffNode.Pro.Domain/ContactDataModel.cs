using MongoDB.EntityFrameworkCore;
using StaffNode.Pro.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace StaffNode.Pro.Domain
{
    [Collection("Contacts")]
    public class ContactDataModel : BaseEntity
    {
        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Phone number must be exactly 10 digits.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Zip code is required.")]
        public string ZipCode { get; set; } = string.Empty;
    }
}