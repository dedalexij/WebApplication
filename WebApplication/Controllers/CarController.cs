using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
  [Produces("application/json")]
  [Route("car")]
  public class CarController : Controller
  {
    private CarManager _carManager;
    public CarController()
    {
      _carManager = CarManagerSingletone.CarManager;

    }

    [HttpGet]
    [Route("get/{id}")]
    public IActionResult GetCarById(int id)
    {
      return Ok(_carManager.GetCarByID(id));
    }

    [HttpPost]
    [Route("add")]
    public IActionResult AddCar([FromBody] Car car)
    {
      _carManager.Add(car);
      return Ok(_carManager.Count);
    }

    [HttpPost]
    [Route("put/{id}")]
    public IActionResult ChangeCar(int id, [FromBody] Car car)
    {
      _carManager.ChangeDataOfCar(id, car);
      return Ok(_carManager.GetCarByID(car.Id));
    }
  }
}