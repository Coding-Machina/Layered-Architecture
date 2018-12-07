using Application.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailWire.Controllers
{
    public class HomeController : Controller
    {
        IApplicationMongoMethods ctx;

        public HomeController(IApplicationMongoMethods ctx)
        {
            this.ctx = ctx;
        }
        public ActionResult Index()
        {
            return View(ctx.GetDataFromMongo());
        }

    }
}