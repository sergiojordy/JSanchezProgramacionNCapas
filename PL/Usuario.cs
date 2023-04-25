using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();
            
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            Console.WriteLine("Ingrese el ID del rol del usuario: ");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del usuario: ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido paterno del usuario: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido materno del usuario: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de usuario (Username): ");
            usuario.UserName = Console.ReadLine();

            //Console.WriteLine("Ingrese la fecha de nacimiento del usuario: ");
            //usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine()); // Formato de fecha como en el sistema

            Console.WriteLine("Ingrese la fecha de nacimiento del usuario: ");
            usuario.FechaNacimiento = Console.ReadLine(); // Formato de fecha 105: dd-mm-aaaa

            Console.WriteLine("Ingrese el sexo del usuario (M/F): ");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono del usuario: ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el celular del usuario: ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese el CURP del usuario: ");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese el email del usuario: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el password del usuario: ");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingrese la calle del usuario:");
            usuario.Direccion.Calle = Console.ReadLine();

            Console.WriteLine("Ingrese el numero exterior del usuario:");
            usuario.Direccion.NumeroExterior = Console.ReadLine();

            Console.WriteLine("Ingrese el numero interior del usuario (Opcional):");
            usuario.Direccion.NumeroInterior = Console.ReadLine();

            Console.WriteLine("Ingrese el ID de la colonia del usuario");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Add(usuario);
            //ML.Result result = BL.Usuario.AddSp(usuario);
            ML.Result result = BL.Usuario.AddEF(usuario);
            //ML.Result result = BL.Usuario.AddLINQ(usuario);

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
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            Console.WriteLine("\nIngrese el ID del usuario a actualizar:");
            usuario.IdUsuario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese el nuevo ID del rol del usuario:");
            usuario.Rol.IdRol = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo nombre del usuario:");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo apellido paterno del usuario:");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo apellido materno del usuario:");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo username del usuario:");
            usuario.UserName = Console.ReadLine();

            //Console.WriteLine("Ingrese la nueva fecha de nacimiento del usuario:");
            //usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine()); // Formato de fecha como en el sistema

            Console.WriteLine("Ingrese la fecha de nacimiento del usuario: ");
            usuario.FechaNacimiento = Console.ReadLine(); // Formato de fecha 105: dd-mm-aaaa

            Console.WriteLine("Ingrese el nuevo sexo del usuario (M/F):");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo telefono del usuario:");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo celular del usuario:");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo CURP del usuario:");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo email del usuario:");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo password del usuario:");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva calle del usuario:");
            usuario.Direccion.Calle = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo numero exterior del usuario:");
            usuario.Direccion.NumeroExterior = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo numero interior del usuario (Opcional):");
            usuario.Direccion.NumeroInterior = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo ID de la colonia del usuario");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());


            //ML.Result result = BL.Usuario.Update(usuario);
            //ML.Result result = BL.Usuario.UpdateSp(usuario);
            ML.Result result = BL.Usuario.UpdateEF(usuario);
            //ML.Result result = BL.Usuario.UpdateLINQ(usuario);


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
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("\nIngrese el ID del usuario a eliminar:");
            int idUsuario = Convert.ToInt32(Console.ReadLine());

            //ML.Result result = BL.Usuario.Delete(idUsuario);
            //ML.Result result = BL.Usuario.DeleteSp(idUsuario);
            ML.Result result = BL.Usuario.DeleteEF(idUsuario);
            //ML.Result result = BL.Usuario.DeleteLINQ(idUsuario);

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
            //ML.Result result = BL.Usuario.GetAll();
            //ML.Result result = BL.Usuario.GetAllSp();
            ML.Result result = BL.Usuario.GetAllEF();
            //ML.Result result = BL.Usuario.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("\nId: " + usuario.IdUsuario + "\nUserName: " + usuario.UserName + "\nRol: " + usuario.Rol.Nombre + "\nNombre: " + usuario.Nombre
                    + "\nApellido Paterno: " + usuario.ApellidoPaterno + "\nApellido Materno: " + usuario.ApellidoMaterno
                    + "\nFecha de Nacimiento: " + usuario.FechaNacimiento + "\nEmail: " + usuario.Email + "\nPassword: " + usuario.Password +
                    "\nSexo: " + usuario.Sexo + "\nTelefono: " + usuario.Telefono + "\nCelular: " + usuario.Celular +
                    "\nCURP: " + usuario.CURP);
                    
                    Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                    Console.WriteLine("Numero Exterior: " + usuario.Direccion.NumeroExterior);
                    Console.WriteLine("Numero Interior: " + usuario.Direccion.NumeroInterior);
                    Console.WriteLine("Id Colonia: " + usuario.Direccion.Colonia.IdColonia);
                    Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);
                    Console.WriteLine("Codigo Postal: " + usuario.Direccion.Colonia.CodigoPostal);
                    Console.WriteLine("ID Municipio: " + usuario.Direccion.Colonia.Municipio.IdMunicipio);
                    Console.WriteLine("Municipio: " + usuario.Direccion.Colonia.Municipio.Nombre);
                    Console.WriteLine("ID Estado: " + usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    Console.WriteLine("Estado: " + usuario.Direccion.Colonia.Municipio.Estado.Nombre);
                    Console.WriteLine("ID Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                    Console.WriteLine("Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre);

                    Console.WriteLine("\n-------------------------------------------");

                
                    
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error al traer los registros: " + result.ErrorMessage);
            }

        }

        public static void GetById()
        {

            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el ID del usuario a consultar:");
            //usuario.IdUsuario = Convert.ToInt32(Console.ReadLine());
            int idUsuario = Convert.ToInt32(Console.ReadLine());

            //ML.Result result = BL.Usuario.GetById(idUsuario);
            //ML.Result result = BL.Usuario.GetByIdSp(idUsuario);
            ML.Result result = BL.Usuario.GetByIdEF(idUsuario);
            //ML.Result result = BL.Usuario.GetByIdLINQ(idUsuario);

            if (result.Correct)
            {
                ML.Usuario usuarioUnboxing = (ML.Usuario)result.Object; // Unboxing del objeto que trae result.Object

                Console.WriteLine("\nId: " + usuarioUnboxing.IdUsuario + "\nUserName: " + usuarioUnboxing.UserName + "\nRol: " + usuarioUnboxing.Rol.Nombre + "\nNombre: " + usuarioUnboxing.Nombre
                + "\nApellido Paterno: " + usuarioUnboxing.ApellidoPaterno + "\nApellido Materno: " + usuarioUnboxing.ApellidoMaterno
                + "\nFecha de Nacimiento: " + usuarioUnboxing.FechaNacimiento + "\nEmail: " + usuarioUnboxing.Email + "\nPassword: " + usuarioUnboxing.Password
                + "\nSexo: " + usuarioUnboxing.Sexo + "\nTelefono: " + usuarioUnboxing.Telefono + "\nCelular: " + usuarioUnboxing.Celular
                + "\nCURP: " + usuarioUnboxing.CURP);

                Console.WriteLine("Calle: " + usuarioUnboxing.Direccion.Calle);
                Console.WriteLine("Numero Exterior: " + usuarioUnboxing.Direccion.NumeroExterior);
                Console.WriteLine("Numero Interior: " + usuarioUnboxing.Direccion.NumeroInterior);
                Console.WriteLine("Id Colonia: " + usuarioUnboxing.Direccion.Colonia.IdColonia);
                Console.WriteLine("Colonia: " + usuarioUnboxing.Direccion.Colonia.Nombre);
                Console.WriteLine("Codigo Postal: " + usuarioUnboxing.Direccion.Colonia.CodigoPostal);
                Console.WriteLine("ID Municipio: " + usuarioUnboxing.Direccion.Colonia.Municipio.IdMunicipio);
                Console.WriteLine("Municipio: " + usuarioUnboxing.Direccion.Colonia.Municipio.Nombre);
                Console.WriteLine("ID Estado: " + usuarioUnboxing.Direccion.Colonia.Municipio.Estado.IdEstado);
                Console.WriteLine("Estado: " + usuarioUnboxing.Direccion.Colonia.Municipio.Estado.Nombre);
                Console.WriteLine("ID Pais: " + usuarioUnboxing.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                Console.WriteLine("Pais: " + usuarioUnboxing.Direccion.Colonia.Municipio.Estado.Pais.Nombre);
            }
            else
            {
                Console.WriteLine("\nOcurrio un error al traer el registro: " + result.ErrorMessage);
            }
        }
        
    }
}
