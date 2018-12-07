using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstracts
{
    public interface IDomainTransferMethods
    {
        void MapDataFromSqlToMongo(List<TrainHelperModel> SqlObj);
        void TransferDataFromSqlToElasticSearch(List<TrainHelperModel> SqlObjs);
        List<TrainHelperModel> Search(string searchWord);
    }
}
