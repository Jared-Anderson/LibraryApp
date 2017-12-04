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
    }
}