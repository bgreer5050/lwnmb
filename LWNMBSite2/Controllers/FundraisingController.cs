using LWNMB.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LWNMBSite2.Controllers
{
    public class FundraisingController : Controller
    {
        // GET: Fundraising
        public ActionResult Index()
        {
            LWNMB.DAL.LWNMBContext db = new LWNMB.DAL.LWNMBContext();
            //List<Event> events = db.Events.ToList();
            List<FundRaiser> fundraisers = db.FundRaisers.ToList();
            return View(fundraisers);
        }



        public ActionResult ScripCardProgram()
        {
            return View();
        }
    }
}