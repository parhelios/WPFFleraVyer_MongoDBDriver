using MongoDB.Bson;

namespace DataAccess.Entities;

public class Person
{
    public ObjectId Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;


}