using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace careerService.Models
{
    public class Subject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }
        [BsonElement("code")]
        public string Code { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("department")]
        public string Department { get; set; }
        [BsonElement("credits")]
        public int Credits { get; set; }
        [BsonElement("semester")]
        public int Semester { get; set; }
    }
}