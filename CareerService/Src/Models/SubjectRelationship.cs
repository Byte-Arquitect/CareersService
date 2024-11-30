using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace careerService.Models
{
    public class SubjectRelationship
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        [BsonElement("SubjectCode")]
        public string SubjectCode { get; set; }
        [BsonElement("PreSubjectCode")]
        public string PreSubjectCode { get; set; }
    }
}