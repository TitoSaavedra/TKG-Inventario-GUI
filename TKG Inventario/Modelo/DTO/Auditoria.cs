using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKG_Inventario.Modelo.DTO
{
    public class Auditoria
    {
        private int idAuditoria;
        private DateTime fecha;
        private string hora;
        private string accion;
        private int usuarioIdUsuario;

        public Auditoria()
        {
        }

        public Auditoria(int idAuditoria, DateTime fecha, string hora, string accion, int usuarioIdUsuario)
        {
            this.idAuditoria = idAuditoria;
            this.fecha = fecha;
            this.hora = hora;
            this.accion = accion;
            this.usuarioIdUsuario = usuarioIdUsuario;
        }

        public int IdAuditoria { get => idAuditoria; set => idAuditoria = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Accion { get => accion; set => accion = value; }
        public int UsuarioIdUsuario { get => usuarioIdUsuario; set => usuarioIdUsuario = value; }
    }
}
