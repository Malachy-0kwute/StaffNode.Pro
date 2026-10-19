using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StaffNode.Pro.Domain.Common
{
    public abstract class BaseEntity
    {
        [BsonId]
        //[BsonRepresentation(BsonType.String)]
        public string Id { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.ToLocalTime();
        public DateTime? LastModified { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
