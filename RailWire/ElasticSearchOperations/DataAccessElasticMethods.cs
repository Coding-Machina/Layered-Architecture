using DataAccess.Abstract;
using DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchOperations
{
    public class DataAccessElasticMethods : IDatatAccessElasticMethods
    {
        ElasticClient client = null;
        public DataAccessElasticMethods()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("traindata");

            client = new ElasticClient(settings);
        }



        //public IIndexResponse Post(TrainHelperModel trainObj)
        //{
        //    var request = new IndexRequest<Person>(person) { };

        //    var indexResponse = client.Index<Person>(request);
        //    return indexResponse;
        //}

        public IBulkResponse PostToElasticSearch(List<TrainHelperModel> trainObjs)
        {
            //var request = new IndexRequest<List<Person>>(people) { };
            var indexResponse = client.IndexMany<TrainHelperModel>(trainObjs);
            return indexResponse;
        }

        public List<TrainHelperModel> Search(string searchString)
        {
            var searchResponse = client.Search<TrainHelperModel>(s => s
                .From(0)
                .Size(10)
                .Query(q => q
                     .Match(m => m
                        .Field(f => f.TrainName)
                        .Query(searchString)
                     )
                )
            );

            return searchResponse.Documents.ToList();
        }

    }
}
