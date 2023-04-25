using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {
        public static ML.Result AddEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var RowsAffected = context.ProductoAdd(producto.Nombre, (decimal?)producto.PrecioUnitario, producto.Stock, producto.Descripcion, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento);

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result UpdateEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var RowsAffected = context.ProductoUpdate(producto.IdProducto, producto.Nombre, (decimal?)producto.PrecioUnitario, producto.Stock, producto.Descripcion, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento);

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result DeleteEF(int idProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var RowsAffected = context.ProductoDelete(idProducto);

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var productos = context.ProductoGetAll().ToList();

                    if (productos != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var productoObj in productos)
                        {

                            ML.Producto producto = new ML.Producto();
                            producto.Proveedor = new ML.Proveedor();
                            producto.Departamento = new ML.Departamento();

                            producto.IdProducto = productoObj.IdProducto;
                            producto.Nombre = productoObj.Nombre;
                            producto.PrecioUnitario = (double)productoObj.PrecioUnitario;
                            producto.Stock = productoObj.Stock;
                            producto.Descripcion = productoObj.Descripcion;

                            producto.Proveedor.IdProveedor = productoObj.IdProveedor;
                            producto.Proveedor.Nombre = productoObj.NombreProveedor;

                            producto.Departamento.IdDepartamento = productoObj.IdDepartamento;
                            producto.Departamento.Nombre = productoObj.NombreDepartamento;
                            //producto.Departamento.Area = new ML.Area();
                            //producto.Departamento.Area.IdArea = 1;

                            result.Objects.Add(producto);
                            result.Correct = true;
                        }

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetByIdEF(int idProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    // Si no encuentra el ID, lanza mensaje de error. Si lo encuentra, lo trae para imprimir
                    //var query = context.UsuarioGetById(IdUsuario).SingleOrDefault(e => e.IdUsuario == IdUsuario);

                    // Si no encuentra el ID, lanza mensaje de error. Si lo encuentra, lo trae para imprimir
                    //var consulta = context.UsuarioGetById(IdUsuario).FirstOrDefault(e => e.IdUsuario == IdUsuario);

                    // No lanza ningun mensaje de error cuando no encuentra el ID. Si lo encuentra, lo trae para imprimir.
                    //var consulta = context.UsuarioGetById(IdUsuario).First(e => e.IdUsuario == IdUsuario);

                    // No lanza ningun mensaje de error cuando no encuentra el ID. Si lo encuentra, lo trae para imprimir.
                    var productoObj = context.ProductoGetById(idProducto).Single(e => e.IdProducto == idProducto);

                    if (productoObj != null)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.Proveedor = new ML.Proveedor();
                        producto.Departamento = new ML.Departamento();

                        producto.IdProducto = productoObj.IdProducto;
                        producto.Nombre = productoObj.Nombre;
                        producto.PrecioUnitario = (double)productoObj.PrecioUnitario;
                        producto.Stock = productoObj.Stock;
                        producto.Descripcion = productoObj.Descripcion;

                        producto.Proveedor.IdProveedor = productoObj.IdProveedor;
                        producto.Proveedor.Nombre = productoObj.NombreProveedor;

                        producto.Departamento.IdDepartamento = productoObj.IdDepartamento;
                        producto.Departamento.Nombre = productoObj.NombreDepartamento;

                        result.Object = producto;
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error (no hay ese id)";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

    }
}
