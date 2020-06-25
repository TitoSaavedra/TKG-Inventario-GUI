namespace TKG_Inventario.DTO
{
    public class Producto
    {

        private string codProducto;
        private string nombre;
        private int precio;
        private int cantTotal;
        private int cantDisponible;
        private string lugarGuardado;
        private FamiliaProducto familiaProducto;
        private int estado;

        public Producto(string codProducto)
        {
            this.codProducto = codProducto;
        }

        public Producto(string codProducto, string nombre, int precio, int cantTotal, int cantDisponible, string lugarGuardado, FamiliaProducto familiaProducto, int estado)
        {
            this.codProducto = codProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.cantTotal = cantTotal;
            this.cantDisponible = cantDisponible;
            this.lugarGuardado = lugarGuardado;
            this.familiaProducto = familiaProducto;
            this.estado = estado;
        }

        public string CodProducto { get => codProducto; set => codProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int CantTotal { get => cantTotal; set => cantTotal = value; }
        public int CantDisponible { get => cantDisponible; set => cantDisponible = value; }
        public string LugarGuardado { get => lugarGuardado; set => lugarGuardado = value; }
        public FamiliaProducto FamiliaProducto { get => familiaProducto; set => familiaProducto = value; }
        public int Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return "Codigo : " + this.codProducto + " Familia : " + this.familiaProducto.Nombre + " Nombre : " + this.Nombre + " Precio : " + this.Precio + " Cantidad disponible : " + this.CantDisponible;
        }

    }



}