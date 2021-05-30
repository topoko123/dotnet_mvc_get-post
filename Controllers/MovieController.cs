using System.Linq;
using dotnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc.Controllers
{
    public class MovieController : Controller
    {
        // public IActionResult Index(int? id, string titleName) 
        // {
        //     var repo = new MovieRepository();
        //     var selectData = repo.GetMovie();
        //     if (id != null)
        //     {
        //         selectData = selectData.Where(m => m.Id == id).ToList();
        //     }
        //     ViewData["titleName"] = titleName;
        //     return View(selectData);
        // }

        public IActionResult Index()
        {
            var repo = new MovieRepository();
            var selectData = repo.GetMovie();
            return View(selectData);
        }

        [HttpPost]
        public IActionResult Index(SortInputModel model, [FromForm] string specialData) 
        {
            var repo = new MovieRepository();
            var selectData = repo.GetMovie();
            if (!string.IsNullOrEmpty(model.sort)) {
                switch (model.sort)
                {
                    case "id":
                        if (model.order == "asc")
                        {
                            selectData = selectData.OrderBy(m => m.Id).ToList();
                        }
                        else
                        {
                            selectData = selectData.OrderByDescending(m => m.Id).ToList();
                        }
                        break;
                    case "title":
                        if (model.order == "asc")
                        {
                            selectData = selectData.OrderBy(m => m.Title).ToList();
                        }
                        else
                        {
                            selectData = selectData.OrderByDescending(m => m.Title).ToList();
                        }
                        break;
                    case "releaseDate":
                        if (model.order == "asc")
                        {
                            selectData = selectData.OrderBy(m => m.ReleaseDate).ToList();
                        }
                        else
                        {
                            selectData = selectData.OrderByDescending(m => m.ReleaseDate).ToList();
                        }
                        break;
                    case "genre":
                        if (model.order == "asc")
                        {
                            selectData = selectData.OrderBy(m => m.Genre).ToList();
                        }
                        else
                        {
                            selectData = selectData.OrderByDescending(m => m.Genre).ToList();
                        }
                        break;
                    case "price":
                        if (model.order == "asc")
                        {
                            selectData = selectData.OrderBy(m => m.Price).ToList();
                        }
                        else
                        {
                            selectData = selectData.OrderByDescending(m => m.Price).ToList();
                        }
                        break;
                    default:
                        break;
                }
            }
            return View(selectData);
        }

        [HttpPost]
        public IActionResult DeleteMovie(int movieId) 
        {
            var repo = new MovieRepository();
            repo.DeleteMovie(movieId);
            return RedirectToAction("Index");
        }
    }
}