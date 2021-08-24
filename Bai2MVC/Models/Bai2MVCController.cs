using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2MVC.Models
{
    public class Bai2MVCController : Controller
    {
        // GET: Bai2MVC

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
    }
}