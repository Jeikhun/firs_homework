using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController:Controller
    {
        public ViewResult Index()
        {
            ViewBag.Name = "Jeikhun";
            ViewBag.Surname = "Jalilov";
            ViewBag.Age = "21";
            ViewBag.Country = "Georgia";
            ViewBag.PhoneNumber = "+994708978997";

            return View();

        }
    }
}
