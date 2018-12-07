using MongoData.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoData
{
    public class MongoContext
    {
        public IMongoDatabase Database;
        public MongoContext()
        {
            var ConnectionString = Settings.Default.ConnectionString;
            var settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
            var Client = new MongoClient(settings);
            Database = Client.GetDatabase(Settings.Default.DatabaseName);
        }
        public IMongoCollection<TrainMongo> TrainMongoCollection => Database.GetCollection<TrainMongo>("TrainData1");
    }
}
