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

    // Infer API controller action parameters that come from services
    // https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-2/#infer-api-controller-action-parameters-that-come-from-services
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get(WeatherService weatherService)
    {
        return weatherService.GetForecast();
    }
}
