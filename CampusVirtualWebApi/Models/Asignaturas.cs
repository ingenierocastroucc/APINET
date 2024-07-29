#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# para el modelo de asignaturas>                                                                      
* DescripciÓn   : <Logica de negocio para el modelo de asignaturas>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CampusVirtualWebApi.Models
{
    public class Asignaturas
    {
        /// <summary>
        /// Propiedad para el id de la Asignatura
        /// </summary>
        public Guid AsignaturaId { get; set; }
        
        /// <summary>
        /// Propiedad para el nombre de la asignatura
        /// </summary>
        public string NombreAsignatura { get; set; }

        /// <summary>
        /// Propiedad para el nombre de la asignatura
        /// </summary>
        public string Nombre { get { return NombreAsignatura; } set { NombreAsignatura = value.Trim(); } }

        /// <summary>
        /// Propiedad para almacenar si la asignatura esta asociada a una matricula de nivelacion
        /// </summary>
        public string Nivelacion { get; set; }

        /// <summary>
        /// Propiedad para obtener el profesor
        /// </summary>
        public string ProfesorAsignatura { get; set; }

        /// <summary>
        /// Propiedad para obtener el horario de disponibilidad
        /// </summary>
        public int Horario { get; set; }

        /// <summary>
        /// Propiedad para obtener la fecha de registro
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Propiedad para obtener la coleccion del modelo matriculas
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<Matriculas> MatriculaVirtual { get; set; }
    }
}