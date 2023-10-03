using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Animal> model = _db.Animals
                              .OrderBy(a => a.Type)
                              .ToList();
      return View(model);
    }
     public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
    Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
    return View(thisAnimal);
    }
    public ActionResult Search(string searchAnimals)
    {
      List<Animal> searchResults = _db.Animals
        .Where(animal =>
          animal.Breed.Contains(searchAnimals) ||
          animal.Name.Contains(searchAnimals)) 
          .ToList();
    return View("Search", searchResults);
    }
  }
}