using Inventario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TKG_Inventario.DTO;

namespace TKG_Inventario.DAL
{
    public class GestorProducto
    {

        /* Atributos Producto

        private string codProducto;
        private string nombre;
        private int precio;
        private int cantTotal;
        private int cantDisponible;
        private string lugarGuardado;
        private FamiliaProducto familiaProducto;
        private int estado;
          */
        private static string path = "Archivos/Productos.txt";
        private static Utilidades util = new Utilidades();
        private GestorFamiliaProducto gestorFamiliaProducto = new GestorFamiliaProducto();

        public void IngresarProducto(Producto producto)
        {
            StreamWriter Archivo = new StreamWriter(path, true);
            Archivo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", producto.CodProducto, producto.Nombre, producto.Precio, producto.CantTotal, producto.CantDisponible, producto.LugarGuardado, producto.FamiliaProducto.IdFamiliaProducto, producto.Estado);
            Archivo.Close();

        }

        public Producto BuscarProducto(String codProducto)
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[0] == codProducto)
                    {
                        Producto p = new Producto(datos[0], datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5], gestorFamiliaProducto.BuscarPorId(new FamiliaProducto(int.Parse(datos[6]), "", "")), int.Parse(datos[7]));
                        Archivo.Close();
                        return p;
                    }
                }
            } while (linea != null);
            Archivo.Close();
            return null;
        }

        public void ModificarProducto(Producto producto, Producto productoAntiguo)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/ProductoTmp.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((productoAntiguo.CodProducto == datos[0]) && (linea != null))
                    {
                        ArchivoTmp.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", producto.CodProducto, producto.Nombre, producto.Precio, producto.CantTotal, producto.CantDisponible, producto.LugarGuardado, producto.FamiliaProducto.IdFamiliaProducto, producto.Estado);
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
            File.Move("Archivos/ProductoTmp.txt", path);
        }

        public void EliminarProducto(string codigoProducto)
        {
            StreamReader Archivo = File.OpenText(path);
            StreamWriter ArchivoTmp = new StreamWriter("Archivos/Respaldo/Productos.txt", true);
            string linea;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if ((codigoProducto != datos[0]) && (linea != null))
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
            File.Move("Archivos/Respaldo/Productos.txt", path);
        }

        public List<Producto> Mostrar()
        {
            StreamReader Archivo = File.OpenText(path);
            string linea;
            List<Producto> productos = new List<Producto>();
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(';');
                    Producto producto = new Producto(datos[0], datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5], gestorFamiliaProducto.BuscarPorId(new FamiliaProducto(int.Parse(datos[6]), "", "")), int.Parse(datos[7]));
                    if (producto.FamiliaProducto == null)
                    {

                        FamiliaProducto familiaSinAsignar = new FamiliaProducto(0, "Sin Familia", " ");
                        producto.FamiliaProducto = familiaSinAsignar;
                    }
                    productos.Add(producto);
                }
            } while (linea != null);
            Archivo.Close();
            return productos;
        }


    }
}