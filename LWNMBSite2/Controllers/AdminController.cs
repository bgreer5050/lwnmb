using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LWNMBSite2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {

            LWNMB.DAL.LWNMBContext db = new LWNMB.DAL.LWNMBContext();
            List<LWNMB.Domain.BoardMembers> board = db.BoardMembers.ToList();
          
         
            return View(board);
        }


        public ActionResult ShowBoardPositions()
        {
            LWNMB.DAL.LWNMBContext db = new LWNMB.DAL.LWNMBContext();
            LWNMB.Domain.BoardPosition bp = db.BoardPositions.Where(c => c.Title == "President").FirstOrDefault();


            //LWNMB.Domain.BoardMembers bm = db.BoardMembers.Where(c => c.FirstName == "Cyndi").FirstOrDefault();
            
            return View(bp.BoardMember);
        }


      
    }
}