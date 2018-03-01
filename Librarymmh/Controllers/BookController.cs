using Librarymmh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Librarymmh.ViewModel;
using System.IO;
using System.Web.UI.WebControls;

namespace Librarymmh.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext context;
        public BookController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Book
        public ActionResult Index()
        {
            var booksList = context.Books.Include(b =>b.Genre).ToList(); 
            return View(booksList);
        }

        public ActionResult New()
        {
            var genres = context.Genres.ToList();
            var viewModel = new NewBookViewModel
            {
                Genres = genres
            };
            return View(viewModel);
        }

        //display list of customers

        // GET: Customer
        

        //Create a new customer
        public ActionResult CreateBook()
        {
            return View(new Book());
        }


        //Post new customer to the server
        [HttpPost]
        public ActionResult CreateBook(Book book)
        {

            context.Books.Add(book);
            context.SaveChanges();

            return RedirectToAction("Index", "Book");
        }

        public ActionResult Edit(int id)
        {
            var book = context.Books.Include(b => b.Genre).SingleOrDefault(b => b.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            var viewModel = new NewBookViewModel()
            {
                Book = book,
                Genres = context.Genres.ToList()
            };
            return View("NewBookForm",viewModel);
        }

        public ActionResult Save(Book book,HttpPostedFileBase file)
        {
            var bookInDb = context.Books.SingleOrDefault(b => b.Id == book.Id);

            if (book.Id == 0)
            {
                context.Books.Add(book);

            }
            else
            {
                
                bookInDb.Name = book.Name;
                bookInDb.Image = book.Image;
                bookInDb.PublishedDate = book.PublishedDate;
                bookInDb.DateAdded = book.DateAdded;
                bookInDb.Description = book.Description;
                bookInDb.AuthorName = book.AuthorName;
                bookInDb.NumberAvailable = book.NumberAvailable;
                bookInDb.GenreId = book.GenreId;
            }
            
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                   

                }
                catch (Exception ex)
                {

                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }
            }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            context.SaveChanges();
            return RedirectToAction("Index","Book");
        }

        public ActionResult Details(int id)
        {
            var book = context.Books.Include(b => b.Genre).SingleOrDefault(b =>b.Id == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult Indexwebapi()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}