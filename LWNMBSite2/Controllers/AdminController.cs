using LWNMB.Domain;
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
            List<LWNMB.Domain.BoardMembers> members = db.BoardMembers.Include("BoardPositions").ToList();
            
            return View(members);
        }


      
    }
}