using demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class CineController : Controller
    {
        [Route("cinemamovie.com")]
        public IActionResult Cine()
        {
            List<Cine> movie = new List<Cine>();
            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 1,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 2,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 3,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 4,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 5,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 6,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 7,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 8,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 9,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });

            movie.Add(new Cine()
            {
                CreatedDate = DateTime.Now,
                Id = 10,
                Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg",
                Name = "in the eyes",

            });



            return View(movie);
        }
    }
}
