using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PhoneModels.Models;

public class Phone
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public decimal Price { get; set; }
}
