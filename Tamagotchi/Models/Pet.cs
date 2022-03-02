using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet 
  {
    public string Name { get; set; }
    public int AttentionPoints { get; set; }
    public int EnergyPoints { get; set; }
    public int HungerPoints { get; set; }
    public string Type { get; set; }

    private static List<Pet> _petList = new List<Pet> { };

    public Pet(string name, string type)
    {
      Name = name;
      Type = type;
      AttentionPoints = 100;
      EnergyPoints = 100;
      HungerPoints = 100;
      _petList.Add(this);
    }

    public static void Sleep()
    {

    }
    public static void Feed()
    {
      
    }
    public static void Play()
    {
      
    }
  }
}