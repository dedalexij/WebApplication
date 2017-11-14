using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
  public class CarManager
  {
    private List<Car> _cars;

    public int Count => _cars.Count;

    public CarManager()
    {
      _cars = new List<Car>();
    }

    public void Add(Car car)
    {
      _cars.Add(car);
    }

    public Car GetCarByID(int id)
    {
      return _cars.SingleOrDefault(car => car.Id.Equals(id));
    }

    public void ChangeDataOfCar(int id, Car changedCar)
    {
      var index = _cars.FindIndex(car => car.Id == id);
      _cars[index] = changedCar;
    }
  }
}
