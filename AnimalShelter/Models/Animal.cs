using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int IdAnimals { get; set; }
    public string Name {get; set;}
    public string Gender {get; set;}
    public DateTime DateAdmitted {get; set;}
    public string Breed {get; set;}

    
    // public Animal(string name, string gender, DateTime dateAdmitted, string breed)
    // {
    //   Name = name;
    //   Gender = gender;
    //   DateAdmitted = dateAdmitted;
    //   Breed = breed;
    // }
    // public static List<Animal> GetAll()
    // {
    
    // }
    
  }
}
