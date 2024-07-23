#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# inyeccion de dependencias>                                                                      
* DescripciÓn   : <Logica de negocio para realizar la inyeccion de dependencias>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

namespace CampusVirtualWebApi.ServicesCampus
{
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
