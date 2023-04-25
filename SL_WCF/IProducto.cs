using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProducto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProducto
    {
        [OperationContract]
        SL_WCF.Result ProductoAdd(ML.Producto producto);
        [OperationContract]
        SL_WCF.Result ProductoUpdate(ML.Producto producto);
        [OperationContract]
        SL_WCF.Result ProductoDelete(int IdProducto);
        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))] // Especifica el tipo de objeto a devolver. Deserializar
        SL_WCF.Result ProductoGetAll();
        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))] // Especifica el tipo de objeto a devolver. Deserializar
        SL_WCF.Result ProductoGetById(int IdProducto);
    }
    [DataContract]
    public class Result
    {
        [DataMember]
        public bool Correct { get; set; }  // Si la consulta fue exitosa
        [DataMember]
        public string ErrorMessage { get; set; }  // Mensaje de error
        [DataMember]
        public Exception Ex { get; set; } // Detalle del error
        [DataMember]
        public Object Object { get; set; } // Guardar 1 dato
        [DataMember]
        public List<object> Objects { get; set; } // Guardar N datos
    }
}
