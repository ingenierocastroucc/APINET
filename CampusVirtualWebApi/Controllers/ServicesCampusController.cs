#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# controller por defecto ServicesCampus>                                                                      
* DescripciÓn   : <Logica de negocio para el controller por defecto ServicesCampus, manejo de logs>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWeb.Context;
using CampusVirtualWebApi.ServicesCampus;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtualWebApi.Controllers
{
    /// Manejo de rutas, dataannotetion y swagger
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesCampusController : ControllerBase
    {
        IServicesCampusVirtual iServicesCampusVirtual;

        AsignaturaContext dbcontext;

        /// Manejo de logs
        private readonly ILogger<ServicesCampusController> _logger;

        public ServicesCampusController(IServicesCampusVirtual services, ILogger<ServicesCampusController> loggerCampus, AsignaturaContext db) 
        {
            _logger = loggerCampus;

            iServicesCampusVirtual = services;
            dbcontext = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Lista de ServicesCampus");
            _logger.LogDebug("Debug de ServicesCampus");
            return Ok(iServicesCampusVirtual.GetApiDocumentacion());
        }

        /// Manejo de rutas, dataannotetion y swagger
        [HttpGet]
        [Route ("createdb")]
        public IActionResult CreateDataBase() 
        { 
            dbcontext.Database.EnsureCreated();

            return Ok();
        }
    }
}
