using Microsoft.AspNetCore.Mvc;
//for pages of director
namespace MovieApp.Controllers
{
    public class MovieController:Controller
    {
        


         
        public IActionResult Index()
        {
            //TODO: View informations of movies
            return View();
        }

        public IActionResult Create()
        {
            //TODO: Create new movie or enrollment
            return View();
        }


        public IActionResult Details()
        {
            //TODO: View details of enrollment
            return View();
        }


    }
}