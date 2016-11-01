using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Overdue()
        {
            //List<Movie> omovies = new List<Movie>();

            //MoviesEntities1 db = new MoviesEntities1();
            

            //var OverDueMovies = from c in db.RentalRecords
            //                    where c.DueDate < DateTime.Today
            //                    select c;

            //foreach (RentalRecord c in OverDueMovies)
            //{
            //    Movie movie1 = new Movie();

            //    omovies.Add(movie1);
                
            //}

            return View();
        }
    }
}