using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Jobaline.Code;
using Jobaline.Models;
using Newtonsoft.Json;

namespace Jobaline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetSportNews()
        {
            List<Link> results = new HomeModel().GetLinks("http://news.yahoo.com/rss/sports");
            return Json(new { results = JsonConvert.SerializeObject(results) }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetEntertainmentNews()
        {
            List<Link> results = new HomeModel().GetLinks("http://news.yahoo.com/rss/entertainment");
            return Json(new { results = JsonConvert.SerializeObject(results) }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetTechNews()
        {
            List<Link> results = new HomeModel().GetLinks("http://news.yahoo.com/rss/tech");
            return Json(new { results = JsonConvert.SerializeObject(results) }, JsonRequestBehavior.AllowGet);
        }
    }
}
