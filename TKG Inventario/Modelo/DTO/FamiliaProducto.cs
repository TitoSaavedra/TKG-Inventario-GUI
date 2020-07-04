using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class FamiliaProducto
    {
        private int idFamiliaProducto;
        private string nombreFamiliaProducto;
        private string estadoFamiliaProducto;

        public FamiliaProducto(int idFamiliaProducto, string nombreFamiliaProducto, string estadoFamiliaProducto)
        {
            this.idFamiliaProducto = idFamiliaProducto;
            this.nombreFamiliaProducto = nombreFamiliaProducto;
            this.estadoFamiliaProducto = estadoFamiliaProducto;
        }

        public int IdFamiliaProducto { get => idFamiliaProducto; set => idFamiliaProducto = value; }
        public string NombreFamiliaProducto { get => nombreFamiliaProducto; set => nombreFamiliaProducto = value; }
        public string EstadoFamiliaProducto { get => estadoFamiliaProducto; set => estadoFamiliaProducto = value; }
    }
}
