using Microsoft.AspNetCore.Mvc;


namespace JaskiniaGier.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
