using System;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Updates a single key/value entry in a MongoDB database using command line arguments
             * Usage: 'MongoUpdater.exe <server> <database> <collection> <search key> <search value> <update key> <update value>'
             * */

            MongoUrl url = new MongoUrl("mongodb://" + args[0] + ":27017");
            MongoClient client = new MongoClient(url);
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase(args[1]);

            var collection = db.GetCollection(args[2]);
            var query = new QueryDocument(args[3], args[4]);
            var item = collection.FindOne(query);

            item[args[5]] = args[6];
            collection.Save(item);
        }
    }
}
