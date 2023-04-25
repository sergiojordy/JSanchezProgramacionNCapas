using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Agregar SqlClient al proyecto
using System.Globalization;
using DL;
using ML;
using System.Data;
using System.Security.Cryptography;
using DL_EF;

namespace BL
{
    public class Usuario
    {
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    //try
        //    //{
        //    //    Conexion conexion = new Conexion();
        //    //    SqlConnection conn = new SqlConnection(conexion.Get());
        //    //    conn.Open();

        //    //    string sentencia = "INSERT INTO Usuario (Nombre, ApellidoPaterno, ApellidoMaterno, Pais, FechaNacimiento) VALUES('" + usuario.Nombre + "','" + usuario.ApellidoPaterno + "','" + usuario.ApellidoMaterno + "','" + usuario.Pais + "','" + usuario.FechaNacimiento + "');";
        //    //    SqlCommand comando = new SqlCommand(sentencia, conn);
        //    //    comando.ExecuteNonQuery();

        //    //    conn.Close();
        //    //    Console.WriteLine("¡El registro se insertó correctamente!");
        //    //    Console.ReadKey();
        //    //} 
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex);
        //    //    Console.ReadKey();
        //    //}
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        // Código que puede tener un error.
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "INSERT INTO [Usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno],[Pais],[FechaNacimiento]) VALUES(@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Pais,@FechaNacimiento);";

        //                SqlParameter[] collection = new SqlParameter[5];

        //                collection[0] = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                //collection[3] = new SqlParameter("Pais", System.Data.SqlDbType.VarChar);
        //                //collection[3].Value = usuario.Pais;

        //                collection[4] = new SqlParameter("FechaNacimiento", System.Data.SqlDbType.Date);
        //                collection[4].Value = usuario.FechaNacimiento;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection = context;

        //                cmd.Connection.Open();

        //                int RowAffected = cmd.ExecuteNonQuery();

        //                if (RowAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al insertar registro";
        //                }

        //            }
        //        };

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;


        //}

        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "UPDATE [Usuario] SET [Nombre] = @Nombre, [ApellidoPaterno] = @ApellidoPaterno, [ApellidoMaterno] = @ApellidoMaterno, [Pais] = @Pais, [FechaNacimiento] = @FechaNacimiento WHERE [IdUsuario] = @IdUsuario;";
        //                SqlParameter[] collection = new SqlParameter[6];

        //                collection[0] = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                //collection[3] = new SqlParameter("Pais", System.Data.SqlDbType.VarChar);
        //                //collection[3].Value = usuario.Pais;

        //                collection[4] = new SqlParameter("FechaNacimiento", System.Data.SqlDbType.Date);
        //                collection[4].Value = usuario.FechaNacimiento;

        //                collection[5] = new SqlParameter("IdUsuario", System.Data.SqlDbType.Int);
        //                collection[5].Value = usuario.IdUsuario;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection = context;

        //                cmd.Connection.Open();

        //                int RowAffected = cmd.ExecuteNonQuery();

        //                if (RowAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrio un error al actualizar el registro";
        //                }
        //            }
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;
        //}
        //public static ML.Result Delete(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "DELETE FROM [Usuario] WHERE [IdUsuario] = @IdUsuario;";
        //                SqlParameter collection = new SqlParameter("IdUsuario", System.Data.SqlDbType.Int);
        //                collection.Value = IdUsuario;

        //                cmd.Parameters.Add(collection);
        //                cmd.Connection = context;

        //                cmd.Connection.Open();

        //                int RowAffected = cmd.ExecuteNonQuery();

        //                if (RowAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrio un error al eliminar el registro";
        //                }
        //            }
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;
        //}

        //public static ML.Result GetAll()
        //{
        //    //try
        //    //{
        //    //    Conexion conexion = new Conexion();
        //    //    SqlConnection conn = new SqlConnection(DL.Conexion.Get());
        //    //    conn.Open();

        //    //    string sentencia = "SELECT * FROM Usuario;";
        //    //    SqlCommand comando = new SqlCommand(sentencia, conn);
        //    //    SqlDataReader registros = comando.ExecuteReader();

