using System.Collections.Generic;
using MySqlConnector;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }
    public string Name { get; set; }
    public string AdmittanceDate { get; set; }

  }
}