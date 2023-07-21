using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class SpaController : Controller
    {
        [Route("spa.com")]
        public IActionResult Spa()
        {
            return View();
        }
    }
}
