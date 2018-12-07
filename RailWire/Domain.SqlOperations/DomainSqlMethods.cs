using Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccess.Abstract;

namespace Domain.SqlOperations
{
    public class DomainSqlMethods : IDomainSqlMethods
    {
        IDataAccessSqlMethods db;
        public DomainSqlMethods(IDataAccessSqlMethods db)
        {
            this.db = db;
        }
        public List<TrainHelperModel> GetDataFromSql()
        {
            return db.GetDataFromSql();
        }

        public void PostDataToSql(TrainHelperModel trainsqlObj)
        {
            db.PostToSql(trainsqlObj);
        }
    }
}
