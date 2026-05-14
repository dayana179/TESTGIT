using Microsoft.AspNetCore.Mvc;
using TESTGIT.Models;

namespace TESTGIT.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Registration Successful!";
            }

            return View(model);
        }
    }
}