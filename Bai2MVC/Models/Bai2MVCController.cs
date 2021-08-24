using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2MVC.Models;

namespace Bai2MVC.Models
{
    public class Bai2MVCController : Controller
    {
        // GET: Bai2MVC
        GiaiPT PTBN = new GiaiPT();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double hsA, double hsB)
        {
            double X = PTBN.GiaiPTBN(hsA, hsB);
            ViewBag.nghiemPT = X;
            return View();
        }

    }
}