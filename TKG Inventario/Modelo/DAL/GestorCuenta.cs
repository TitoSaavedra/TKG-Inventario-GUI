using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TKG_Inventario.DTO;

namespace TKG_Inventario.DAL
{
    public class GestorCuenta
    {

        //private static string path = "Archivos/Cuentas.txt";
        /*
        public void Ingresar(Cuenta cuen)
        {
            StreamWriter Archivo = new StreamWriter(path, true);
            Archivo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",cuen.Rut,cuen.Nombre,cuen.ApellidoPaterno,cuen.ApellidoMaterno,cuen.Correo,cuen.Telefono,cuen.NomUsuario,cuen.Contrasena,cuen.FechaNacimiento,cuen.Estado);
            Archivo.Close();
        }

        public Cuenta Buscar(Cuenta cuen)
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[0] == cuen.NomUsuario)
                    {
                        Cuenta cuenta = new Cuenta(datos[0], datos[1], datos[2], datos[3], datos[4],int.Parse(datos[5]),datos[6],datos[7],DateTime.Parse(datos[8]),int.Parse(datos[9]));
                        Archivo.Close();
                        return cuenta;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public void Modificar(Cuenta cuen,Cuenta cuenAntigua)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/PersonasTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((cuenAntigua.NomUsuario == datos[6]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", cuen.Rut, cuen.Nombre, cuen.ApellidoPaterno, cuen.ApellidoMaterno, cuen.Correo, cuen.Telefono, cuen.NomUsuario, cuen.Contrasena, cuen.FechaNacimiento, cuen.Estado);
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
            File.Move("Archivos/PersonasTmp.txt", path);
        }

        public void Eliminar(string nomUsuario)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/PersonasTmp.txt", true);
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
            File.Move("Archivos/PersonasTmp.txt", path);
        }
        */
    }
    
}
