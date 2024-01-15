﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataAccess.Enteties;

public class Person
{
    public ObjectId Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}