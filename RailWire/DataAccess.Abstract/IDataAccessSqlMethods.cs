using DTO;
using SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDataAccessSqlMethods
    {
        void PostToSql(TrainHelperModel trainObj);
        List<TrainHelperModel> GetDataFromSql();
    }
}
