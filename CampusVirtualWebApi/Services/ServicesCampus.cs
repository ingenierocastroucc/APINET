#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# inyeccion de dependencias>                                                                      
* DescripciÓn   : <Logica de negocio para realizar la inyeccion de dependencias>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>    
* ===========   ============       ========================================================================= 
* 26/07/2016   Pedro Castro         1. Documentacion
***************************************************************************************************/
#endregion Documentación

namespace CampusVirtualWebApi.ServicesCampus
{
    //Clase para la inyeccion de independencias
    public class ServicesCampus : IServicesCampusVirtual
    {
        public string GetApiDocumentacion()
        {
            return "API para la inyeccion de dependencias";
        }
    }

    public interface IServicesCampusVirtual
    { 
            string GetApiDocumentacion();
    }

}
