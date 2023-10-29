using Microsoft.AspNetCore.Mvc;
namespace EncuestaDojo.Controllers;

public class HomeController : Controller{

    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        return View(Index);
    }

    [HttpPost]
        [Route("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
            
        }

}