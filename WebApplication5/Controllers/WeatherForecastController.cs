using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IHeaderDictionary Get()
        {
            var headers = JsonSerializer.Serialize(Request.Headers);
            _logger.LogInformation("Request headers:");
            _logger.LogInformation(headers);
            return Request.Headers;   
        }


    }
}