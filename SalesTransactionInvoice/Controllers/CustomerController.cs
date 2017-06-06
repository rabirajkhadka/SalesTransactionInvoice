using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesTransactionInvoice.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        //Get Customers Details
        public ActionResult GetCustomer()
        {
            return View();
        }

        //REtrieve data from Jquery
        public JsonResult GetAllData()
        {
            List<Customer> allCustomer = new List<Customer>();

            using (InvoicedBEntities idbc = new InvoicedBEntities())
            {
                allCustomer = idbc.Customers.ToList();

            }
            return new JsonResult { Data = allCustomer, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        //REtrieve data with parameter from Jquery
        public JsonResult GetCustomerDatawithparameter(string prefix)
        {
            List<Customer> allCustomer = new List<Customer>();

            using (InvoicedBEntities idbc = new InvoicedBEntities())
            {
                allCustomer = idbc.Customers.Where(name=>name.Customer_NAME.Contains(prefix)).ToList();

            }
            return new JsonResult { Data = allCustomer, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}