using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TKG_Inventario.DTO;

namespace TKG_Inventario.DAL
{
    public class GestorFamiliaProducto
    {
        private static string path = "Archivos/FamiliasProductos.txt";


        public void Ingresar(FamiliaProducto familiaProducto)
        {
            List<FamiliaProducto> familiaProductos = Mostrar();
            int id = familiaProductos.Count + 1;
            StreamWriter Archivo = new StreamWriter(path, true);
            Archivo.WriteLine("{0};{1};{2}",id,familiaProducto.Nombre.Trim(),familiaProducto.Descripcion.Trim());
            Archivo.Close();
        }

        public FamiliaProducto Buscar(FamiliaProducto familiaProducto)
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[1].ToLower() == familiaProducto.Nombre.ToLower().Trim())
                    {
                        FamiliaProducto familia = new FamiliaProducto(int.Parse(datos[0]), datos[1], datos[2]);
                        Archivo.Close();
                        return familia;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public FamiliaProducto BuscarPorId(FamiliaProducto familiaProducto)
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[0] == familiaProducto.IdFamiliaProducto+"")
                    {
                        FamiliaProducto familia = new FamiliaProducto(int.Parse(datos[0]), datos[1], datos[2]);
                        Archivo.Close();
                        return familia;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public void Modificar(FamiliaProducto familiaProducto, FamiliaProducto familiaProductoAntigua)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/FamiliaTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((familiaProductoAntigua.IdFamiliaProducto+"" == datos[0]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine("{0};{1};{2}",familiaProducto.IdFamiliaProducto,familiaProducto.Nombre.Trim(),familiaProducto.Descripcion.Trim());
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
            File.Move("Archivos/FamiliaTmp.txt", path);
        }

        public List<FamiliaProducto> Mostrar()
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            List<FamiliaProducto> familiaProductos = new List<FamiliaProducto>();
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    FamiliaProducto familia = new FamiliaProducto(int.Parse(datos[0]), datos[1], datos[2]);
                    familiaProductos.Add(familia);
                }
            } while (linea != null);
            Archivo.Close();
            return familiaProductos;
        }

        public void Eliminar(FamiliaProducto familiaProducto)
        {

            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/FamiliaTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((familiaProducto.IdFamiliaProducto+"" != datos[0]) && (linea != null))
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
            File.Move("Archivos/FamiliaTmp.txt", path);
        }

    }
}
