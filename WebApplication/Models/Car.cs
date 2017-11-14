using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
  public class Car
  {
    public int Id { get; }
    public string Name {  get; }
    public int Prise { get; }

    public Car(int id, string name, int prise)
    {
      Id = id;
      Name = name;
      Prise = prise;
    }
  }
}
