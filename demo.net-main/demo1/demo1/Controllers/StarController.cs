using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class StarController : Controller
    {

        [Route("star")]
        public IActionResult Star()
        {
           
            return View();

        }
    }
}
