using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class SeriesController : Controller
    {
        private SeriesRepository _seriesRepository = null;

        public SeriesController()
        {
            _seriesRepository = new SeriesRepository();
        }

        public ActionResult Index()
        {
            var series = _seriesRepository.GetSeries();

            return View(series);
        }

        public ActionResult Detail(int? id) // Makes i 'Nullable'
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Loops the Series[] to find matching ID
            var series = _seriesRepository.GetSeriesDetail(id.Value);

            return View(series);
        }
    }
}