using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumGenerator _numGenerator;
        private readonly INumGenerator2 _numGenerator2;
        public WeatherForecastController(INumGenerator numGenerator, INumGenerator2 numGenerator2)
        {
            _numGenerator= numGenerator;
            _numGenerator2= numGenerator2;
        }
        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            int randomValue2= _numGenerator2.GetNumGeneratorRandomNumber();
            int randomValue1 = _numGenerator.RandomValue;
            return $"RandomValue1 RandomValue:{randomValue1}... RandomValue2 Generator: {randomValue2}....";
        }
    }
}