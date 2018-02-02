using AgentIntranet.Contracts.Repository;
using AgentIntranet.DAL.Data;
using AgentIntranet.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgentIntranet.UI.Controllers
{
    public class CustomerController : Controller
    {
        private IRepositoryBase<Customer> customer;
        // GET: Customer



        public CustomerController(IRepositoryBase<Customer> customer)
        {

            this.customer = customer;
        }
        public ActionResult Index()
        {
            var model = customer.GetAll();

            return View(model);
        }
        public ActionResult Create()
        {
            var cust = new Customer();
            return View(cust);
        }
        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            customer.Insert(cust);
            customer.Commit(cust);
            return RedirectToAction("Index");
        }
    }
}