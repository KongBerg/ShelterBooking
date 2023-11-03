using MongoDB.Bson
using MongoDB.Driver
using MongoDB.Driver.Core.Configuration;

namespace ShelterBooking.Shared
{
    public static void Main2(string[] args)
    { 


         List<BsonDocument> GetAll()
            {
                return collection.Find(Shelter_Info())
            }
    }
}
