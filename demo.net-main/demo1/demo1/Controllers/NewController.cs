using demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class NewController : Controller
    {
        [Route("chi_tiet")]
        public IActionResult New()
        {
           
            New chitiet = new New()
            {

                Id = 1,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                text = "Tối 19/7, lễ trao giải truyền hình Rồng Xanh lần thứ 2 đã " +
                "diễn ra với sự góp mặt của " +
                "dàn sao hạng A đình đám nhất Hàn Quốc",

            }; 
         
        
            return View(chitiet);
        }
    }
}
