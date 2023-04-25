using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PL
{
    public class Producto
    {

        public static void Add()
        {
            ML.Producto producto = new ML.Producto();
            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();

            Console.WriteLine("Ingresa el nombre del producto");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la descripcion del producto");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("Ingresa el precio del producto");
            producto.PrecioUnitario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del proveedor del producto:");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del departamento del producto:");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            ServiceProducto.ProductoClient serviceProducto = new ServiceProducto.ProductoClient();

            var result = serviceProducto.ProductoAdd(producto);

            if (result.Correct)
            {
                Console.WriteLine("\n¡El registro fue exitoso!");
            }
            else
            {
                Console.WriteLine("\nOcurrió un error: " + result.ErrorMessage + "\n");
            }
        }

        public static void Update()
        {

            ML.Producto producto = new ML.Producto();
            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();

            Console.WriteLine("Ingresa el ID del producto a actualizar:");
            producto.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo nombre del producto:");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la nueva descripcion del producto:");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("Ingresa el nuevo precio del producto:");
            producto.PrecioUnitario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo stock del producto:");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo ID del proveedor del producto:");
            producto.Proveedor.IdProveedor= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo ID del departamento del producto:");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            ServiceProducto.ProductoClient serviceProducto = new ServiceProducto.ProductoClient();

            var result = serviceProducto.ProductoUpdate(producto);

            if (result.Correct)
            {
                Console.WriteLine("\n¡La actualizacion fue exitosa!\n");
            }
            else
            {
                Console.WriteLine("\nOcurrio un error al actualizar el registro: " + result.ErrorMessage + "\n");
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Ingresa el ID del producto a eliminar");
            int idProducto = int.Parse(Console.ReadLine());

            ServiceProducto.ProductoClient serviceProducto = new ServiceProducto.ProductoClient();

            var result = serviceProducto.ProductoDelete(idProducto);

            if (result.Correct)
            {
                Console.WriteLine("\n¡Registro Eliminado!\n");
            }
            else
            {
                Console.WriteLine("\nOcurrio un error al eliminar el registro: " + result.ErrorMessage + "\n");
            }
        }


        public static void GetAll()
        {
            ServiceProducto.ProductoClient serviceProducto = new ServiceProducto.ProductoClient();

            var result = serviceProducto.ProductoGetAll();

            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("Id: " + producto.IdProducto);
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Descripcion: " + producto.Descripcion);
                    Console.WriteLine("Precio: $" + producto.PrecioUnitario);
                    Console.WriteLine("Stock: " + producto.Stock + " unidades");
                    Console.WriteLine("Id Proveedor: " + producto.Proveedor.IdProveedor);
                    Console.WriteLine("Proveedor: " + producto.Proveedor.Nombre);
                    Console.WriteLine("Id Departamento: " + producto.Departamento.IdDepartamento);
                    Console.WriteLine("Departamento: " + producto.Departamento.Nombre);
                    Console.WriteLine("-----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error al traer los registros: " + result.ErrorMessage);
            }
        }


        public static void GetById()
        {

            Console.WriteLine("Ingresa el ID del producto que quieres consultar:");
            int idProducto = int.Parse(Console.ReadLine());

            ServiceProducto.ProductoClient serviceProducto = new ServiceProducto.ProductoClient();

            var result = serviceProducto.ProductoGetById(idProducto);

            if (result.Correct)
            {
                ML.Producto productoUnboxing = (ML.Producto)result.Object; // Unboxing del objeto que trae result.Object

                Console.WriteLine("Id: " + productoUnboxing.IdProducto);
                Console.WriteLine("Nombre: " + productoUnboxing.Nombre);
                Console.WriteLine("Descripcion: " + productoUnboxing.Descripcion);
                Console.WriteLine("Precio: $" + productoUnboxing.PrecioUnitario);
                Console.WriteLine("Stock: " + productoUnboxing.Stock + " unidades");
                Console.WriteLine("Id Proveedor: " + productoUnboxing.Proveedor.IdProveedor);
                Console.WriteLine("Proveedor: " + productoUnboxing.Proveedor.Nombre);
                Console.WriteLine("Id Departamento: " + productoUnboxing.Departamento.IdDepartamento);
                Console.WriteLine("Departamento: " + productoUnboxing.Departamento.Nombre);
            }
            else
            {
                Console.WriteLine("\nOcurrio un error al traer el registro: " + result.ErrorMessage);
            }

        }

        public static void GetAllAPI()
        {
            using(HttpClient client = new HttpClient())
            {
                // Forzar el certificado del WS en caso de error de certificado
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);

                // Se asigna la URL base del Web Service
                //var url = ConfigurationManager.AppSettings["WebApiURL"].ToString();
                //client.BaseAddress = new Uri(url);
                client.BaseAddress = new Uri("https://localhost:44361/api/");

                // Se declara variable que traerá la peticion del WS. La ruta que se le asignara al URL
                // Quedaría como un GET  la ruta urlBase/Producto
                var responseTask = client.GetAsync("Producto");

                // Espera a que termine la ejecucion de responseTask
                responseTask.Wait();

                // En la variable result se guarda el resultado de la tarea de responseTask
                var result = responseTask.Result;

                // Si la respuesta de responseTask fue satisfactoria o exitosa
                if(result.IsSuccessStatusCode)
                {
                    // Los resultados se guardan en readTask
                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    //readTask.Wait();

                    // Se accede a la propiedad Objects de el resultado de readTask
                    foreach (var producto in readTask.Result.Objects)
                    {
                        // Deserializar los resultados obtenidos a un ML.Producto
                        ML.Producto productosList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Producto>(producto.ToString());

                        // Imprimir resultados
                        Console.WriteLine("Id Producto: " + productosList.IdProducto);
                        Console.WriteLine("Nombre: " + productosList.Nombre);
                        Console.WriteLine("Descripcion: " + productosList.Descripcion);
                        Console.WriteLine("Stock: " + productosList.Stock + " unidades");
                        Console.WriteLine("Precio $: " + productosList.PrecioUnitario);
                        Console.WriteLine("Id Proveedor: " + productosList.Proveedor.IdProveedor);
                        Console.WriteLine("Proveedor: " + productosList.Proveedor.Nombre);
                        Console.WriteLine("Id Departamento: " + productosList.Departamento.IdDepartamento);
                        Console.WriteLine("Departamento: " + productosList.Departamento.Nombre);
                        Console.WriteLine("______________________________________________________");
                    }
                }
                else
                {
                    Console.WriteLine("\nOcurrio un error al traer los registros");
                }
            }
        }

        public static void AddAPI()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);

            ML.Producto producto= new ML.Producto();
            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();

            Console.WriteLine("Ingresa el nombre del producto:");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("\nIngresa la descripcion del producto:");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("\nIngresa el precio unitario del producto");
            producto.PrecioUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngresa el stock del producto:");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del proveedor del producto:");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del departamento del producto:");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            using (HttpClient client = new HttpClient())
            {
                //var url = ConfigurationManager.AppSettings["WebApiURL"].ToString();
                //client.BaseAddress = new Uri(url);
                client.BaseAddress = new Uri("https://localhost:44361/api/");

                var postTask = client.PostAsJsonAsync<ML.Producto>("Producto", producto);
                postTask.Wait();

                var result = postTask.Result;

                if(result.IsSuccessStatusCode)
                {
                    Console.WriteLine("\n¡Producto ingresado correctamente!");
                }
                else
                {
                    Console.WriteLine("No se insertó el registro");
                }

            }
        }

        public static void UpdateAPI()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);

            ML.Producto producto = new ML.Producto();
            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();

            Console.WriteLine("Ingresa el Id del producto a actualizar:");
            producto.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngresa el nuevo nombre del producto:");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("\nIngresa la nueva descripcion del producto:");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("\nIngresa el nuevo precio del producto:");
            producto.PrecioUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngresa el nuevo stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo ID del proveedor del producto:");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo ID del departamento del producto:");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            using (HttpClient client = new HttpClient())
            {
                //var url = ConfigurationManager.AppSettings["WebApiURL"].ToString();
                //client.BaseAddress = new Uri(url);
                client.BaseAddress = new Uri("https://localhost:44361/api/");

                var putTask = client.PutAsJsonAsync<ML.Producto>("Producto", producto);
                putTask.Wait();

                var result = putTask.Result;

                if(result.IsSuccessStatusCode)
                {
                    Console.WriteLine("\n¡El registro se actualizó correctamente!");
                }
                else
                {
                    Console.WriteLine("\nOcurrio un error al actualizar el registro");
                }
            }
        }

        public static void DeleteAPI()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);

            Console.WriteLine("Ingresa el Id del producto a eliminar:");
            int idProducto = int.Parse(Console.ReadLine());

            using(HttpClient client = new HttpClient())
            {
                var url = ConfigurationManager.AppSettings["WebApiURL"].ToString();
                client.BaseAddress = new Uri(url);
                //client.BaseAddress = new Uri("https://localhost:44361/api/");

                var deleteTask = client.DeleteAsync("Producto/" + idProducto);
                deleteTask.Wait();

                var result = deleteTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine("\n¡El producto se eliminó correctamente!");
                }
                else
                {
                    Console.WriteLine("No se eliminó el producto");
                }
            }
        }

        public static void GetByIdAPI() 
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);

            Console.WriteLine("Ingresa el id del producto a consultar:");
            int idProducto = int.Parse(Console.ReadLine())
                ;
            using (HttpClient client = new HttpClient())
            {
                //var url = ConfigurationManager.AppSettings["WebApiURL"].ToString();
                //client.BaseAddress = new Uri(url);
                client.BaseAddress = new Uri("https://localhost:44361/api/");
                var getByIdTask = client.GetAsync("Producto/" + idProducto);

                getByIdTask.Wait();

                var result = getByIdTask.Result;

                if(result.IsSuccessStatusCode)
                {
                    // Va a leer de forma asincrona el ML.Result que manda el servicio para obtener la informacion y ver que haya valores
                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    
                    // Se deserializa el ML.Producto
                    ML.Producto producto = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Producto>(readTask.Result.Object.ToString());

                    Console.WriteLine("\nId Producto: " + producto.IdProducto);
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Descripcion: " + producto.Descripcion);
                    Console.WriteLine("Stock: " + producto.Stock + " unidades");
                    Console.WriteLine("Precio $: " + producto.PrecioUnitario);
                    Console.WriteLine("Id Proveedor: " + producto.Proveedor.IdProveedor);
                    Console.WriteLine("Proveedor: " + producto.Proveedor.Nombre);
                    Console.WriteLine("Id Departamento: " + producto.Departamento.IdDepartamento);
                    Console.WriteLine("Departamento: " + producto.Departamento.Nombre);
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al traer el registro");
                }

            }
        }

        public static void AddProducto()
        {
            ML.Producto producto = new ML.Producto();
            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();

            Console.WriteLine("Ingresa el nombre del producto:");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("\nIngresa la descripcion del producto:");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("\nIngresa el precio unitario del producto");
            producto.PrecioUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngresa el stock del producto:");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del proveedor del producto:");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del departamento del producto:");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.AddEF(producto);

            if (result.Correct)
            {
                Console.WriteLine("\n¡Producto ingresado correctamente!");
            }
            else
            {
                Console.WriteLine("Ocurrió un error: " + result.ErrorMessage);
            }
        }

        public static void UpdateProducto()
        {
            ML.Producto producto = new ML.Producto();
            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();

            Console.WriteLine("Ingresa el ID del producto a actualizar:");
            producto.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo nombre del producto:");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("\nIngresa la nueva descripcion del producto:");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("\nIngresa el nuevo precio unitario del producto");
            producto.PrecioUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngresa el nuevo stock del producto:");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del nuevo proveedor del producto:");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el ID del nuevo departamento del producto:");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.UpdateEF(producto);

            if (result.Correct)
            {
                Console.WriteLine("\n¡Producto actualizado correctamente!");
            }
            else
            {
                Console.WriteLine("Ocurrió un error: " + result.ErrorMessage);
            }
        }

        public static void DeleteProducto()
        {

            Console.WriteLine("\nIngrese el ID del producto a eliminar:");
            int idUsuario = Convert.ToInt32(Console.ReadLine());

            ML.Result result = BL.Producto.DeleteEF(idUsuario);

            if (result.Correct)
            {
                Console.WriteLine("\n¡Registro Eliminado!\n");
            }
            else
            {
                Console.WriteLine("\nOcurrio un error al eliminar el registro: " + result.ErrorMessage + "\n");
            }

        }

        public static void GetAllProducto()
        {
            ML.Result result = BL.Producto.GetAllEF();

            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("ID Producto: " + producto.IdProducto);
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Precio Unitario: $" + producto.PrecioUnitario + " MXN");
                    Console.WriteLine("Stock: " + producto.Stock);
                    Console.WriteLine("Descripcion: " + producto.Descripcion);
                    Console.WriteLine("ID Proveedor: " + producto.Proveedor.IdProveedor);
                    Console.WriteLine("Proveedor: " + producto.Proveedor.Nombre);
                    Console.WriteLine("ID Departamento: " + producto.Departamento.IdDepartamento);
                    Console.WriteLine("Departamento: " + producto.Departamento.Nombre);

                    Console.WriteLine("\n-------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error al traer los registros: " + result.ErrorMessage);
            }

        }

        public static void GetByIdProducto()
        {
            Console.WriteLine("Ingrese el ID del usuario a consultar:");
            int idUsuario = Convert.ToInt32(Console.ReadLine());

            ML.Result result = BL.Producto.GetByIdEF(idUsuario);

            if (result.Correct)
            {
                ML.Producto productoUnboxing = (ML.Producto)result.Object; // Unboxing del objeto que trae result.Object

                Console.WriteLine("ID Producto: " + productoUnboxing.IdProducto);
                Console.WriteLine("Nombre: " + productoUnboxing.Nombre);
                Console.WriteLine("Precio Unitario: $" + productoUnboxing.PrecioUnitario + " MXN");
                Console.WriteLine("Stock: " + productoUnboxing.Stock);
                Console.WriteLine("Descripcion: " + productoUnboxing.Descripcion);
                Console.WriteLine("ID Proveedor: " + productoUnboxing.Proveedor.IdProveedor);
                Console.WriteLine("Proveedor: " + productoUnboxing.Proveedor.Nombre);
                Console.WriteLine("ID Departamento: " + productoUnboxing.Departamento.IdDepartamento);
                Console.WriteLine("Departamento: " + productoUnboxing.Departamento.Nombre);
            }
            else
            {
                Console.WriteLine("\nOcurrio un error al traer el registro: " + result.ErrorMessage);
            }
        }


        // Clase para validar (forzar) el certificado del web service
        public static bool ValidateServerCertificate(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
