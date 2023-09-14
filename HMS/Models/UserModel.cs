using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }=string.Empty;
        [BsonElement("firstname")]
        [BsonRequired]
        public String FirstName { get; set; }=String.Empty;

        [BsonElement("lastname")]
        [BsonRequired]
        public String LastName { get; set; } = String.Empty;

        [BsonElement("email")]
        [BsonRequired]
        [EmailAddress]
        public String Email { get; set; } = String.Empty;

        [BsonElement("phonenumber")]
        public String Phone { get; set; } = String.Empty;

        [BsonElement("gender")]
        public String Gender { get; set; } = String.Empty;
        [BsonElement("isactive")]
        public bool IsActive { get; set; } = true;

    }
}
