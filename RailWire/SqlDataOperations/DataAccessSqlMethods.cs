using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using SqlData;

namespace SqlDataOperations
{
    public class DataAccessSqlMethods : IDataAccessSqlMethods
    {
        TrainsDataEntities db = new TrainsDataEntities();
        public List<TrainHelperModel> GetDataFromSql()
        {
            List<Train> temp = db.Trains.ToList();
            List<TrainHelperModel> returneditems = new List<TrainHelperModel>();
            foreach (var item in temp)
            {
                TrainHelperModel val = new TrainHelperModel
                {
                    TrainId = item.TrainId,
                    TrainName = item.TrainName,
                    FromStation = item.FromStation,
                    ToStation = item.ToStation,
                    Time = item.Time
                };
                returneditems.Add(val);
            }
            return returneditems;
        }

        public void PostToSql(TrainHelperModel trainObj)
        {
            Train NewData = new Train
            {
                TrainId = trainObj.TrainId,
                TrainName = trainObj.TrainName,
                FromStation = trainObj.FromStation,
                ToStation = trainObj.ToStation,
                Time = trainObj.Time
            };
            db.Trains.Add(NewData);
            db.SaveChanges();
        }
    }
}
