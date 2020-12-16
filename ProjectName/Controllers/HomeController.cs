using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {
        [Route("/file")]
        public ActionResult ClassName()
        {
            //instantiate variables here and return View(myVariable)
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

    }
}