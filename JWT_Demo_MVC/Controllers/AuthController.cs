using Microsoft.AspNetCore.Mvc;

namespace JWT_Demo_MVC.Controllers
{
    public class AuthController : Controller
    {
        [Route("/auth")]
        public IActionResult Auth()
        {
            return Content("Authentication success");
        }
    }
}
