using Librarymmh.Dtos;
using Librarymmh.Models;
using System;
using System.Linq;
using System.Web.Http;


namespace Librarymmh.Controllers.Api
{
    public class NewBookRentalsController : ApiController
    {
        private ApplicationDbContext context;

        //Constructor
        public NewBookRentalsController()
        {
            context = new ApplicationDbContext();
        }


        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //second edge cases if we dont have book Id
            //if (newRental.BookIds.Count == 0)
            //    return BadRequest("No books Ids have been give.");
            //we use sigle or default because of edge cases
            //this wana be or first edge cases
            //book id is invalid
            //First we get the customer from the context
            var customer = context.Customers.Single(
                c => c.Id == newRental.CustomerId);
            //for external API
            if (customer == null)
            {
                return BadRequest("Customer Id is not valid.");
            }
            //we get movies
            var books = context.Books.Where(
                m => newRental.BookIds.Contains(m.Id)).ToList();
            //if one ore more book are invalid
            //if (movies.Count != newRental.BookIds.Count)
            //{
            //    return BadRequest("One or more book Ids are invalid");
            //}
            foreach (var book in books)
            {
                if (book.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available");
                }
                book.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Book = book,
                    DateRented = DateTime.Now,
                    DateReturned = DateTime.Now.AddDays(15)
                };
                context.Rentals.Add(rental);
            }
            context.SaveChanges();
            return Ok();
        }
    }
}
