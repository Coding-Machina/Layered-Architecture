using DataAccess.Abstract;
using DTO;
using MongoData;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace MongoDataOperations
{
    public class DataAccessMongoMethods : IDataAccessMongoMethods
    {
        MongoContext db = new MongoContext();
        public void DeleteAllFromMongo()
        {
            db.TrainMongoCollection.DeleteMany(p => p.TrainId > 0);
        }

        public List<TrainHelperModel> GetDataFromMongo()
        {
            IQueryable<TrainMongo> List = db.TrainMongoCollection.AsQueryable();
            List<TrainHelperModel> ReturnedObjects = new List<TrainHelperModel>();
            foreach (var item in List)
            {
                TrainHelperModel temp = new TrainHelperModel
                {
                    TrainId = item.TrainId,
                    TrainName = item.TrainName,
                    FromStation = item.FromStation,
                    ToStation = item.ToStation,
                    Time = item.Time
                };
                ReturnedObjects.Add(temp);
            }
            return ReturnedObjects;
        }

        public void PostDataToMongo(List<TrainHelperModel> Datas)
        {
            List<TrainMongo> List = new List<TrainMongo>();
            foreach (var item in Datas)
            {
                TrainMongo temp = new TrainMongo
                {
                    TrainId = item.TrainId,
                    TrainName = item.TrainName,
                    FromStation = item.FromStation,
                    ToStation = item.ToStation,
                    Time = item.Time
                };
                List.Add(temp);
            }
            db.TrainMongoCollection.InsertMany(List);
        }
    }
}
