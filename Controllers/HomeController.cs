using Microsoft.AspNetCore.Mvc;

namespace Lecture49YT_MVC_Add_Students.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string myData = "This is my dummy data!";
            return View("Index",myData);
        }
    }
}
