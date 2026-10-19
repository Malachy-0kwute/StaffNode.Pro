using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StaffNode.Pro.UI.Models.Common
{
    public abstract class BaseEntity
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastModified { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
