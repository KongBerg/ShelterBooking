using MongoDB.Bson;
using MongoDB.Driver;

namespace ShelterBooking
{
    public class PShelter
    {
        private string ConnectionString = "mongodb+srv://Berg:Ept89vxtN@cluster0.77eu8xj.mongodb.net/"; //forbinder til Cluster

        IMongoClient dbClient;

        IMongoDatabase database;

        IMongoCollection<BsonDocument> collection;


        public PShelter()
        {
            dbClient = new MongoClient(ConnectionString); //refarer til forbindelsen til Cluster

            database = dbClient.GetDatabase("ShelterDB"); //vælger hvilken Database

            collection = database.GetCollection<BsonDocument>("shelter_minus"); //vælger Collection
        }


    }
}
