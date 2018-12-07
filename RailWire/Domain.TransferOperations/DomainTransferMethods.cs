using Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccess.Abstract;
using System.Diagnostics;

namespace Domain.TransferOperations
{
    public class DomainTransferMethods : IDomainTransferMethods
    {
        IDataAccessMongoMethods db;
        IDatatAccessElasticMethods elastcDb;

        public DomainTransferMethods(IDataAccessMongoMethods db, IDatatAccessElasticMethods elastcDb)
        {
            this.db = db;
            this.elastcDb = elastcDb;
        }
        public void MapDataFromSqlToMongo(List<TrainHelperModel> SqlObj)
        {
            db.PostDataToMongo(SqlObj);
        }
        public void TransferDataFromSqlToElasticSearch(List<TrainHelperModel> SqlObj)
        {
            elastcDb.PostToElasticSearch(SqlObj);
        }
        public List<TrainHelperModel> Search(string searchWord)
        {
           return elastcDb.Search(searchWord);
        }
    }
}
