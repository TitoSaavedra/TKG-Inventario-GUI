namespace TKG_Inventario.DTO
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private int precio;
        private int stock;
        private string estadoProducto;
        private int idFamiliaProducto;

        public Producto(int idProducto, string nombre, int precio, int stock, string estadoProducto, int idFamiliaProducto)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.estadoProducto = estadoProducto;
            this.idFamiliaProducto = idFamiliaProducto;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string EstadoProducto { get => estadoProducto; set => estadoProducto = value; }
        public int IdFamiliaProducto { get => idFamiliaProducto; set => idFamiliaProducto = value; }
    }
}