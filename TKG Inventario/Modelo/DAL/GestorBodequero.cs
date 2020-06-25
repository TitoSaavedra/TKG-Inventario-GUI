using Inventario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using TKG_Inventario.DTO;

namespace TKG_Inventario.DAL
{
    public class GestorBodequero
    {

        private static string path = "Archivos/Bodequeros.txt";
        private static Utilidades util = new Utilidades();

        public void Ingresar(Bodequero bode)
        {
            StreamWriter Archivo = new StreamWriter(path, true);
            Archivo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}", bode.Rut.Trim(), bode.Nombre.Trim(), bode.ApellidoPaterno.Trim(), bode.ApellidoMaterno.Trim(), bode.Correo.Trim(), bode.Telefono, bode.NomUsuario.Trim(), util.GetMD5Hash(bode.Contrasena.Trim()), bode.FechaNacimiento, bode.Estado, bode.FechaInicioTrabajo, bode.BodegaAcargo.Trim());
            Archivo.Close();
        }

        public Bodequero Buscar(string nomUsuario)
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
                        Bodequero bodequero = new Bodequero(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]), datos[11],DateTime.Parse(datos[10]));
                        Archivo.Close();
                        return bodequero;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public Bodequero BuscarPorRut(string rut)
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
                        Bodequero bodequero = new Bodequero(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]), datos[11], DateTime.Parse(datos[10]));
                        Archivo.Close();
                        return bodequero;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public void Modificar(Bodequero bode, Bodequero bodequeroAntiguo)
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
                    if ((bodequeroAntiguo.NomUsuario == datos[6]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}", bode.Rut.Trim(), bode.Nombre.Trim(), bode.ApellidoPaterno.Trim(), bode.ApellidoMaterno.Trim(), bode.Correo.Trim(), bode.Telefono, bode.NomUsuario.Trim(), util.GetMD5Hash(bode.Contrasena.Trim()), bode.FechaNacimiento, bode.Estado, bode.FechaInicioTrabajo, bode.BodegaAcargo.Trim());
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

            public List<Bodequero> Mostrar()
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            List<Bodequero> bodequeros = new List<Bodequero>();
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    Bodequero bodequero = new Bodequero(datos[0], datos[1], datos[2], datos[3], datos[4], int.Parse(datos[5]), datos[6], datos[7], DateTime.Parse(datos[8]), int.Parse(datos[9]), datos[11], DateTime.Parse(datos[10]));
                    bodequeros.Add(bodequero);
                }
            } while (linea != null);
            Archivo.Close();
            return bodequeros;
        }

        public bool verificarBodequero(Bodequero bodeg)
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
                    if (string.Equals(bodeg.NomUsuario, datos[6].Trim()) && string.Equals(bodeg.Contrasena, datos[7].Trim()))
                    {
                        return true;
                    }
                }
            }
            while (linea != null);
            Archivo.Close();
            return false;
        }
    }
}
