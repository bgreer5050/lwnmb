
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LWNMBSite2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            LWNMB.Domain.BoardMembers bm = new LWNMB.Domain.BoardMembers();
            try
            {
                bm.EmailAddress = "test@test.com";
                bm.FirstName = "John";
                bm.LastName = "Doe";
                bm.PhoneNumber = "555-555-1212";

                LWNMB.DAL.LWNMBContext context = new LWNMB.DAL.LWNMBContext();
                context.BoardMembers.Add(bm);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return View(bm);
        }

        public ActionResult Index2()
        {
          

            return View();
        }

        public ActionResult Index4()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}