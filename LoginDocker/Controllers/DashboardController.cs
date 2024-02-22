using Microsoft.AspNetCore.Mvc;

namespace LoginDocker.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
