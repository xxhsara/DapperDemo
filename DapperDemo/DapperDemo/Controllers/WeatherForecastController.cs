using DapperDemo.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDbService _dbService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public AccountDto Get()
        {
            var account = _dbService.GetData("a");
            return account;
        }
    }
}