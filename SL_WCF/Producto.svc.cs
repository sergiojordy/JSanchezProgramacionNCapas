using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Producto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Producto.svc o Producto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Producto : IProducto
    {
        public SL_WCF.Result ProductoAdd(ML.Producto producto)
        {
            var resultML = BL.Producto.AddEF(producto);

            SL_WCF.Result resultService = new SL_WCF.Result();
            resultService.Correct = resultML.Correct;
            resultService.ErrorMessage = resultML.ErrorMessage;

            //return new SL_WCF.Result
            //{
            //    Correct = resultML.Correct,
            //    ErrorMessage = resultML.ErrorMessage
            //};
            return resultService;
        }

        public SL_WCF.Result ProductoUpdate(ML.Producto producto)
        {
            var resultML = BL.Producto.UpdateEF(producto);

            SL_WCF.Result resultService = new SL_WCF.Result();
            resultService.Correct = resultML.Correct;
            resultService.ErrorMessage = resultML.ErrorMessage;

            //return new SL_WCF.Result
            //{
            //    Correct = resultML.Correct,
            //    ErrorMessage = resultML.ErrorMessage
            //};

            return resultService;
        }

        public SL_WCF.Result ProductoDelete(int idProducto)
        {
            var resultML = BL.Producto.DeleteEF(idProducto);

            SL_WCF.Result resultService = new SL_WCF.Result();
            resultService.Correct = resultML.Correct;
            resultService.ErrorMessage = resultML.ErrorMessage;

            //return new SL_WCF.Result
            //{
            //    Correct = resultML.Correct,
            //    ErrorMessage = resultML.ErrorMessage
            //};
            return resultService;
        }

        public SL_WCF.Result ProductoGetAll()
        {
            var resultML = BL.Producto.GetAllEF();

            SL_WCF.Result resultService = new SL_WCF.Result();
            resultService.Correct = resultML.Correct;
            resultService.ErrorMessage = resultML.ErrorMessage;
            resultService.Objects = resultML.Objects;
            resultService.Object = resultML.Object;

            //return new SL_WCF.Result
            //{
            //    Correct = resultML.Correct,
            //    ErrorMessage = resultML.ErrorMessage
            //};
            
            return resultService;
        }

        public SL_WCF.Result ProductoGetById(int idProducto)
        {
            var resultML = BL.Producto.GetByIdEF(idProducto);

            SL_WCF.Result resultService = new SL_WCF.Result();
            resultService.Correct = resultML.Correct;
            resultService.ErrorMessage = resultML.ErrorMessage;
            resultService.Objects = resultML.Objects;
            resultService.Object = resultML.Object;

            //return new SL_WCF.Result
            //{
            //    Correct = resultML.Correct,
            //    ErrorMessage = resultML.ErrorMessage
            //};
            return resultService;
        }
    }
}
