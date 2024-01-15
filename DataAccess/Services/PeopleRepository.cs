using System.Runtime.InteropServices.ComTypes;
using Common.DTO;
using DataAccess.Enteties;
using MongoDB.Bson;
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
        _people = database.GetCollection<Person>("People", new MongoCollectionSettings { AssignIdOnInsert = true });
    }

    public void AddPerson(PersonRecord personRecord)
    {
        var newPerson = new Person()
        {
            FirstName = personRecord.FirstName,
            LastName = personRecord.LastName
        };

        _people.InsertOne(newPerson);

        //var filter = Builders<Person>.Filter
        //    .Eq("FirstName", firstName);
        //var personSaved = _people
        //    .Find(filter).FirstOrDefault();

        //return personSaved.Id.ToString();
    }

    public List<PersonRecord> GetAllPeople()
    {
        var filter = Builders<Person>.Filter.Empty;
        //var allPeople = _people.Find(_ => true); //alternativ hantering för det nedre, där man inte behöver använda filter
        //var allPeople = _people
        //    .Find(filter).ToList();

        var allPeople = _people
            .Find(filter).ToList()
            .Select(p => new PersonRecord(
                p.Id.ToString(), 
                p.FirstName, 
                p.LastName)
            );

        return allPeople.ToList();
    }

    public PersonRecord UpdateLastNameForPerson(string id, string newLastName)
    {
        var filter = Builders<Person>.Filter
            .Eq("_id", ObjectId.Parse(id));
        var update = Builders<Person>.Update
                .Set(person => person.LastName, newLastName)
            /*.Set(person => person.FirstName, newFirstname)*/; //för att demonstrera att det går att bygga för att sätta flera olika värden

        _people.UpdateOne(filter, update);

        var updatedPerson = _people.Find(filter).FirstOrDefault();

        return new PersonRecord(updatedPerson.Id.ToString(), updatedPerson.FirstName, updatedPerson.LastName);
    }

    public void DeletePerson(string id)
    {
        var filter = Builders<Person>.Filter
            .Eq("FirstName", firstName);
        _people.DeleteOne(filter);
    }

}