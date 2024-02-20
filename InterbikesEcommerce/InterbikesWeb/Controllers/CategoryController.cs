using Microsoft.AspNetCore.Mvc;

namespace InterbikesWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
