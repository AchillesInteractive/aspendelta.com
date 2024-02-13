using AspenDelta.com.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspenDelta.com.Controllers
{
    [Route("api/[controller]/{id?}")]
    [ApiController]
    public class CarController : ControllerBase
    {

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Car> Get()
        {

            Car myCar1 = new Car { Id = 1, Make = "Chevrolet", Model = "Silverado", Color = "Red", Year = 2016 };
            Car myCar2 = new Car { Id = 2, Make = "Chevrolet", Model = "Traverse", Color = "Blue", Year = 2019 };

            Car[] myCars = new Car[2] { myCar1, myCar2 };

            return myCars.ToArray();

          
        }


     /*   [HttpGet(Name = "GetCar")]
        public Car GetCar()
        {
            Car myCar1 = new Car { Id = 1, Make = "Chevrolet", Model = "Silverado", Color = "Red", Year = 2016 };
            Car myCar2 = new Car { Id = 2, Make = "Chevrolet", Model = "Traverse", Color = "Blue", Year = 2019 };

            Car[] myCars = new Car[2] { myCar1, myCar2 };

            return myCar1;


        }*/

    }
}
