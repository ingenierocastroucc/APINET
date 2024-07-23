#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# para el modelo de matriculas>                                                                      
* DescripciÓn   : <Logica de negocio para el modelo de matriculas>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusVirtualWebApi.Models
{
    public class Matriculas
    {
        public Guid MatriculaId { get; set; }

        public Guid AsignaturaId { get; set; }

        public string NombreAsignatura { get; set; }

        public string Profesor { get; set; }

        public string TipoInscripcion { get; set; }

        public string Semestreinscripcion { get; set; }

        public Prioridad PrioridadMatricula { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual Asignaturas AsignaturasVirtual { get; set; }

    }

    public enum Prioridad
    {

        Baja,
        Media,
        Alta

    }
}