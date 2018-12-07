using Application.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Domain.Abstracts;

namespace Application.SqlOperations
{
    public class ApplicationSqlMethods : IApplicationSqlMethods
    {
        IDomainSqlMethods db;

        public ApplicationSqlMethods(IDomainSqlMethods db)
        {
            this.db = db;
        }
        public List<TrainHelperModel> GetDataFromSql()
        {
            return db.GetDataFromSql();
        }

        public void PostDataToSql(TrainHelperModel trainsqlObj)
        {
            db.PostDataToSql(trainsqlObj);
        }
    }
}
