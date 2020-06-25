using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Compra
    {
        private int cantidad;
        private int codCompra;
        private int precioTotal;
        private DateTime fechaCompra;

        public Compra(int cantidad, int codCompra, int precioTotal, DateTime fechaCompra)
        {
            this.Cantidad = cantidad;
            this.CodCompra = codCompra;
            this.PrecioTotal = precioTotal;
            this.FechaCompra = fechaCompra;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int CodCompra { get => codCompra; set => codCompra = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
    }
}
