using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnightsWatch_PortfolioMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult GridDemo()
        {
            return View();
        }

        public ActionResult Add2Nums()
        {
            return View();
        }

        public ActionResult CooleysAction()
        {
            return View();
        }

    }
}