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
    }
}