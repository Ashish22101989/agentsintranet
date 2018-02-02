using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgentIntranet.DAL;
using AgentIntranet.DAL.Repositories;
using AgentIntranet.DAL.Data;
using System.Data.Entity;
using AgentIntranet.Model;

namespace AgentIntranet.WebUI.Controllers
{
    public class HomeController : Controller
    {
        CustomerRepository cust = new CustomerRepository(new DataContext());

        public ActionResult Index()
        {
            //CustomerRepository cust = new CustomerRepository(new DataContext());
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