        //    //    Console.WriteLine("Registros:\n");
        //    //    while (registros.Read())
        //    //    {
        //    //        Console.WriteLine("ID: " + registros["IdUsuario"].ToString() + "\nNombre: " + registros["Nombre"].ToString() + "\nApellido Paterno: " + registros["ApellidoPaterno"].ToString() + "\nApellido Materno: " + registros["ApellidoMaterno"].ToString() + "\nPais de residencia: " + registros["Pais"].ToString() + "\nFecha de Nacimiento: " + registros["FechaNacimiento"].ToString() + "\n");
        //    //    }

        //    //    conn.Close();
        //    //    Console.ReadKey();
        //    //}
        //    //catch(Exception ex)
        //    //{
        //    //    Console.WriteLine(ex);
        //    //    Console.ReadKey();
        //    //}
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "SELECT [IdUsuario],[Nombre],[ApellidoPaterno],[ApellidoMaterno],[Pais],[FechaNacimiento] FROM [Usuario];";
        //                cmd.Connection = context;

        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable tablaUsuario = new DataTable();
        //                    da.Fill(tablaUsuario);

        //                    if (tablaUsuario.Rows.Count > 0)
        //                    {
        //                        result.Objects = new List<object>(); // Se crea una lista para que no este nula.

        //                        foreach (DataRow row in tablaUsuario.Rows)
        //                        {
        //                            ML.Usuario usuario = new ML.Usuario();

        //                            usuario.IdUsuario = int.Parse(row[0].ToString());
        //                            usuario.Nombre = row[1].ToString();
        //                            usuario.ApellidoPaterno = row[2].ToString();
        //                            usuario.ApellidoMaterno = row[3].ToString();
        //                            //usuario.Pais = row[4].ToString();
        //                            //usuario.FechaNacimiento = DateTime.Parse(row[5].ToString());

        //                            result.Objects.Add(usuario);
        //                        }
        //                        result.Correct = true;
        //                    }
        //                    else
        //                    {
        //                        result.Correct = false;
        //                        result.ErrorMessage = "No se encontraron registros";
        //                    }
        //                }
        //            }
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;
        //}

        //public static ML.Result GetById(int idUsuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "SELECT [IdUsuario],[Nombre],[ApellidoPaterno],[ApellidoMaterno],[Pais],[FechaNacimiento] FROM [Usuario] WHERE [IdUsuario] = @IdUsuario;";
        //                SqlParameter collection = new SqlParameter("IdUsuario", System.Data.SqlDbType.Int);
        //                collection.Value = idUsuario;

        //                cmd.Parameters.Add(collection);
        //                cmd.Connection = context;

        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable tablaUsuario = new DataTable();
        //                    da.Fill(tablaUsuario);

        //                    if (tablaUsuario.Rows.Count > 0)
        //                    {
        //                        DataRow row = tablaUsuario.Rows[0];
        //                        ML.Usuario usuario = new ML.Usuario();

        //                        //Console.WriteLine(int.Parse(row[0].ToString()));
        //                        usuario.IdUsuario = int.Parse(row[0].ToString());
        //                        usuario.Nombre = row[1].ToString();
        //                        usuario.ApellidoPaterno = row[2].ToString();
        //                        usuario.ApellidoMaterno = row[3].ToString();
        //                        //usuario.Pais = row[4].ToString();
        //                        //usuario.FechaNacimiento = DateTime.Parse(row[5].ToString());

        //                        //object usuarioBoxing = usuario; // Boxing del objeto usuario
        //                        result.Object = usuario; // Asignar a result.Object los valores que tiene el usuario

        //                        //foreach (DataRow row in tablaUsuario.Rows)
        //                        //{
        //                        //    ML.Usuario usuario2 = new ML.Usuario();

        //                        //    usuario2.IdUsuario = int.Parse(row[0].ToString());
        //                        //    usuario2.Nombre = row[1].ToString();
        //                        //    usuario2.ApellidoPaterno = row[2].ToString();
        //                        //    usuario2.ApellidoMaterno = row[3].ToString();
        //                        //    usuario2.Pais = row[4].ToString();
        //                        //    usuario2.FechaNacimiento = DateTime.Parse(row[5].ToString());

        //                        //    object usuarioBoxing = usuario2; // Boxing del objeto usuario
        //                        //    result.Object = usuarioBoxing; // Asignar a result.Object los valores que tiene el usuario
        //                        //}
        //                        result.Correct = true;

        //                    }
        //                    else
        //                    {
        //                        result.Correct = false;
        //                        result.ErrorMessage = "No se encontraron registros";
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;

        //}


