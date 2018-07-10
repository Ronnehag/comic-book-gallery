using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class SeriesRepository
    {

        // Gets an array of object Series.
        public Series[] GetSeries()
        {
            return Data.Series;
        }

        // Gets a single object of Series.
        public Series GetSeriesDetail(int id)
        {
            Series seriesToReturn = null; // initialize instance to null.

            foreach (var series in Data.Series) // Loop the array of Data.Series
            {
                if(series.Id == id) // Checks for matching ID
                {
                    seriesToReturn = series; // Sets the matching object equal to the declared instance.
                    break;
                }
            }
            if (seriesToReturn != null)
            {
                var comicBooks = new ComicBook[0];

                foreach( var comicBook in Data.ComicBooks)
                {
                    if(comicBook.Series != null && comicBook.Series.Id == id)
                    {
                        Array.Resize(ref comicBooks, comicBooks.Length + 1);
                        comicBooks[comicBooks.Length - 1] = comicBook;
                    }
                }
                seriesToReturn.Issues = comicBooks;
            }

            return seriesToReturn; // Returns that instance, return null if false.
        }
    }
}