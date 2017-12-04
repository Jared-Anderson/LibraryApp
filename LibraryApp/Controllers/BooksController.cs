using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryApp.Models;

namespace LibraryApp.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Random()
        {
            var book = new Book() { Name = "Cat's Cradle" };
            return View(book);
        
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy)) {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("books/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}