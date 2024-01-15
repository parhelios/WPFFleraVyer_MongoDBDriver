using DataAccess.Enteties;
using MongoDB.Driver;

namespace DataAccess.Services;

public class PeopleRepository
{
    private readonly IMongoCollection<Person> _people;

    public PeopleRepository()
    {
        var hostName = "localhost";
        var port = "27017";
        var databaseName = "PeopleDb";
        var client = new MongoClient($"mongodb://{hostName}:{port}");
        var database = client.GetDatabase(databaseName);
        _people = database.GetCollection<Person>("People", new MongoCollectionSettings() { AssignIdOnInsert = true });
    }


}