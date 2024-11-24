using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace careerService.Models
{
    public class Career
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("name")]
        public string Name { get; set; } = null!;
    }
}

