using Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccess.Abstract;

namespace Domain.MongoOperations
{
    public class DomainMongoMethods : IDomainMongoMethods
    {
        IDataAccessMongoMethods db;

        public DomainMongoMethods(IDataAccessMongoMethods db)
        {
            this.db = db;
        }
        public void DeleteAllFromMongo()
        {
            db.DeleteAllFromMongo();
        }

        public List<TrainHelperModel> GetDataFromMongo()
        {
            return db.GetDataFromMongo();
        }
    }
}
