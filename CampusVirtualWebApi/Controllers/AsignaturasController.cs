#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# controller AsignaturasController>                                                                      
* DescripciÓn   : <Logica de negocio para el manejo de los servicios AsignaturasController>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWebApi.Models;
using CampusVirtualWebApi.Services;
using CampusVirtualWebApi.ServicesCampus;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtualWebApi.Controllers
{
    [Route("api/[controller]")]
    public class AsignaturasController : ControllerBase
    {
        IAsignaturaService asignaturaService;

        public AsignaturasController(IAsignaturaService serviceAsignatura)
        {
            asignaturaService = serviceAsignatura;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(asignaturaService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Asignaturas asignaturas)
        {
            asignaturaService.Save(asignaturas);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Asignaturas asignaturas)
        {
            asignaturaService.Update(id, asignaturas);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            asignaturaService.Delete(id);
            return Ok();
        }
    }
}
