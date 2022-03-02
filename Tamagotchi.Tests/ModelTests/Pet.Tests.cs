using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}