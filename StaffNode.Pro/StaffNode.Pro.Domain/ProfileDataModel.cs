using MongoDB.EntityFrameworkCore;
using StaffNode.Pro.Domain.Common;

namespace StaffNode.Pro.Domain
{
    [Collection("Profiles")]
    public class ProfileDataModel : BaseEntity
    {
        public string Bio { get; set; } = string.Empty;
        //[Required(ErrorMessage = "Date of birth is required.")]
        //public DateTime DateOfBirth { get; set; }
    }
}
