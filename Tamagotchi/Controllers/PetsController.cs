using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class PetsController : Controller
    {
        [HttpGet("/pets")]
        public ActionResult Index(string petName)
        {
            Pet myPet = new Pet(petName);
            //List<Item> allItems = Item.GetAll();
            return View(myPet);
        }

        [HttpGet("/pets/new")]
        public ActionResult New()
        {
            // List<Item> allItems = Item.GetAll();
            //Pet myPet = new Pet(petName);
            return View();
        }

        [HttpPost("/pets")]
        public ActionResult Create(string petName)
        {
            Pet myPet = new Pet(petName);
            return View(myPet);
        }


    }
}
