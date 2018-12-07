using Application.Abstracts;
using DTO;
using RailWire.Connector;
using RailWire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailWire.Controllers
{
    public class SearchController : Controller
    {
        IApplicationTransferMethods db;
        public SearchController(IApplicationTransferMethods db)
        {
            this.db = db;
        }

        public ActionResult Search()
        {
            return View();
        }
        
    }
}