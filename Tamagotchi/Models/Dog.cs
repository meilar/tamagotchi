using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Dog : Pet
  {
    // public string Name { get; set; }
    // public int PlayPoints { get; set; }
    // public int EnergyPoints { get; set; }
    // public int HungerPoints { get; set; }
    // public string Type { get; set; }

    // private static List<Pet> _petList = new List<Pet> { };

    // public static List<Pet> GetPets()
    // {
    //   return _petList;
    // }

    public Dog (string name, string type) : base (name, type)
    {
      Name = name;
      Type = type;
      EnergyPoints = 70;
      HungerPoints = 70;
      PlayPoints = 70;
      Pet.GetPets().Add(this);
    }

    // public void Sleep()
    // {
    //   this.EnergyPoints += 10;
    //   this.HungerPoints -= 10;
    //   this.PlayPoints -= 5;
    // }
    // public void Feed()
    // {
    //   this.EnergyPoints -= 10;
    //   this.HungerPoints += 10;
    //   this.PlayPoints -= 5;
    // }
    // public void Play()
    // {
    //   this.EnergyPoints -= 15;
    //   this.HungerPoints -= 10;
    //   this.PlayPoints += 15;
    // }
  }
}