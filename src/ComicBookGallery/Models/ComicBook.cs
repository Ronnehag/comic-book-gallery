using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public Series Series { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
          
            get
            {
                var series = Series; // Creating a local variable of the class Series
                if (series != null) // Checks if Series is not equal to null
                {
                    return Series.Title + " #" + IssueNumber; // Return matched Title and IssueNumber
                }
                else
                {
                    return null;
                }
            }
        }

        
        public string CoverImageFileName
        {
            get
            {
                var series = Series; // Create a variable of the class Series
                if (series != null)
                {
                    // series-title-issuenumber.jpg
                    return Series.Title.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
                }
                else
                {
                    return null;
                }
                

            }
        }
        
    }
}