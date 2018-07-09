using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class Series
    {
        public int Id { get; set; } // Sets ID for the Series
        public string Title { get; set; } // Sets Title for the Series
        public string DescriptionHtml { get; set; } // Sets the Description for the Series
        public ComicBook[] Issues {get; set;} // Containing the ComicBook objects per issue
    }
}