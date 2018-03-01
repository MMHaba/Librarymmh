using Librarymmh.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Librarymmh.Dtos;

namespace Librarymmh.Controllers.Api
{
    public class BooksController : ApiController
    {
        ApplicationDbContext dbContext;

        public BooksController()
        {
            dbContext = new ApplicationDbContext();
        }


        //api/Books
        public IHttpActionResult GetBooks(string query = null)
        {
            var books = dbContext.Books
                .Include(b => b.Genre)
                .Where(b => b.NumberAvailable > 0);
            if (!string.IsNullOrWhiteSpace(query))
            {
                books = books.Where(b => b.Name.Contains(query));
            }

            var booksDtos = books
                            .ToList()
                            .Select(Mapper.Map<Book, BookDto>);
            return Ok(booksDtos);
        }
        
        //delete book
        public IHttpActionResult DeleteBook(int id)
        {
            var book = dbContext.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();

            return Ok();
        }

    }
}


