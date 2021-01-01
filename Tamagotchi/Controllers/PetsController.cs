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
            List<Pet> allPets = Pet.GetAll();
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

        [HttpPost("/pets/delete")]
        public ActionResult DeleteAll()
        {
            Pet.ClearAll();
            return View();
        }

        [HttpGet("/pets/{id}/edit")] 
        public ActionResult Edit(string petName)
        {
            Pet feedPet = new Pet(petName);
            feedPet.FeedPet();
            // FeedPet(id);
            return RedirectToAction("Show");
        }
    }
}