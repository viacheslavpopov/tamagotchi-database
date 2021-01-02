using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tamagotchi.Controllers
{
    public class PetsController : Controller
    {
        private readonly TamagotchiContext _db;
        public PetsController(TamagotchiContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Pet> model = _db.Pets.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            _db.Pets.Add(pet);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Pet thisPet = _db.Pets.FirstOrDefault(pets => pets.Id == id);
            return View(thisPet);
        }
        // public ActionResult Edit(int id)
        // {
        //     var thisPet = _db.Pets.FirstOrDefault(pets => pets.Id == id);
        //     return View(thisPet);
        // }
        // [HttpPost]
        // public ActionResult Edit(Pet pet)
        // {   
        //     _db.Entry(pet).State = EntityState.Modified;
        //     // _db.Pets.PassTime();
        //     _db.SaveChanges();
        //     return RedirectToAction("Index");
        // }
        [HttpPost]
        public ActionResult PassTime(int id)
        {
            var thisPet = _db.Pets.FirstOrDefault(pets => pets.Id == id);
            thisPet.PassTime();
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

    // [HttpPost("/pets/{id}/feed")]
    // public ActionResult Feed(int id)
    // {
    //   Pet foundPet = Pet.Find(id);
    //   foundPet.Feed();
    //   return RedirectToAction("Show");    //RediredtToAction("Show", new { id = })
    // }