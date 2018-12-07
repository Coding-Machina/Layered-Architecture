using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstracts
{
    public interface IApplicationSqlMethods
    {
        void PostDataToSql(TrainHelperModel trainsqlObj);
        List<TrainHelperModel> GetDataFromSql();
    }
}