        public static ML.Result AddSp(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = "UsuarioAdd";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = usuario.Nombre.ToString();
                        cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = usuario.ApellidoPaterno.ToString();
                        cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = usuario.ApellidoMaterno.ToString();
                        //cmd.Parameters.Add("@Pais", SqlDbType.VarChar).Value = usuario.Pais.ToString();
                        cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = DateTime.Parse(usuario.FechaNacimiento.ToString());

                        cmd.Connection.Open();

                        int RowAffected = cmd.ExecuteNonQuery();

                        if (RowAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al insertar registro";
                        }

                        result.Correct = true;
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

        public static ML.Result UpdateSp(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = "UsuarioUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = usuario.IdUsuario.ToString();
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = usuario.Nombre.ToString();
                        cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = usuario.ApellidoPaterno.ToString();
                        cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = usuario.ApellidoMaterno.ToString();
                        //cmd.Parameters.Add("@Pais", SqlDbType.VarChar).Value = usuario.Pais.ToString();
                        cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = DateTime.Parse(usuario.FechaNacimiento.ToString());

                        cmd.Connection.Open();

                        int RowAffected = cmd.ExecuteNonQuery();

                        if (RowAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrio un error al actualizar el registro";
                        }
                    }
                }

                //result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }


            return result;
        }

        public static ML.Result DeleteSp(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = "UsuarioDelete";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario.ToString();

                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrio un error al eliminar el registro";
                        }
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

        public static ML.Result GetAllSp()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = "UsuarioGetAll";
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tablaUsuario = new DataTable();
                            da.Fill(tablaUsuario);

                            if (tablaUsuario.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();

                                foreach (DataRow row in tablaUsuario.Rows)
                                {
                                    ML.Usuario usuario = new ML.Usuario();

                                    usuario.IdUsuario = int.Parse(row[0].ToString());
                                    usuario.Rol.IdRol = int.Parse(row[1].ToString());
                                    usuario.UserName = row[2].ToString();
                                    usuario.Nombre = row[3].ToString();
                                    usuario.ApellidoPaterno = row[4].ToString();
                                    usuario.ApellidoMaterno = row[5].ToString();
                                    //usuario.Pais = row[4].ToString();
                                    //usuario.FechaNacimiento = DateTime.Parse(row[6].ToString());
                                    usuario.Email = row[7].ToString();
                                    usuario.Password = row[8].ToString();
                                    usuario.Sexo = row[9].ToString();
                                    usuario.Telefono = row[10].ToString();
                                    usuario.Celular = row[11].ToString();
                                    usuario.CURP = row[12].ToString();
                                    //usuario.Imagen= row[13].ToString();

                                    result.Objects.Add(usuario);
                                }
                                result.Correct = true;
                            }
                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "No se encontraron registros";
                            }
                        }
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

        public static ML.Result GetByIdSp(int idUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = "UsuarioGetById";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;


                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tablaUsuario = new DataTable();
                            da.Fill(tablaUsuario);

                            if (tablaUsuario.Rows.Count > 0)
                            {
                                DataRow row = tablaUsuario.Rows[0];
                                ML.Usuario usuario = new ML.Usuario();

                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Rol.IdRol = int.Parse(row[1].ToString());
                                usuario.UserName = row[2].ToString();
                                usuario.Nombre = row[3].ToString();
                                usuario.ApellidoPaterno = row[4].ToString();
                                usuario.ApellidoMaterno = row[5].ToString();
                                //usuario.Pais = row[4].ToString();
                                //usuario.FechaNacimiento = DateTime.Parse(row[6].ToString());
                                usuario.Email = row[7].ToString();
                                usuario.Password = row[8].ToString();
                                usuario.Sexo = row[9].ToString();
                                usuario.Telefono = row[10].ToString();
                                usuario.Celular = row[11].ToString();
                                usuario.CURP = row[12].ToString();
                                //usuario.Imagen= row[13].ToString();

                                result.Object = usuario;
                                result.Correct = true;
                            }

                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "No se encontraron registros";
                            }
                        }
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

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var RowsAffected = context.UsuarioAdd(usuario.Rol.IdRol, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.UserName, usuario.FechaNacimiento, usuario.Email, usuario.Password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP, null, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia);

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
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var RowsAffected = context.UsuarioUpdate(usuario.IdUsuario, usuario.Rol.IdRol, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.UserName, usuario.FechaNacimiento, usuario.Email, usuario.Password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP, null, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia);

                    if(RowsAffected > 0)
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
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            
            return result;
        }

        public static ML.Result DeleteEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var RowsAffected = context.UsuarioDelete(IdUsuario);

                    if(RowsAffected > 0)
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
            catch(Exception ex)
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
                using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var usuarios = context.UsuarioGetAll().ToList();

                    if(usuarios != null)
                    {
                        result.Objects = new List<object>();

                        foreach(var usuarioObj in usuarios)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.Rol = new ML.Rol();
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                            usuario.IdUsuario = usuarioObj.IdUsuario;
                            //usuario.Rol.IdRol = usuarioObj.IdRol ?? 0;
                            usuario.Rol.Nombre = usuarioObj.Nombre_Rol;
                            usuario.UserName = usuarioObj.UserName;
                            usuario.Nombre = usuarioObj.Nombre;
                            usuario.ApellidoPaterno = usuarioObj.ApellidoPaterno;
                            usuario.ApellidoMaterno = usuarioObj.ApellidoMaterno;
                            usuario.FechaNacimiento = usuarioObj.FechaNacimiento.ToString("dd-MM-yyyy");
                            usuario.Email = usuarioObj.Email;
                            usuario.Password = usuarioObj.Password;
                            usuario.Sexo = usuarioObj.Sexo;
                            usuario.Telefono = usuarioObj.Telefono;
                            usuario.Celular = usuarioObj.Celular;
                            usuario.CURP = usuarioObj.CURP;
                            //usuario.Imagen = usuarioObj.Imagen;

                            usuario.Direccion.IdDireccion = usuarioObj.IdDireccion;
                            usuario.Direccion.Calle = usuarioObj.Calle;
                            usuario.Direccion.NumeroExterior = usuarioObj.NumeroExterior;
                            usuario.Direccion.NumeroInterior = usuarioObj.NumeroInterior;

                            usuario.Direccion.Colonia.IdColonia = usuarioObj.IdColonia ?? 0;
                            usuario.Direccion.Colonia.Nombre = usuarioObj.NombreColonia;
                            usuario.Direccion.Colonia.CodigoPostal = usuarioObj.CodigoPostal;

                            usuario.Direccion.Colonia.Municipio.IdMunicipio = usuarioObj.IdMunicipio ?? 0;
                            usuario.Direccion.Colonia.Municipio.Nombre = usuarioObj.NombreMunicipio;

                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = usuarioObj.IdEstado ?? 0;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = usuarioObj.NombreEstado;

                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = usuarioObj.IdPais ?? 0;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = usuarioObj.NombrePais;


                            result.Objects.Add(usuario);
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
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    // Si no encuentra el ID, lanza mensaje de error. Si lo encuentra, lo trae para imprimir
                    //var query = context.UsuarioGetById(IdUsuario).SingleOrDefault(e => e.IdUsuario == IdUsuario);

                    // Si no encuentra el ID, lanza mensaje de error. Si lo encuentra, lo trae para imprimir
                    //var consulta = context.UsuarioGetById(IdUsuario).FirstOrDefault(e => e.IdUsuario == IdUsuario);

                    // No lanza ningun mensaje de error cuando no encuentra el ID. Si lo encuentra, lo trae para imprimir.
                    //var consulta = context.UsuarioGetById(IdUsuario).First(e => e.IdUsuario == IdUsuario);

                    // No lanza ningun mensaje de error cuando no encuentra el ID. Si lo encuentra, lo trae para imprimir.
                    var usuarioObj = context.UsuarioGetById(IdUsuario).Single(e => e.IdUsuario == IdUsuario);

                    if (usuarioObj != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Rol = new ML.Rol();
                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.Colonia = new ML.Colonia();
                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                        usuario.IdUsuario = usuarioObj.IdUsuario;
                        //usuario.IdRol = query.IdRol.Value; // .Value se usa solo al estar seguros que trae un dato
                        //usuario.Rol.IdRol = usuarioObj.IdRol ?? 0; // Operador ternario. Si es NULL, le asigna 0
                        usuario.Rol.Nombre = usuarioObj.Nombre_Rol;
                        usuario.UserName = usuarioObj.UserName;
                        usuario.Nombre = usuarioObj.Nombre;
                        usuario.ApellidoPaterno = usuarioObj.ApellidoPaterno;
                        usuario.ApellidoMaterno = usuarioObj.ApellidoMaterno;
                        usuario.FechaNacimiento =  usuarioObj.FechaNacimiento.ToString("dd-MM-yyyy");
                        usuario.Sexo = usuarioObj.Sexo;
                        usuario.Telefono = usuarioObj.Telefono;
                        usuario.Celular = usuarioObj.Celular;
                        usuario.Email = usuarioObj.Email;
                        usuario.Password = usuarioObj.Password;
                        usuario.CURP = usuarioObj.CURP;
                        //usuario.Imagen = consulta.Imagen;

                        usuario.Direccion.IdDireccion = usuarioObj.IdDireccion;
                        usuario.Direccion.Calle = usuarioObj.Calle;
                        usuario.Direccion.NumeroExterior = usuarioObj.NumeroExterior;
                        usuario.Direccion.NumeroInterior = usuarioObj.NumeroInterior;

                        usuario.Direccion.Colonia.IdColonia = usuarioObj.IdColonia ?? 0;
                        usuario.Direccion.Colonia.Nombre = usuarioObj.NombreColonia;
                        usuario.Direccion.Colonia.CodigoPostal = usuarioObj.CodigoPostal;

                        usuario.Direccion.Colonia.Municipio.IdMunicipio = usuarioObj.IdMunicipio ?? 0;
                        usuario.Direccion.Colonia.Municipio.Nombre = usuarioObj.NombreMunicipio;

                        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = usuarioObj.IdEstado ?? 0;
                        usuario.Direccion.Colonia.Municipio.Estado.Nombre = usuarioObj.NombreEstado;

                        usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = usuarioObj.IdPais ?? 0;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = usuarioObj.NombrePais;


                        result.Object = usuario;
                        result.Correct = true;
                    
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error (no hay ese id)";
                    }
                }

            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        //public static ML.Result AddLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
        //        {
        //            DL_EF.Usuario usuarioLINQ = new DL_EF.Usuario();
        //            usuarioLINQ.IdRol = usuario.Rol.IdRol;
        //            usuarioLINQ.UserName = usuario.UserName;
        //            usuarioLINQ.Nombre = usuario.Nombre;
        //            usuarioLINQ.ApellidoPaterno = usuario.ApellidoPaterno;
        //            usuarioLINQ.ApellidoMaterno = usuario.ApellidoMaterno;
        //            usuarioLINQ.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento,"dd-MM-yyyy", CultureInfo.InvariantCulture);
        //            usuarioLINQ.Sexo = usuario.Sexo;
        //            usuarioLINQ.Email = usuario.Email;
        //            usuarioLINQ.Password = usuario.Password;
        //            usuarioLINQ.Telefono = usuario.Telefono;
        //            usuarioLINQ.Celular = usuario.Celular;
        //            usuarioLINQ.CURP = usuario.CURP;
        //            //usuarioLINQ.Imagen = null;

        //            context.Usuarios.Add(usuarioLINQ);
        //            int RowsAffected = context.SaveChanges();

        //            if (RowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Ocurrio un error. No se insertaron registros";
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;
        //}

        //public static ML.Result UpdateLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
        //        {
        //            var query = (from obj in context.Usuarios
        //                         where obj.IdUsuario == usuario.IdUsuario
        //                         select obj).SingleOrDefault();

        //            if(query != null)
        //            {
        //                query.IdRol = usuario.Rol.IdRol;
        //                query.Nombre = usuario.Nombre;
        //                query.ApellidoPaterno = usuario.ApellidoPaterno;
        //                query.ApellidoMaterno = usuario.ApellidoMaterno;
        //                query.UserName = usuario.UserName;
        //                query.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        //                query.Sexo = usuario.Sexo;
        //                query.Email = usuario.Email;
        //                query.Password = usuario.Password;
        //                query.Telefono = usuario.Telefono;
        //                query.Celular = usuario.Celular;
        //                query.CURP = usuario.CURP;
        //                //query.Imagen = usuario.Imagen;

        //                int RowsAffected = context.SaveChanges();

        //                if(RowsAffected > 0 )
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrio un error. No se actualizo el registro";
        //                }

        //            }

        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al actualizar. La consulta fue nula";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result DeleteLINQ(int idUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
        //        {
        //            var usuario = (from obj in context.Usuarios
        //                         where obj.IdUsuario == idUsuario
        //                         select obj).First();

        //            context.Usuarios.Remove(usuario);
        //            int RowsAffected = context.SaveChanges();

        //            if(RowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al eliminar registro";
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
            
        //    return result;

        //}

        //public static ML.Result GetAllLINQ()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using(DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
        //        {
        //            var usuarios = (from obj in context.Usuarios
        //                            join usuario in context.Usuarios on obj.IdRol equals usuario.IdRol
        //                            join rol in context.Rols on obj.IdRol equals rol.IdRol
        //                            select new { 
        //                                obj.IdUsuario,
        //                                obj.Rol,
        //                                obj.Nombre,
        //                                obj.ApellidoPaterno,
        //                                obj.ApellidoMaterno,
        //                                obj.UserName,
        //                                obj.FechaNacimiento,
        //                                obj.Sexo,
        //                                obj.Email,
        //                                obj.Password,
        //                                obj.Telefono,
        //                                obj.Celular,
        //                                obj.CURP
        //                            }).ToList();

        //            if(usuarios != null && usuarios.Count > 0)
        //            {
        //                result.Objects = new List<object>();

        //                foreach(var element in usuarios)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.Rol = new ML.Rol();
                            
        //                    usuario.IdUsuario = element.IdUsuario;
        //                    usuario.Rol.Nombre = element.Rol.Nombre;
        //                    usuario.UserName = element.UserName;
        //                    usuario.Nombre = element.Nombre;
        //                    usuario.ApellidoPaterno = element.ApellidoPaterno;
        //                    usuario.ApellidoMaterno = element.ApellidoMaterno;
        //                    usuario.FechaNacimiento = element.FechaNacimiento.ToString("dd-MM-yyyy");
        //                    usuario.Email= element.Email;
        //                    usuario.Password = element.Password;
        //                    usuario.Telefono = element.Telefono;
        //                    usuario.Celular = element.Celular;
        //                    usuario.Sexo = element.Sexo;
        //                    usuario.CURP = element.CURP;
        //                    //usuario.Imagen = obj.Imagen;

        //                    result.Objects.Add(usuario);
        //                    result.Correct = true;
        //                }
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Ocurrió un error";
        //            }
        //        }

        //    }
        //    catch(Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }

        //    return result;
        //}

        //public static ML.Result GetByIdLINQ(int idUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
        //        {
        //            //var query = (from obj in context.Usuarios
        //            //             join usuario in context.Usuarios on obj.IdRol equals usuario.IdRol
        //            //             join rol in context.Rols on obj.IdRol equals rol.IdRol
        //            //             where obj.IdUsuario == idUsuario
        //            //             select new
        //            //             {
        //            //                 obj.IdUsuario,
        //            //                 obj.Rol,
        //            //                 obj.Nombre,
        //            //                 obj.ApellidoPaterno,
        //            //                 obj.ApellidoMaterno,
        //            //                 obj.UserName,
        //            //                 obj.FechaNacimiento,
        //            //                 obj.Sexo,
        //            //                 obj.Email,
        //            //                 obj.Password,
        //            //                 obj.Telefono,
        //            //                 obj.Celular,
        //            //                 obj.CURP
        //            //             }).Single();

        //            var query = (from obj in context.Usuarios
        //                         where obj.IdUsuario == idUsuario
        //                         select obj).Single();

        //            if(query != null)
        //            {
        //                ML.Usuario usuario = new ML.Usuario();
        //                usuario.Rol = new ML.Rol();

        //                usuario.IdUsuario = query.IdUsuario;
        //                usuario.Rol.Nombre = query.Rol.Nombre;
        //                usuario.Nombre = query.Nombre;
        //                usuario.ApellidoPaterno = query.ApellidoPaterno;
        //                usuario.ApellidoMaterno= query.ApellidoMaterno;
        //                usuario.UserName = query.UserName;
        //                usuario.FechaNacimiento = query.FechaNacimiento.ToString("dd-MM-yyy");
        //                usuario.Sexo = query.Sexo;
        //                usuario.Email = query.Email;
        //                usuario.Password = query.Password;
        //                usuario.Telefono = query.Telefono;
        //                usuario.Celular = query.Celular;
        //                usuario.CURP = query.CURP;
        //                //usuario.Imagen = query.Imagen;

        //                result.Object = usuario;
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Ocurrió un error";
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}
    }
}
