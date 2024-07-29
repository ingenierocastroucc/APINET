#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# controller MatriculasController>                                                                      
* DescripciÓn   : <Logica de negocio para el manejo de los servicios MatriculasController>                                                      
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
    public class MatriculasController : ControllerBase
    {
        IMatriculasService matriculasService;

        public MatriculasController(IMatriculasService serviceMatricula)
        {
            matriculasService = serviceMatricula;
        }

        ///Funcion para la obtencion de informacion de las matriculas
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(matriculasService.Get());
        }

        ///Funcion para el registro de informacion de las matriculas
        [HttpPost]
        public IActionResult Post([FromBody] Matriculas serviceMatricula)
        {
            matriculasService.Save(serviceMatricula);
            return Ok();
        }

        ///Funcion para la actualizacion de informacion de las matriculas
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Matriculas matriculas)
        {
            matriculasService.Update(id, matriculas);
            return Ok();
        }

        ///Funcion para la eliminacion de las matriculas
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            matriculasService.Delete(id);
            return Ok();
        }
    }
}
