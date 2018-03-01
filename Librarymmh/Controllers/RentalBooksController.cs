using System.Web.Mvc;

namespace Librarymmh.Controllers
{
    public class RentalBooksController : Controller
    {
        // GET: RentalBooks
        public ActionResult New()
        {
            return View();
        }
    }
}