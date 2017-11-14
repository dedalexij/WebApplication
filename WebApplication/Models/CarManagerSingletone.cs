using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
  public static class CarManagerSingletone
  {
    private static CarManager _carManager = new CarManager();

    public static CarManager CarManager
    {
      get => _carManager;
    }
  }
}
