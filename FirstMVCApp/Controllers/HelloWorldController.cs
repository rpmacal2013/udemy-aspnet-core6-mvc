using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Hello()
        {
            DogViewModel doggy = new DogViewModel()
            {
                Name = "Sultán",
                Age = 6
            };

            return View(doggy);
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {   
            dogs.Add(dogViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}
