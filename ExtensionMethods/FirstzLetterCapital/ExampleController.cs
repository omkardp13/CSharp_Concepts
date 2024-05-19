using System;
using MyApi.Extensions;

namespace MyApi.Controllers
{
    public class ExampleController : ControllerBase
    {
        public IActionResult Get()
        {
            string example = "hello world";
            string result = example.CapitalizeFirstLetter(); // Using the extension method
            return Ok(result); // Outputs: "Hello world"
        }
    }
}
