using DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDatatAccessElasticMethods
    {
        IBulkResponse PostToElasticSearch(List<TrainHelperModel> trainObjs);
        List<TrainHelperModel> Search(string searchString);
    }
}
