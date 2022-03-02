using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet 
  {
    public string Name { get; set; }
    public int PlayPoints { get; set; }
    public int EnergyPoints { get; set; }
    public int HungerPoints { get; set; }
    public string Type { get; set; }

    private static List<Pet> _petList = new List<Pet> { };

    public Pet(string name, string type)
    {
      Name = name;
      Type = type;
      EnergyPoints = 80;
      HungerPoints = 80;
      PlayPoints = 80;
      _petList.Add(this);
    }

    public void Sleep()
    {
      this.EnergyPoints += 10;
      this.HungerPoints -= 10;
      this.PlayPoints -= 5;
    }
    public void Feed()
    {
      this.EnergyPoints -= 10;
      this.HungerPoints += 10;
      this.PlayPoints -= 5;
    }
    public void Play()
    {
      this.EnergyPoints -= 15;
      this.HungerPoints -= 10;
      this.PlayPoints += 15;
    }
  }
}