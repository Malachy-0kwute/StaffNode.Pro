using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using StaffNode.Pro.UI.Models.Common;

namespace StaffNode.Pro.UI.Models
{
    public class ProfileDataModel : BaseEntity
    {
        public string Bio { get; set; } = string.Empty;
        //[Required(ErrorMessage = "Date of birth is required.")]
        //public DateTime DateOfBirth { get; set; }
    }
}
