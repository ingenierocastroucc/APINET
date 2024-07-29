#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# controller AsignaturasController>                                                                      
* DescripciÓn   : <Logica de negocio para el manejo de los servicios AsignaturasController return>                                                      
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

        ///Funcion que retornar la informacion de la asignatura
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(asignaturaService.Get());
        }

        ///Funcion para el registro de la informacion de la asignatura
        [HttpPost]
        public IActionResult Post([FromBody] Asignaturas asignaturas)
        {
            asignaturaService.Save(asignaturas);
            return Ok();
        }

        ///Funcion para la actualizacion de la informacion de la asignatura
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Asignaturas asignaturas)
        {
            asignaturaService.Update(id, asignaturas);
            return Ok();
        }

        ///Funcion para eliminar la asignatura
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            asignaturaService.Delete(id);
            return Ok();
        }
    }
}
