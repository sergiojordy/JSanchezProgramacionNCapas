using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("\n1. Insertar Usuario\n2. Actualizar Usuario\n3. Eliminar Usuario\n4. Consultar todos los usuarios\n5. Consultar usuario por Id\n\n6. Insertar Producto\n7. Actualizar Producto\n8. Eliminar producto\n9. Consultar todos los productos\n10. Consultar producto por ID\n\n0. Salir\n");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        PL.Usuario.Add();
                        break;

                    case 2:
                        PL.Usuario.Update();
                        break;

                    case 3:
                        PL.Usuario.Delete();
                        break;

                    case 4:
                        PL.Usuario.GetAll();
                        break;

                    case 5:
                        PL.Usuario.GetById();
                        break;

                    case 6:
                        PL.Producto.AddProducto();
                        break;

                    case 7:
                        PL.Producto.UpdateProducto();
                        break;

                    case 8:
                        PL.Producto.DeleteProducto();
                        break;

                    case 9:
                        PL.Producto.GetAllAPI();
                        break;

                    case 10:
                        PL.Producto.GetByIdProducto();
                        break;

                    case 0:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("\nElige una opción válida\n");
                        break;
                }

            } while (salir == false);



            //bool salir = false;

            //do
            //{
            //    Console.WriteLine("\n1. Insertar Usuario\n2. Actualizar Usuario\n3. Eliminar Usuario\n4. Consultar todos los usuarios\n5. Consultar por Id\n6. Salir\n");
            //    int opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            PL.Producto.AddAPI();
            //            break;

            //        case 2:
            //            PL.Producto.UpdateAPI();
            //            break;

            //        case 3:
            //            PL.Producto.DeleteAPI();
            //            break;

            //        case 4:
            //            PL.Producto.GetAllAPI();
            //            break;

            //        case 5:
            //            PL.Producto.GetByIdAPI();
            //            break;

            //        case 6:
            //            salir = true;
            //            break;

            //        default:
            //            Console.WriteLine("\nElige una opción válida\n");
            //            break;
            //    }

            //} while (salir == false);





            //bool salir = false;

            //do
            //{
            //    Console.WriteLine("\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir\n");
            //    int opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            PL.Calculadora.Suma();
            //            break;

            //        case 2:
            //            PL.Calculadora.Resta();
            //            break;

            //        case 3:
            //            PL.Calculadora.Multiplicacion();
            //            break;

            //        case 4:
            //            PL.Calculadora.Division();
            //            break;

            //        case 5:
            //            salir = true;
            //            break;

            //        default:
            //            Console.WriteLine("\nElige una opción válida\n");
            //            break;
            //    }

            //} while (salir == false);

        }
    }
}
