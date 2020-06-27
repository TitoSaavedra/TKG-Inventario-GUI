using Inventario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using TKG_Inventario.DTO;

namespace TKG_Inventario.DAL
{
    public class GestorAdministrador
    {
        /*
        private static string path = "Archivos/Administradores.txt";
        private static Utilidades util = new Utilidades();

        public void Ingresar(Administrator adm)
        {
            StreamWriter Archivo = new StreamWriter(path, true);
            Archivo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}", adm.Rut.Trim(), adm.Nombre.Trim(), adm.ApellidoPaterno.Trim(), adm.ApellidoMaterno.Trim(), adm.Correo.Trim(), adm.Telefono, adm.NomUsuario.Trim(), util.GetMD5Hash(adm.Contrasena.Trim()), adm.FechaNacimiento, adm.Estado, adm.FechaInicioTrabajo);
            Archivo.Close();
        }

        public Administrator Buscar(string nomUsuario)
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
                        Administrator administrador = new Administrator(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]), DateTime.Parse(datos[10]));
                        Archivo.Close();
                        return administrador;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public Administrator BuscarPorRut(string rut)
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
                        Administrator administrador = new Administrator(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]), DateTime.Parse(datos[10]));
                        Archivo.Close();
                        return administrador;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public void Modificar(Administrator adm, Administrator admAntiguo)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/AdministradoresTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((admAntiguo.NomUsuario == datos[6]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}", adm.Rut.Trim(), adm.Nombre.Trim(), adm.ApellidoPaterno.Trim(), adm.ApellidoMaterno.Trim(), adm.Correo.Trim(), adm.Telefono, adm.NomUsuario.Trim(), util.GetMD5Hash(adm.Contrasena.Trim()), adm.FechaNacimiento, adm.Estado, adm.FechaInicioTrabajo);
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
            File.Move("Archivos/AdministradoresTmp.txt", path);
        }

        public void Eliminar(string nombUsuario)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/AdministradoresTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea!=null)
                {
                    string[] datos = linea.Split(';');
                    if ((nombUsuario != datos[6]) && (linea != null))
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
            File.Move("Archivos/AdministradoresTmp.txt", path);
        }

        public List<Administrator> Mostrar()
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            List<Administrator> administradores = new List<Administrator>();
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    Administrator administrador = new Administrator(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]), DateTime.Parse(datos[10]));
                    administradores.Add(administrador);
                }
            } while (linea != null);
            Archivo.Close();
            return administradores;
        }

        public bool VerificarAdministrador(Cuenta cuen)
        {
            string linea;
            StreamReader Archivo;
            Archivo = File.OpenText(path);
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (string.Equals(cuen.NomUsuario, datos[6].Trim()))
                    {
                        Archivo.Close();
                        return true;
                    }
                }
            }
            while (linea != null);
            Archivo.Close();
            return false;
        }
        */
    }
   
}
