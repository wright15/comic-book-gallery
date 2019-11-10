using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ComicBookGallery2.Controllers
{
    public class IndexController : Controller
    {
        [System.Web.Mvc.Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Post()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}