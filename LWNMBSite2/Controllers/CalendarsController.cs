using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LWNMBSite2.Controllers
{
    public class CalendarsController : Controller
    {
        // GET: Calendars
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult Test()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<iframe src=""https://www.google.com/calendar/embed?title=All%20Calendars&amp;");
            sb.Append(@"title=All%20Calendars&amp;");
            sb.Append(@"height=600&amp;");
            sb.Append(@"wkst=1&amp;");
            sb.Append(@"bgcolor=%23FFFFFF&amp;");
            sb.Append(@"src=ph5jqldab2rrjgnqrt5vifenng%40group.calendar.google.com&amp;color=%23865A5A&amp;");
            sb.Append(@"src=impb3nfciq01fsj6gtj9ldhjcg40group.calendar.google.com&amp;color=23875509&amp;");
            sb.Append(@"src=8rvh8bmgj7hvvcafcv6isbeb84%40group.calendar.google.com&amp;color=%2342104A&amp;");
            sb.Append(@"src=lwnmusicboosters%40gmail.com&amp;color=%236B3304&amp;");
            sb.Append(@"src=9jlrv30uqlp4pi2froe3ne329c%40group.calendar.google.com&amp;color=%231B887A&amp;");
            sb.Append(@"src=cl7qod3r3qf6ectndsg9nsjuf8%40group.calendar.google.com&amp;color=%235229A3&amp;");
            sb.Append(@"src=ln248apl4kh8rn9l1622ifoocs%40group.calendar.google.com&amp;color=%23875509&amp;");
            sb.Append(@"src=pcgaismkdri1jq852kiok72p68%40group.calendar.google.com&amp;color=%23182C57&amp;");
            sb.Append(@"src=p6mml0lthsnd93mdiamjlm8i6o%40group.calendar.google.com&amp;color=%232952A3&amp;");
            sb.Append(@"src=hrpj1o74p6c1msdd039j1temqc%40group.calendar.google.com&amp;color=%23B1440E&amp;");
            sb.Append(@"ctz=America%2FChicago"" style=""border-width:0");
            sb.Append(@""" width=""800"" height=""600""");
            sb.Append(@" frameborder='0'");
            sb.Append(@" scrolling='no'>");
            
            sb.Append(@"</iframe>");
           ViewBag.iframe = sb.ToString();
            return View();
        }
    }
}