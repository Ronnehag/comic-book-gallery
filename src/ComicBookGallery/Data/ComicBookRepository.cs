using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        

        // Returns array of all comic books
        public ComicBook[] GetComicBooks()
        {
            return Data.ComicBooks;
        }

        // Returns a ComicBook-model instance
        public ComicBook GetComicBook(int id) 
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in Data.ComicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }

            return comicBookToReturn;
        }

    }
}