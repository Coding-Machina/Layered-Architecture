using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDataAccessMongoMethods
    {
        List<TrainHelperModel> GetDataFromMongo();
        void DeleteAllFromMongo();
        void PostDataToMongo(List<TrainHelperModel> Datas);
    }
}
