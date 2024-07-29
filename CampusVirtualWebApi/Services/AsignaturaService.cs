#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# para los servicios de las asignaturas>                                                                      
* DescripciÓn   : <Logica de negocio para los servicios de las asignaturas>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWeb.Context;
using CampusVirtualWebApi.Models;

namespace CampusVirtualWebApi.Services
{
    public class AsignaturaService : IAsignaturaService
    {
        AsignaturaContext context;

        
        ///Acceso a la base de datos
        public AsignaturaService(AsignaturaContext dbcontext)
        { 
               context = dbcontext;
        }
 
        ///Obtencion del listado de saignaturas
        public IEnumerable<Asignaturas> Get()
        {
            return context.AsignaturasVirtual;
        }

        ///Servicio de registro de informacion, para las asignaturas 
        public async Task Save(Asignaturas asignaturas)
        { 
            context.Add(asignaturas);
            await context.SaveChangesAsync();
        }

        ///Servicio de actualizacion de informacion, de las asignaturas 
        public async Task Update(Guid id, Asignaturas asignaturas)
        {
            var asignaturasUpdate = context.AsignaturasVirtual.Find(id);

            if (asignaturasUpdate != null)
            {
                asignaturasUpdate.NombreAsignatura = asignaturas.NombreAsignatura;
                asignaturasUpdate.ProfesorAsignatura = asignaturas.ProfesorAsignatura;
                asignaturasUpdate.Nivelacion = asignaturas.Nivelacion;

                await context.SaveChangesAsync();
            }
        }

        ///Servicio para eliminar asignatura 
        public async Task Delete(Guid id)
        {
            var asignaturasDelete = context.AsignaturasVirtual.Find(id);

            if (asignaturasDelete != null)
            {
                context.Remove(asignaturasDelete);
                await context.SaveChangesAsync();
            }
        }

    }

    //Llamado de los servicios
    public interface IAsignaturaService
    {
        IEnumerable<Asignaturas> Get();
        Task Save(Asignaturas asignaturas);
        Task Update(Guid id, Asignaturas asignaturas);

        Task Delete(Guid id);
    }
}
