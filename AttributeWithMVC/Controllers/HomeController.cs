using AttributeWithMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttributeWithMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Person person)
        {
            if (!ModelState.IsValid) 
            {
                return View(person);
            }

            
            ViewBag.ShowModal = true;
            return View();
        }
    }
}
