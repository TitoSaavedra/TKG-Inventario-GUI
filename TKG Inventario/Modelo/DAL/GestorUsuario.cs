using Inventario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using TKG_Inventario.DTO;

namespace TKG_Inventario.DAL
{
    public class GestorUsuario
    {
        private static string path = "Archivos/Usuarios.txt";
        private static Utilidades util = new Utilidades();

        public void Ingresar(Usuario usu)
        {
            StreamWriter Archivo = new StreamWriter(path, true);
            Archivo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", 
                usu.Rut.Trim(), usu.Nombre.Trim(), usu.ApellidoPaterno.Trim(), usu.ApellidoMaterno.Trim(),usu.Correo.Trim(),usu.Telefono,usu.NomUsuario.Trim(),util.GetMD5Hash(usu.Contrasena.Trim()), usu.FechaNacimiento,usu.Estado);
            Archivo.Close();
        }

        public Usuario Buscar(String nomUsuario)
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[6] == nomUsuario.Trim())
                    {
                        Usuario usuario = new Usuario(datos[0], datos[1], datos[2], datos[3], datos[4],int.Parse(datos[5]),datos[6],datos[7],DateTime.Parse(datos[8]),int.Parse(datos[9]));
                        Archivo.Close();
                        return usuario;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public Usuario BuscarPorRut(String rut)
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[0] == rut.Trim())
                    {
                        Usuario usuario = new Usuario(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]));
                        Archivo.Close();
                        return usuario;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public void Modificar(Usuario usu,Usuario usuAntiguo)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/UsuariosTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((usuAntiguo.NomUsuario == datos[6]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                            usu.Rut.Trim(), usu.Nombre.Trim(), usu.ApellidoPaterno.Trim(), usu.ApellidoMaterno.Trim(), usu.Correo.Trim(), usu.Telefono, usu.NomUsuario.Trim(), util.GetMD5Hash(usu.Contrasena.Trim()), usu.FechaNacimiento, usu.Estado);
                    }
                    else
                    {
                        ArchivoTmp.WriteLine(linea, Encoding.UTF8);
                    }
                }
            } while (linea != null);
            Archivo.Close();
            ArchivoTmp.Close();

            try
            {
                File.Delete(path);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            File.Move("Archivos/UsuariosTmp.txt", path);
        }

        public List<Usuario> Mostrar()
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            List<Usuario> usuarios = new List<Usuario>();
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    Usuario usuario = new Usuario(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]));
                    usuarios.Add(usuario);
                }
            } while (linea != null);
            Archivo.Close();
            return usuarios;
        }

        public void Eliminar(string nomUsuario)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/UsuariosTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea!=null)
                {
                    string[] datos = linea.Split(';');
                    if ((nomUsuario != datos[6]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine(linea, Encoding.UTF8);
                    }
                }
            } while (linea != null);
            Archivo.Close();
            ArchivoTmp.Close();

            try
            {
                File.Delete(path);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            File.Move("Archivos/UsuariosTmp.txt", path);
        }
    }
    
}
