using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class PetsController : Controller
    {
        [HttpGet("/pets")]
        public ActionResult Index()
        {
            // Pet myPet = new Pet(petName);
            List<Pet> allPets = Item.GetAll();
            return View(allPets);
        }

        [HttpGet("/pets/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/pets")]
        public ActionResult Create(string petName)
        {
            Pet myPet = new Pet(petName);
            return RedirectToAction("Index");
        }

        [HttpGet("/pets/{id}")]
        public ActionResult Show(int id)
        {
            Pet foundPet = Pet.Find(id);
            return View(foundPet);
        }

    }
}
