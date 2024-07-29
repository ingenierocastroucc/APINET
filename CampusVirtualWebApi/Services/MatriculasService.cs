#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# para los servicios de las matriculas>                                                                      
* DescripciÓn   : <Logica de negocio para los servicios de las matriculas>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWeb.Context;
using CampusVirtualWebApi.Models;

namespace CampusVirtualWebApi.Services
{
    public class MatriculasService : IMatriculasService
    {
        AsignaturaContext context;

        //Acceso a la base de datos
        public MatriculasService(AsignaturaContext dbcontext)
        { 
               context = dbcontext;
        }

        ///Servicio para la obtencion de informacion de la matricula
        public IEnumerable<Matriculas> Get()
        {
            return context.MatriculaVirtual;
        }

        ///Servicio para registro de informacion de la matricula
        public async Task Save(Matriculas matriculas)
        { 
            context.Add(matriculas);
            await context.SaveChangesAsync();
        }

        ///Servicio para la actualizacion de informacion de la matricula
        public async Task Update(Guid id, Matriculas matriculas)
        {
            var matricualsUpdate = context.MatriculaVirtual.Find(id);

            if (matricualsUpdate != null)
            {
                matricualsUpdate.NombreAsignatura = matriculas.NombreAsignatura;
                matricualsUpdate.Profesor = matriculas.Profesor;
                matricualsUpdate.TipoInscripcion = matriculas.TipoInscripcion;

                await context.SaveChangesAsync();
            }
        }

        ///Servicio para eliminar matricula
        public async Task Delete(Guid id)
        {
            var matriculasDelete = context.MatriculaVirtual.Find(id);

            if (matriculasDelete != null)
            {
                context.Remove(matriculasDelete);
                await context.SaveChangesAsync();
            }
        }

    }

    ///Llamado de los servicios
    public interface IMatriculasService
    {
        IEnumerable<Matriculas> Get();
        Task Save(Matriculas matriculas);
        Task Update(Guid id, Matriculas matriculas);

        Task Delete(Guid id);
    }
}
