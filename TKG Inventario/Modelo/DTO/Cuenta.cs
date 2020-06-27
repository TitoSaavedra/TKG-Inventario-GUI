using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Cuenta
    {
        private int idUsuario;
        private string rut;
        private string nombre;
        private string correo;
        private string nomUsuario;
        private string contrasena;
        private string estado;
        private int idTipoUsuario;

        public Cuenta(string nomUsuario)
        {
            this.NomUsuario = nomUsuario;
        }

        public Cuenta(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Cuenta(int idUsuario, string rut, string nombre, string correo, string nomUsuario, string contrasena, string estado, int idTipoUsuario)
        {
            this.IdUsuario = idUsuario;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Correo = correo;
            this.NomUsuario = nomUsuario;
            this.Contrasena = contrasena;
            this.Estado = estado;
            this.IdTipoUsuario = idTipoUsuario;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
    }
}
