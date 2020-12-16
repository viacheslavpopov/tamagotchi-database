using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class PetsController : Controller
    {
        //     [HttpGet("/items")]
        //     public ActionResult Index()
        //     {
        //     List<Item> allItems = Item.GetAll();
        //   return View(allItems);
        //     }

        [HttpGet("/pets/new")]
        public ActionResult New()
        {
            // List<Item> allItems = Item.GetAll();
            return View(myPet);
        }

        [HttpPost("/pets")]
        public ActionResult Create(string petName)
        {
            Pet myPet = new Pet(petName);
            return RedirectToAction("Index");
        }


    }
}
