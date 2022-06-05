using Microsoft.AspNetCore.Mvc;

namespace DotNet7DemosWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // private readonly WeatherService _weatherService;

    // public WeatherForecastController(WeatherService weatherService)
    // {
    //     _weatherService = weatherService;
    // }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get(WeatherService weatherService)
    {
        return weatherService.GetForecast();
    }
}
