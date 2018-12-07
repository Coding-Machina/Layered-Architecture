using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstracts
{
    public interface IDomainMongoMethods
    {
        List<TrainHelperModel> GetDataFromMongo();
        void DeleteAllFromMongo();
    }
}
