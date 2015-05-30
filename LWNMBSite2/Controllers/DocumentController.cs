using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LWNMBSite2.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPdf(string filename)
        {
           // return Server.MapPath("/Documents/BoosterMembershipForm.pdf").ToString();
            filename = @"~/Content/Documents/" + filename;
            return File(filename, "application/pdf");
        }
    }
}