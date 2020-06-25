using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Solicitud
    {
        private int codSolicitud;
        private int estado;
        private DateTime fechaRegistro;
        private DateTime fechaTermino;

        public Solicitud(int codSolicitud, int estado, DateTime fechaRegistro, DateTime fechaTermino)
        {
            this.CodSolicitud = codSolicitud;
            this.Estado = estado;
            this.FechaRegistro = fechaRegistro;
            this.FechaTermino = fechaTermino;
        }

        public int CodSolicitud { get => codSolicitud; set => codSolicitud = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaTermino { get => fechaTermino; set => fechaTermino = value; }
    }
}
