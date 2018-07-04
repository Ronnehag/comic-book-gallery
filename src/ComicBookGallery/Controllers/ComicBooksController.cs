using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // Private instance of the class ComicBookRepository set to null
        private ComicBookRepository _comicBookRepository = null;

        // Creates a new ComicBookrepository set to the private instance
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id) // MVC can pass null if ID isn't provided.
        {
            if( id == null)
            {
                return HttpNotFound();
            }
            // Returns the ID value from the repository
            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}