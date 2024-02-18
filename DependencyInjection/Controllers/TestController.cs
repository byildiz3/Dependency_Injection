using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly INumGenerator _numGenerator;
        public TestController(INumGenerator numGenerator)
        {
            _numGenerator = numGenerator;
        }
        [HttpGet]
        public string Get()
        {
            int number = _numGenerator.RandomValue;
            return number.ToString();
        }
    }
}
