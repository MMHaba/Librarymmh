using Librarymmh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Librarymmh.ViewModel;

namespace Librarymmh.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController()
        {
            dbContext = new ApplicationDbContext();
        }

        public ActionResult New()
        {
            var membershipTypes = dbContext.MemberShipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MemberShipTypes = membershipTypes
            };
            return View(viewModel);
        }

        //display list of customers

        // GET: Customer
        public ActionResult Index()
        {
            var listOfCustomers = dbContext.Customers.Include(c => c.MemberShipType).ToList();
            return View(listOfCustomers);
        }

        //Create a new customer
        public ActionResult CreateCustomer()
        {
            return View(new Customer());
        }


        //Post new customer to the server
        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
           
            return RedirectToAction("Index","Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = dbContext.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            
                return HttpNotFound();

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MemberShipTypes = dbContext.MemberShipTypes.ToList()
            };
            return View("NewCustomerForm", viewModel);
        }


        [HttpPost]
        public ActionResult Save(Customer customer)
        {
           
            if (customer.Id == 0)
            {
                dbContext.Customers.Add(customer);
            }
            else
            {
                var dbCustomer = dbContext.Customers.Single(c => c.Id == customer.Id);
                dbCustomer.Name = customer.Name;
                dbCustomer.Email = customer.Email;
                dbCustomer.DateOfBirth = customer.DateOfBirth;
                dbCustomer.StreetNumber = customer.StreetNumber;
                dbCustomer.StreetName = customer.StreetName;
                dbCustomer.CityName = customer.CityName;
                dbCustomer.PostalCode = customer.PostalCode;
                dbCustomer.MemberShipTypeId = customer.MemberShipTypeId;
            }

            dbContext.SaveChanges();
            return RedirectToAction("Index", "Customer");
           
        }
        public ActionResult Details(int id)
        {
            var customer = dbContext.Customers.Include(c => c.MemberShipType)
                .SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}