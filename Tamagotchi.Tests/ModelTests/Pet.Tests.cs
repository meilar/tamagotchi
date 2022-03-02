using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {
    [TestMethod]
    public void Constructor_CreatesPet_Pet()
    {
      Pet newPet = new Pet("Max", "Dog");
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void Sleep_ModifyPropertyPoints_True()
    {
      Pet newPet = new Pet("Max", "Dog");
      newPet.Sleep();
      Assert.AreEqual(90, newPet.EnergyPoints);
      Assert.AreEqual(70, newPet.HungerPoints);
      Assert.AreEqual(75, newPet.PlayPoints);
    }
  }
}
