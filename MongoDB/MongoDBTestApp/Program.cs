using System;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBTestApp{


    public class Student{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get; set ;}
        public string name{get ; set;}
        public string LastName{get ;set;}
        
    }

    class program{
        public static void Main(string[] args){
            List<Student> list =new List<Student>();
            var _mongoClient =new MongoClient("mongodb://localhost:27017");
            var db=_mongoClient.GetDatabase("transflower");
            var collection =db.GetCollection<Student>("students");
            collection.Find(_=>true).ToList().ForEach(
                Students=>{
                    Console.WriteLine(Students.name);
                    Console.WriteLine(Students.LastName);
                    
                }
            );
        }
    }
}