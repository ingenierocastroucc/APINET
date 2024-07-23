#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# controller por defecto ServicesCampus>                                                                      
* DescripciÓn   : <Logica de negocio para el controller por defecto ServicesCampus>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWeb.Context;
using CampusVirtualWebApi.ServicesCampus;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtualWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesCampusController : ControllerBase
    {
        IServicesCampusVirtual iServicesCampusVirtual;

        AsignaturaContext dbcontext;

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

        [HttpGet]
        [Route ("createdb")]
        public IActionResult CreateDataBase() 
        { 
            dbcontext.Database.EnsureCreated();

            return Ok();
        }
    }
}
