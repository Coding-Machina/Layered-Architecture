using Application.Abstracts;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RailWire.Controllers
{
    public class TrainWebApiController : ApiController
    {
        IApplicationTransferMethods db;
        IApplicationMongoMethods mongodb;
        public TrainWebApiController(IApplicationTransferMethods db, IApplicationMongoMethods mongodb)
        {
            this.db = db;
            this.db = db;
        }
        [HttpGet]
        public IHttpActionResult Search(string id)
        {
            return Ok(db.Search(id));
        }

        [HttpGet]
        public IHttpActionResult GetTrains()
        {
            return Ok(mongodb.GetDataFromMongo());
        }
    }
}
