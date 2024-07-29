#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# controller por defecto>                                                                      
* DescripciÓn   : <Logica de negocio para el controller por defecto, manejo de rutas y dataannotetion>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using Microsoft.AspNetCore.Mvc;

namespace CampusVirtualWebApi.Controllers
{
    /// Manejo de rutas, dataannotetion y swagger
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            ///Asignacion de rango
            if (ListWeatherForecast.Count == 0)
            {
                ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
              .ToList();
            }
        }

        /// Manejo de rutas, dataannotetion y swagger
        [HttpGet]
        [Route("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Lista de weatherforescast");
            return ListWeatherForecast;
        }

        /// Manejo de rutas, dataannotetion y swagger
        [HttpPost]
        [Route("PostWeatherForecast")]
        public IActionResult Post(WeatherForecast weatherForecast)
        {
            ListWeatherForecast.Add(weatherForecast);

            return Ok();
        }

        /// Manejo de rutas, dataannotetion y swagger
        [HttpDelete]
        [Route("DeleteWeatherForecast/{index}")]
        public IActionResult Delete(int index)
        {
            ListWeatherForecast.RemoveAt(index);

            return Ok();
        }
    }
}
