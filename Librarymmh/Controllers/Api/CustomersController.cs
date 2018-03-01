using Librarymmh.Models;
using System.Web.Http;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Librarymmh.Dtos;
using System.Web.Mvc;

namespace Librarymmh.Controllers.Api
{
    public class CustomersController : ApiController
    {
        //we have to use the context to get the customer from the data base
        private ApplicationDbContext _dbContext;
        public CustomersController()
        {
            _dbContext = new ApplicationDbContext();
        }
        //because we are returning a list of object this action will be
        //this a convention build in to ASP.NET WEb APi
        //this action will give us the list of customers
        //GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customerquery = _dbContext.Customers.Include(c => c.MemberShipType);

            if (!string.IsNullOrWhiteSpace(query))
            {
                customerquery = customerquery.Where(c => c.Name.Contains(query));
            }

            var customerDtos = customerquery
                .ToList()
                .Select(Mapper.Map <Customer, CustomerDto>);
            return Ok(customerDtos);
        }


        //Get  /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }




        //Delete api/customers/1
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {

            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
