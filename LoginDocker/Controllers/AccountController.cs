using LoginDocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginDocker.Controllers
{
    public class AccountController : Controller
    {
        // Simulated user data (replace with your actual authentication logic)
        private readonly User _user = new User
        {
            Id = 1,
            Username = "sam",
            Password = "sam@123"
        };

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == _user.Username && model.Password == _user.Password)
                {
                    // Successful login, redirect to dashboard
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }

            // If we reach here, either the model state was invalid or the credentials were incorrect
            return View(model);
        }
    }
}
