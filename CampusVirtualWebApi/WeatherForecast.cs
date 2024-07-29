#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : Clase para obtener las propiedas para usar en Middleware                                                                      
* DescripciÓn   : <Logica de negocio para el modelo de matriculas>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024> 
* ===========   ============       ========================================================================= 
* 26/07/2016   Pedro Castro         1. Documentacion
***********************************************************************************************************/
#endregion Documentación
namespace CampusVirtualWebApi
{
    public class WeatherForecast
    {
        /// <summary>
        /// Propiedad para obtener la fecha
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Propiedad para obtener la temperatura
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Propiedad para realizar la conversion a F°
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Propiedad para obtener la data
        /// </summary>
        public string? Summary { get; set; }
    }
}
