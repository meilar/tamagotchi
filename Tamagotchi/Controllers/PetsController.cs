using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> friends = Pet.GetPets();
      Pet userPet = friends[0];
      return View(userPet);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name, string type)
    {
      Pet newPet = new Pet(name, type);
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/feed")]
    public ActionResult FeedPet()
    {
      List<Pet> friends = Pet.GetPets();
      friends[0].Feed();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/sleep")]
    public ActionResult SleepPet()
    {
      List<Pet> friends = Pet.GetPets();
      friends[0].Sleep();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/play")]
    public ActionResult PlayPet()
    {
      List<Pet> friends = Pet.GetPets();
      friends[0].Play();
      return RedirectToAction("Index");
    }
  }
}