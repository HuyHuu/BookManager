using Lab03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03.Controllers
{
    public class BookController : Controller
    {
        
        
        // GET: Book
        public ActionResult ListBook()
        {
            
            BookManagerContext context = new BookManagerContext();
            var listbook = context.Books.ToList();          
            return View(listbook);
        }
        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [Authorize]
        public ActionResult Create()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            return View();

        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBook.Find(p => p.ID == id);
            if (book == null)
                return HttpNotFound();

            return View(book);
            
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            
            
            
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBook.Find(p => p.ID == id);
            if (book == null)
                return HttpNotFound();

            return View(book);
        }

    }
}