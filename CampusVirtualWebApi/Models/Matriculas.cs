#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : Clase para obtener las propiedades de la matricula                                                                  
* DescripciÓn   : <Logica de negocio para el modelo de matriculas>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>   
* ===========   ============       ========================================================================= 
 * 26/07/2016   Pedro Castro       1. Documentacion
 ***********************************************************************************************************/
#endregion Documentación

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusVirtualWebApi.Models
{
    public class Matriculas
    {
        /// <summary>
        /// Propiedad para obtener el Id de la matricula registrada
        /// </summary>
        public Guid MatriculaId { get; set; }

        /// <summary>
        /// Propiedad para obtener el Id de la asignatura asociada a la matricula registrada
        /// </summary>
        public Guid AsignaturaId { get; set; }

        /// <summary>
        /// Propiedad para obtener el nombre de la asignatura asociada a la matricula registrada
        /// </summary>
        public string NombreAsignatura { get; set; }

        /// <summary>
        /// Propiedad para obtener el profesor de la asignatura
        /// </summary>
        public string Profesor { get; set; }

        /// <summary>
        /// Propiedad para obtener el tipo de inscripcion
        /// </summary>
        public string TipoInscripcion { get; set; }

        /// <summary>
        /// Propiedad para obtener el semestre de inscripcion
        /// </summary>
        public string Semestreinscripcion { get; set; }

        /// <summary>
        /// Propiedad para obtener la prioridad de la matricula
        /// </summary>
        public Prioridad PrioridadMatricula { get; set; }

        /// <summary>
        /// Propiedad para obtener la fecha de registro
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Propiedad para obtener la data de la clase asignaturas
        /// </summary>
        public virtual Asignaturas AsignaturasVirtual { get; set; }

    }

    /// <summary>
    /// Propiedad para la prioridad de la matricula
    /// </summary>
    public enum Prioridad
    {

        Baja,
        Media,
        Alta

    }
}