using Application.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Domain.Abstracts;

namespace Application.MongoOperations
{
    public class ApplicationMongoMethods : IApplicationMongoMethods
    {
        IDomainMongoMethods db;

        public ApplicationMongoMethods(IDomainMongoMethods db)
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
