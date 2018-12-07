using Application.Abstracts;
using DTO;
using Hangfire;
using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailWire.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        IApplicationSqlMethods ctx;
        IApplicationMongoMethods mongo;
        IApplicationTransferMethods transfer;
        public AdminController(IApplicationSqlMethods ctx, IApplicationMongoMethods mongo, IApplicationTransferMethods transfer)
        {
            this.ctx = ctx;
            this.mongo = mongo;
            this.transfer = transfer;
        }
        // GET: Admin
        public ActionResult Index()
        {
            dynamic email = new Email("AdminMail");
            email.To = "harikrishnan.s@pitsolutions.com";
            email.Send();
            return View(ctx.GetDataFromSql());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainId,TrainName,FromStation,ToStation,Time")] TrainHelperModel newTrainData)
        {
            if (ModelState.IsValid)
            {
                ctx.PostDataToSql(newTrainData);

                BackgroundJob.Enqueue(() => PostData());
                BackgroundJob.Enqueue(() => PostDataToElasticSearch());

                return RedirectToAction("Index");
            }

            return View(newTrainData);
        }

        public ActionResult PostData()
        {
            List<TrainHelperModel> ReturnedData = ctx.GetDataFromSql();
            mongo.DeleteAllFromMongo();
            transfer.MapDataFromSqlToMongo(ReturnedData);

            return RedirectToAction("Index");
        }

        public void PostDataToElasticSearch()
        {
            List<TrainHelperModel> ReturnedDatas = ctx.GetDataFromSql();
            transfer.TransferDataFromSqlToElasticSearch(ReturnedDatas);
        }
    }
}