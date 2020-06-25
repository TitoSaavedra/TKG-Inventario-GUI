using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class FamiliaProducto
    {
        private int idFamiliaProducto;
        private string nombre;
        private string descripcion;

        public FamiliaProducto(int idFamiliaProducto, string nombre, string descripcion)
        {
            this.IdFamiliaProducto = idFamiliaProducto;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdFamiliaProducto { get => idFamiliaProducto; set => idFamiliaProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return "Id Familia Producto : ";
        }

    }
}
