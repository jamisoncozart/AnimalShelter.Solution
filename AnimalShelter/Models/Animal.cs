using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name {get; set;}
    public string Gender {get; set;}

    // [DataType(DataType.DateTime)]
    // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]    
    public string DateAdmitted {get; set;}
    public string Breed {get; set;}
  }
}
