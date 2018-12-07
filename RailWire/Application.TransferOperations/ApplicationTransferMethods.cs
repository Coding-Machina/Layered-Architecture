using Application.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Domain.Abstracts;

namespace Application.TransferOperations
{
    public class ApplicationTransferMethods : IApplicationTransferMethods
    {
        IDomainTransferMethods db;

        public ApplicationTransferMethods(IDomainTransferMethods db)
        {
            this.db = db; 
        }
        public void MapDataFromSqlToMongo(List<TrainHelperModel> SqlObj)
        {
            db.MapDataFromSqlToMongo(SqlObj);
        }
        public void TransferDataFromSqlToElasticSearch(List<TrainHelperModel> SqlObjs)
        {
            db.TransferDataFromSqlToElasticSearch(SqlObjs);
        }
        public List<TrainHelperModel> Search(string word)
        {
           return db.Search(word);
        }
    }
}
